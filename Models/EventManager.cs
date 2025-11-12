using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace MunicipalityApp.Models
{
    public class EventManager
    {
        private int nextId = 1;

        // Core data structures
        private readonly Dictionary<int, Event> eventsById = new();
        private readonly SortedDictionary<DateTime, List<int>> eventsByDate = new();
        private readonly Dictionary<string, HashSet<int>> invertedIndex = new(StringComparer.OrdinalIgnoreCase);
        private readonly HashSet<string> categories = new(StringComparer.OrdinalIgnoreCase);

        // --- Stack: Tracks recently viewed events (LIFO)
        private readonly Stack<int> recentViewedStack = new();

        // --- Queue: Manages upcoming events (FIFO)
        private readonly Queue<int> upcomingQueue = new();

        // --- Popularity tracking for keywords
        private readonly Dictionary<string, int> searchCounts = new(StringComparer.OrdinalIgnoreCase);

        // --- Regex for keyword tokenization
        private readonly Regex tokenRegex = new(@"\w+", RegexOptions.Compiled);

        public IEnumerable<string> Categories => categories.OrderBy(c => c);

        // Add a new event
        public Event AddEvent(string title, string category, DateTime date, string description = "")
        {
            var ev = new Event(nextId++, title, category, date, description);
            eventsById[ev.Id] = ev;

            // Add by date
            if (!eventsByDate.ContainsKey(ev.Date))
                eventsByDate[ev.Date] = new List<int>();
            eventsByDate[ev.Date].Add(ev.Id);

            // Add to category list
            categories.Add(ev.Category);

            // Index keywords for search
            IndexEvent(ev);

            // Queue upcoming events for easy viewing
            if (ev.Date >= DateTime.Today)
                upcomingQueue.Enqueue(ev.Id);

            return ev;
        }

        private void IndexEvent(Event ev)
        {
            var tokens = Tokenize(ev.Title + " " + ev.Description + " " + ev.Category);
            foreach (var token in tokens)
            {
                if (!invertedIndex.TryGetValue(token, out var set))
                    invertedIndex[token] = set = new HashSet<int>();
                set.Add(ev.Id);
            }
        }

        private IEnumerable<string> Tokenize(string text)
        {
            foreach (Match m in tokenRegex.Matches(text ?? ""))
                yield return m.Value.ToLowerInvariant();
        }

        // Search using keywords, category, date filters
        public List<Event> Search(string category = null, DateTime? startDate = null, DateTime? endDate = null, string keywords = null)
        {
            // Log keywords for recommendations
            if (!string.IsNullOrWhiteSpace(keywords))
            {
                foreach (var token in Tokenize(keywords))
                    searchCounts[token] = searchCounts.GetValueOrDefault(token, 0) + 1;
            }

            HashSet<int> candidates = null;

            // Keyword filtering
            if (!string.IsNullOrWhiteSpace(keywords))
            {
                foreach (var token in Tokenize(keywords))
                {
                    if (invertedIndex.TryGetValue(token, out var ids))
                        candidates = candidates == null ? new HashSet<int>(ids) : candidates.Intersect(ids).ToHashSet();
                    else
                        return new(); // No match for a keyword
                }
            }

            // Category filtering
            if (!string.IsNullOrWhiteSpace(category))
            {
                var categoryIds = eventsById.Values
                    .Where(e => e.Category.Equals(category, StringComparison.OrdinalIgnoreCase))
                    .Select(e => e.Id);
                candidates = candidates == null ? categoryIds.ToHashSet() : candidates.Intersect(categoryIds).ToHashSet();
            }

            // Date range filtering
            if (startDate.HasValue || endDate.HasValue)
            {
                var sd = startDate ?? DateTime.MinValue;
                var ed = endDate ?? DateTime.MaxValue;

                var dateIds = eventsByDate
                    .Where(kv => kv.Key >= sd && kv.Key <= ed)
                    .SelectMany(kv => kv.Value)
                    .ToHashSet();

                candidates = candidates == null ? dateIds : candidates.Intersect(dateIds).ToHashSet();
            }

            // Default: all upcoming
            var results = (candidates == null
                ? eventsByDate.SelectMany(kv => kv.Value.Select(id => eventsById[id]))
                : candidates.Select(id => eventsById[id]))
                .OrderBy(e => e.Date)
                .ToList();

            return results;
        }

        // --- Recommendation Engine ---
        // Uses a priority queue to rank events by relevance
        public List<Event> GetRecommendations(string category = null, string keywords = null, int topN = 5)
        {
            var pq = new PriorityQueue<Event, int>();

            foreach (var ev in eventsById.Values)
            {
                int score = 0;

                // Match by category
                if (!string.IsNullOrWhiteSpace(category) && ev.Category.Equals(category, StringComparison.OrdinalIgnoreCase))
                    score += 50;

                // Match by keyword relevance
                if (!string.IsNullOrWhiteSpace(keywords))
                {
                    foreach (var token in Tokenize(keywords))
                    {
                        if (ev.Title.Contains(token, StringComparison.OrdinalIgnoreCase) ||
                            ev.Description.Contains(token, StringComparison.OrdinalIgnoreCase))
                            score += 20;
                    }
                }

                // Popularity: frequently searched tokens
                foreach (var (token, count) in searchCounts)
                {
                    if (count > 1 && (ev.Title.Contains(token, StringComparison.OrdinalIgnoreCase) ||
                                      ev.Description.Contains(token, StringComparison.OrdinalIgnoreCase)))
                        score += Math.Min(10, count);
                }

                // Upcoming boost
                if ((ev.Date - DateTime.Today).Days <= 7 && (ev.Date - DateTime.Today).Days >= 0)
                    score += 15;

                // Enqueue with negative priority (max-heap behavior)
                pq.Enqueue(ev, -score);
            }

            var results = new List<Event>();
            while (pq.Count > 0 && results.Count < topN)
                results.Add(pq.Dequeue());

            return results;
        }

        // --- Stack usage: recently viewed events ---
        public void MarkViewed(int id)
        {
            if (eventsById.ContainsKey(id))
                recentViewedStack.Push(id);
        }

        public Event UndoLastViewed()
        {
            if (recentViewedStack.Count == 0)
                return null;

            var lastId = recentViewedStack.Pop();
            return eventsById.GetValueOrDefault(lastId);
        }

        // --- Queue usage: peek next upcoming event ---
        public Event PeekNextUpcoming()
        {
            while (upcomingQueue.Count > 0)
            {
                var id = upcomingQueue.Peek();
                if (eventsById.ContainsKey(id))
                    return eventsById[id];
                upcomingQueue.Dequeue(); // Remove stale
            }
            return null;
        }

        // --- Utility ---
        public Event GetEventById(int id) => eventsById.GetValueOrDefault(id);
        public IEnumerable<Event> GetAllEvents() => eventsById.Values.OrderBy(e => e.Date);

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
    }
}
