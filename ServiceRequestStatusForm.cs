using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MunicipalityApp
{
    public partial class ServiceRequestStatusForm : Form
    {
        private List<ServiceRequest> requests = new();

        public ServiceRequestStatusForm()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            // Sample data
            requests = new List<ServiceRequest>
            {
                new ServiceRequest("REQ001", "Pothole Repair", "Pending", 2),
                new ServiceRequest("REQ002", "Streetlight Fix", "In Progress", 3),
                new ServiceRequest("REQ003", "Water Leak", "Resolved", 1),
                new ServiceRequest("REQ004", "Garbage Collection", "Pending", 4),
                new ServiceRequest("REQ005", "Tree Trimming", "In Progress", 2)
            };

            dgvRequests.DataSource = requests.Select(r => new
            {
                r.RequestID,
                r.Description,
                r.Status,
                r.Priority
            }).ToList();

            MessageBox.Show("Sample Service Requests Loaded Successfully!", "Data Loaded");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string id = txtSearch.Text.Trim();
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Please enter a Request ID to search.");
                return;
            }

            // Use Binary Search Tree
            BinarySearchTree bst = new BinarySearchTree();
            foreach (var req in requests)
                bst.Insert(req);

            var result = bst.Search(id);
            if (result != null)
            {
                MessageBox.Show($"Request Found:\n\nID: {result.RequestID}\nDesc: {result.Description}\nStatus: {result.Status}",
                                "Search Result");

                // Move the searched request to the top
                requests = requests
                    .OrderByDescending(r => r.RequestID == id) // true first
                    .ThenBy(r => r.RequestID) // keep sorted order for the rest
                    .ToList();

                dgvRequests.DataSource = null;
                dgvRequests.DataSource = requests.Select(r => new
                {
                    r.RequestID,
                    r.Description,
                    r.Status,
                    r.Priority
                }).ToList();

                // Highlight top row (searched item)
                if (dgvRequests.Rows.Count > 0)
                {
                    dgvRequests.Rows[0].DefaultCellStyle.BackColor = System.Drawing.Color.LightYellow;
                    dgvRequests.Rows[0].Selected = true;
                    dgvRequests.FirstDisplayedScrollingRowIndex = 0;
                }
            }
            else
            {
                MessageBox.Show("No request found with that ID.", "Not Found");
            }
        }

        private void btnViewPriority_Click(object sender, EventArgs e)
        {
            MinHeap heap = new MinHeap();
            foreach (var req in requests)
                heap.Insert(req);

            string order = "";
            while (heap.Count > 0)
                order += heap.ExtractMin().RequestID + "\n";

            MessageBox.Show("Requests by Priority (lowest number = highest priority):\n\n" + order);
        }

        private void btnGraph_Click(object sender, EventArgs e)
        {
            Graph g = new Graph();
            g.AddEdge("REQ001", "REQ002", 3);
            g.AddEdge("REQ002", "REQ003", 2);
            g.AddEdge("REQ003", "REQ004", 1);
            g.AddEdge("REQ001", "REQ005", 4);

            var bfs = g.BFS("REQ001");
            var mst = g.MinimumSpanningTree();

            string text = "Graph Traversal (BFS):\n" + string.Join(" -> ", bfs) + "\n\nMST Edges:\n";
            foreach (var (a, b, w) in mst)
                text += $"{a} - {b} (Weight: {w})\n";

            MessageBox.Show(text, "Graph & MST");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainMenuForm menu = new MainMenuForm();
            menu.Show();
            this.Hide();
        }
    }

    // ------------------ Data Models & Structures ------------------

    public class ServiceRequest : IComparable<ServiceRequest>
    {
        public string RequestID { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public int Priority { get; set; }

        public ServiceRequest(string id, string desc, string status, int priority)
        {
            RequestID = id;
            Description = desc;
            Status = status;
            Priority = priority;
        }

        public int CompareTo(ServiceRequest other) => RequestID.CompareTo(other.RequestID);
    }

    // 🌳 Basic Binary Search Tree
    public class Node
    {
        public ServiceRequest Data;
        public Node Left, Right;
        public Node(ServiceRequest data) => Data = data;
    }

    public class BinarySearchTree
    {
        private Node root;

        public void Insert(ServiceRequest req)
        {
            root = InsertRec(root, req);
        }

        private Node InsertRec(Node root, ServiceRequest req)
        {
            if (root == null) return new Node(req);
            if (req.RequestID.CompareTo(root.Data.RequestID) < 0)
                root.Left = InsertRec(root.Left, req);
            else
                root.Right = InsertRec(root.Right, req);
            return root;
        }

        public ServiceRequest Search(string id)
        {
            Node current = root;
            while (current != null)
            {
                int cmp = id.CompareTo(current.Data.RequestID);
                if (cmp == 0) return current.Data;
                current = (cmp < 0) ? current.Left : current.Right;
            }
            return null;
        }
    }

    // 🧮 Min Heap (Priority Queue)
    public class MinHeap
    {
        private readonly List<ServiceRequest> elements = new();
        public int Count => elements.Count;

        public void Insert(ServiceRequest item)
        {
            elements.Add(item);
            HeapifyUp(elements.Count - 1);
        }

        public ServiceRequest ExtractMin()
        {
            if (elements.Count == 0)
                throw new InvalidOperationException("Heap is empty");

            var min = elements[0];
            elements[0] = elements[^1];
            elements.RemoveAt(elements.Count - 1);
            HeapifyDown(0);
            return min;
        }

        private void HeapifyUp(int i)
        {
            while (i > 0)
            {
                int parent = (i - 1) / 2;
                if (elements[i].Priority >= elements[parent].Priority)
                    break;
                (elements[i], elements[parent]) = (elements[parent], elements[i]);
                i = parent;
            }
        }

        private void HeapifyDown(int i)
        {
            int last = elements.Count - 1;
            while (true)
            {
                int left = 2 * i + 1, right = 2 * i + 2, smallest = i;
                if (left <= last && elements[left].Priority < elements[smallest].Priority) smallest = left;
                if (right <= last && elements[right].Priority < elements[smallest].Priority) smallest = right;
                if (smallest == i) break;
                (elements[i], elements[smallest]) = (elements[smallest], elements[i]);
                i = smallest;
            }
        }
    }

    // 🔗 Graph + MST
    public class Graph
    {
        private readonly Dictionary<string, List<(string, int)>> adj = new();

        public void AddEdge(string from, string to, int weight)
        {
            if (!adj.ContainsKey(from)) adj[from] = new();
            if (!adj.ContainsKey(to)) adj[to] = new();
            adj[from].Add((to, weight));
            adj[to].Add((from, weight));
        }

        public List<string> BFS(string start)
        {
            var visited = new HashSet<string>();
            var queue = new Queue<string>();
            var order = new List<string>();
            queue.Enqueue(start);
            visited.Add(start);
            while (queue.Count > 0)
            {
                var node = queue.Dequeue();
                order.Add(node);
                foreach (var (neigh, _) in adj[node])
                    if (!visited.Contains(neigh))
                    {
                        visited.Add(neigh);
                        queue.Enqueue(neigh);
                    }
            }
            return order;
        }

        public List<(string, string, int)> MinimumSpanningTree()
        {
            var edges = adj.SelectMany(kv =>
                kv.Value.Select(v => (kv.Key, v.Item1, v.Item2)))
                .Distinct().OrderBy(e => e.Item3).ToList();

            var parent = adj.Keys.ToDictionary(k => k, k => k);
            string Find(string x) => parent[x] == x ? x : parent[x] = Find(parent[x]);
            void Union(string a, string b) => parent[Find(a)] = Find(b);

            var mst = new List<(string, string, int)>();
            foreach (var (u, v, w) in edges)
                if (Find(u) != Find(v))
                {
                    mst.Add((u, v, w));
                    Union(u, v);
                }

            return mst;
        }
    }
}
