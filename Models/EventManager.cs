using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MunicipalityApp.Models
{
    public class EventManager
    {
        private int nextId = 1;

        // Core storage: id -> event (hash table / dictionary)
        private readonly Dictionary<int, Event> eventsById = new Dictionary<int, Event>();

        // Sorted dictionary by date -> list of event IDs (keeps dates sorted)
        private readonly SortedDictionary<DateTime, List<int>> eventsByDate = new SortedDictionary<DateTime, List<int>>();

        // inverted index: token -> set of event IDs (hash table + sets)
        private readonly Dictionary<string, HashSet<int>> invertedIndex = new Dictionary<string, HashSet<int>>(StringComparer.OrdinalIgnoreCase);

        // Unique categories set
        private readonly HashSet<string> categories = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

        // Stacks and queues
        private readonly Stack<int> recentViewedStack = new Stack<int>();
        private readonly Queue<int> upcomingQueue = new Queue<int>();

        // Track popular searches: search token -> count
        private readonly Dictionary<string, int> searchCounts = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

        // simple regex for tokenization
        private readonly Regex tokenRegex = new Regex(@"\w+", RegexOptions.Compiled);

        public IEnumerable<string> Categories => categories.OrderBy(c => c);

        // Add a new event and update all structures
        public Event AddEvent(string title, string category, DateTime date, string description = "")
        {
            var ev = new Event(nextId++, title, category, date, description);
            eventsById[ev.Id] = ev;

            if (!eventsByDate.TryGetValue(ev.Date, out var list))
            {
                list = new List<int>();
                eventsByDate[ev.Date] = list;
            }
            list.Add(ev.Id);

            categories.Add(ev.Category);

            IndexEvent(ev);

            // For queue demonstration: events for nearest future go into upcomingQueue
            // For simplicity we enqueue if date >= today
            if (ev.Date >= DateTime.Today) upcomingQueue.Enqueue(ev.Id);

            return ev;
        }

        private void IndexEvent(Event ev)
        {
            var tokens = Tokenize(ev.Title + " " + ev.Description + " " + ev.Category);

            foreach (var token in tokens)
            {
                if (!invertedIndex.TryGetValue(token, out var set))
                {
                    set = new HashSet<int>();
                    invertedIndex[token] = set;
                }
                set.Add(ev.Id);
            }
        }

        private IEnumerable<string> Tokenize(string text)
        {
            var matches = tokenRegex.Matches(text ?? "");
            foreach (System.Text.RegularExpressions.Match m in matches)
                yield return m.Value.ToLowerInvariant();
        }

        // Basic search: category optional, date range optional, keywords optional
        public List<Event> Search(string category = null, DateTime? startDate = null, DateTime? endDate = null, string keywords = null)
        {
            // track search tokens for recommendation feature
            if (!string.IsNullOrWhiteSpace(keywords))
            {
                foreach (var tk in Tokenize(keywords))
                {
                    if (!searchCounts.ContainsKey(tk)) searchCounts[tk] = 0;
                    searchCounts[tk]++;
                }
            }

            HashSet<int> candidates = null;

            // if keywords provided, get intersection of sets for tokens (AND)
            if (!string.IsNullOrWhiteSpace(keywords))
            {
                foreach (var tk in Tokenize(keywords))
                {
                    if (invertedIndex.TryGetValue(tk, out var setForTk))
                    {
                        if (candidates == null) candidates = new HashSet<int>(setForTk);
                        else candidates.IntersectWith(setForTk);
                    }
                    else
                    {
                        // no events for this token -> return empty
                        return new List<Event>();
                    }
                }
            }

            // If category provided, filter by category
            if (!string.IsNullOrWhiteSpace(category))
            {
                var catMatches = new HashSet<int>(
                    eventsById.Values.Where(e => string.Equals(e.Category, category, StringComparison.OrdinalIgnoreCase)).Select(e => e.Id)
                );
                if (candidates == null) candidates = catMatches;
                else candidates.IntersectWith(catMatches);
            }

            // Date range filter using eventsByDate (efficient)
            if (startDate.HasValue || endDate.HasValue)
            {
                var sd = startDate ?? DateTime.MinValue;
                var ed = endDate ?? DateTime.MaxValue;

                var dateIds = new HashSet<int>();
                foreach (var kv in eventsByDate)
                {
                    if (kv.Key < sd) continue;
                    if (kv.Key > ed) break;
                    foreach (var id in kv.Value) dateIds.Add(id);
                }

                if (candidates == null) candidates = dateIds;
                else candidates.IntersectWith(dateIds);
            }

            // If no criteria used, return all upcoming events (sorted by date)
            if (candidates == null)
            {
                var allUpcoming = eventsByDate
                    .SelectMany(kv => kv.Value.Select(id => eventsById[id]))
                    .OrderBy(e => e.Date)
                    .ToList();
                return allUpcoming;
            }

            // map to Event objects and sort by date
            var results = candidates.Select(id => eventsById[id]).OrderBy(e => e.Date).ToList();
            return results;
        }

        // Get top N recommendations based on last search inputs (keywords, category, date range)
        public List<Event> GetRecommendations(string category = null, DateTime? startDate = null, DateTime? endDate = null, string keywords = null, int topN = 5)
        {
            // Build candidate pool: all events that share category or tokens; also include date-proximate events
            var candidateIds = new HashSet<int>();

            if (!string.IsNullOrWhiteSpace(category))
            {
                foreach (var e in eventsById.Values.Where(e => string.Equals(e.Category, category, StringComparison.OrdinalIgnoreCase)))
                    candidateIds.Add(e.Id);
            }

            if (!string.IsNullOrWhiteSpace(keywords))
            {
                foreach (var tk in Tokenize(keywords))
                {
                    if (invertedIndex.TryGetValue(tk, out var set))
                        foreach (var id in set) candidateIds.Add(id);
                }
            }

            // add upcoming events within a week as candidates
            var weekFromNow = DateTime.Today.AddDays(7);
            foreach (var kv in eventsByDate)
            {
                if (kv.Key > weekFromNow) break;
                foreach (var id in kv.Value) candidateIds.Add(id);
            }

            // If still empty, fallback to all events
            if (candidateIds.Count == 0)
                candidateIds.UnionWith(eventsById.Keys);

            // Score each candidate
            var pq = new PriorityQueue<int, int>(); // element: eventId, priority: negative score (we want highest score first -> push negative)
            foreach (var id in candidateIds)
            {
                var ev = eventsById[id];
                int score = 0;

                // category match
                if (!string.IsNullOrWhiteSpace(category) && string.Equals(ev.Category, category, StringComparison.OrdinalIgnoreCase))
                    score += 50;

                // date proximity: within 7 days gets boost
                var daysToEvent = (ev.Date - DateTime.Today).Days;
                if (daysToEvent >= 0 && daysToEvent <= 7) score += 20;

                // keyword matches
                if (!string.IsNullOrWhiteSpace(keywords))
                {
                    foreach (var tk in Tokenize(keywords))
                    {
                        if (invertedIndex.TryGetValue(tk, out var set) && set.Contains(id))
                            score += 10;
                    }
                }

                // popular search terms boost: if event contains very popular tokens
                foreach (var tkCount in searchCounts)
                {
                    if (tkCount.Value > 1) // only consider tokens searched more than once
                    {
                        var token = tkCount.Key;
                        if (Tokenize(ev.Title + " " + ev.Description).Contains(token))
                        {
                            score += Math.Min(10, tkCount.Value); // add up to +10 based on popularity
                        }
                    }
                }

                // push with negative priority to get largest score first
                pq.Enqueue(id, -score);
            }

            var results = new List<Event>();
            int taken = 0;
            while (pq.Count > 0 && taken < topN)
            {
                var id = pq.Dequeue();
                results.Add(eventsById[id]);
                taken++;
            }

            return results;
        }

        // For UI: mark viewed (stack)
        public void MarkViewed(int eventId)
        {
            if (eventsById.ContainsKey(eventId))
            {
                recentViewedStack.Push(eventId);
            }
        }

        // pop last viewed
        public Event UndoLastViewed()
        {
            if (recentViewedStack.Count == 0) return null;
            var id = recentViewedStack.Pop();
            return eventsById.TryGetValue(id, out var ev) ? ev : null;
        }

        // Peek at next upcoming in queue (queue usage)
        public Event PeekNextUpcoming()
        {
            while (upcomingQueue.Count > 0)
            {
                var id = upcomingQueue.Peek();
                if (eventsById.ContainsKey(id)) return eventsById[id];
                upcomingQueue.Dequeue(); // stale id
            }
            return null;
        }

        // utility to seed sample data
        public void SeedSampleData()
        {
            AddEvent("Community Clean-up", "Community", DateTime.Today.AddDays(2), "Volunteers needed for cleaning the park.");
            AddEvent("Job Fair", "Employment", DateTime.Today.AddDays(10), "Employers from around the district.");
            AddEvent("Water Maintenance Notice", "Services", DateTime.Today.AddDays(1), "Planned maintenance - water interruption.");
            AddEvent("Road Closure", "Transport", DateTime.Today.AddDays(3), "Temporary road closure for repairs.");
            AddEvent("Youth Soccer Tournament", "Sports", DateTime.Today.AddDays(7), "Local schools competing.");
            AddEvent("Municipal Budget Meeting", "Council", DateTime.Today.AddDays(5), "Public input invited.");
            AddEvent("Health Screening", "Health", DateTime.Today.AddDays(4), "Free screenings at the clinic.");
            AddEvent("Arts & Culture Market", "Culture", DateTime.Today.AddDays(12), "Local artisans and performers.");
        }

        public Event GetEventById(int id) => eventsById.TryGetValue(id, out var e) ? e : null;
        public IEnumerable<Event> GetAllEvents() => eventsById.Values.OrderBy(e => e.Date);
    }
}