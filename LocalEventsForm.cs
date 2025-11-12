using System;
using System.Linq;
using System.Windows.Forms;
using MunicipalityApp.Models;

namespace MunicipalityApp
{
    public partial class LocalEventsForm : Form
    {
        private readonly EventManager manager = new();

        public LocalEventsForm()
        {
            InitializeComponent(); // Use designer controls
            manager.SeedSampleData(); // Load sample events
            RefreshCategoryList();
            RefreshEventsGrid(manager.GetAllEvents().ToList());
            ShowNextUpcoming();

            // Event handlers
            btnAddEvent.Click += BtnAddEvent_Click;
            btnSearch.Click += BtnSearch_Click;
            btnBack.Click += BtnBack_Click;
            btnRecommendations.Click += BtnRecommendations_Click;
            dgvEvents.CellDoubleClick += DgvEvents_CellDoubleClick;
        }

        private void RefreshCategoryList()
        {
            cboCategory.BeginUpdate();
            cboCategory.Items.Clear();
            cboCategory.Items.Add("Any");
            foreach (var cat in manager.Categories)
                cboCategory.Items.Add(cat);
            cboCategory.SelectedIndex = 0;
            cboCategory.EndUpdate();
        }

        private void RefreshEventsGrid(System.Collections.Generic.List<Event> events)
        {
            dgvEvents.DataSource = events.Select(e => new
            {
                e.Id,
                e.Date,
                e.Category,
                e.Title,
                e.Description
            }).ToList();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string category = cboCategory.SelectedItem?.ToString();
            if (category == "Any") category = null;
            string keywords = string.IsNullOrWhiteSpace(txtKeywords.Text) ? null : txtKeywords.Text.Trim();

            // Search for events within selected date range
            DateTime? startDate = dtpStartDate.Checked ? dtpStartDate.Value.Date : (DateTime?)null;
            DateTime? endDate = dtpEndDate.Checked ? dtpEndDate.Value.Date : (DateTime?)null;

            var results = manager.Search(category, startDate, endDate, keywords);
            RefreshEventsGrid(results);

            // --- Recommendations Section ---
            lstRecommendations.Items.Clear();
            lstRecommendations.Items.Add("⭐ Recommended for You ⭐");
            lstRecommendations.Items.Add("--------------------------------");

            var recs = manager.GetRecommendations(category, keywords, 5);
            foreach (var r in recs)
                lstRecommendations.Items.Add($"{r.Title} - {r.Category} ({r.Date:yyyy-MM-dd})");

            var next = manager.PeekNextUpcoming();
            if (next != null)
                lstRecommendations.Items.Insert(0, $"Next Upcoming: {next.Title} ({next.Date:yyyy-MM-dd})");
        }


        private void BtnRecommendations_Click(object sender, EventArgs e)
        {
            // Refresh recommendations using last search
            BtnSearch_Click(sender, e);
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            var main = new MainMenuForm();
            main.Show();
            this.Close();
        }

        private void DgvEvents_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var idObj = dgvEvents.Rows[e.RowIndex].Cells["Id"].Value;
            if (idObj == null) return;
            int id = (int)idObj;
            ShowEventDetails(id);
        }

        private void ShowEventDetails(int id)
        {
            var ev = manager.GetEventById(id);
            if (ev == null) return;
            MessageBox.Show(
                $"Title: {ev.Title}\nCategory: {ev.Category}\nDate: {ev.Date:yyyy-MM-dd}\n\n{ev.Description}",
                "Event Details",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void ShowNextUpcoming()
        {
            var next = manager.GetAllEvents().FirstOrDefault();
            if (next != null)
                lstRecommendations.Items.Insert(0, $"Next upcoming: {next.Title} ({next.Date:yyyy-MM-dd})");
        }
        private void BtnAddEvent_Click(object sender, EventArgs e)
        {
            var addForm = new AddEventForm();

            // Pre-fill categories from existing events
            addForm.Categories = manager.Categories.ToArray();

            if (addForm.ShowDialog() == DialogResult.OK)
            {
                var ev = addForm.CreatedEvent;
                if (ev != null)
                {
                    // Add event to manager (EventManager assigns the ID)
                    manager.AddEvent(ev.Title, ev.Category, ev.Date, ev.Description);

                    // Refresh category list to include new category if added
                    RefreshCategoryList();

                    // Refresh DataGridView to show the new event
                    RefreshEventsGrid(manager.GetAllEvents().ToList());

                    // Update recommendations
                    var recs = manager.GetRecommendations(topN: 5);
                    lstRecommendations.Items.Clear();
                    foreach (var r in recs)
                        lstRecommendations.Items.Add($"{r.Title} ({r.Date:yyyy-MM-dd}) - {r.Category}");

                    MessageBox.Show("Event added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        private void LocalEventsForm_Load(object sender, EventArgs e)
        {

        }

        private void lstRecommendations_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstRecommendations_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void lblRecommendations_Click(object sender, EventArgs e)
        {

        }

        private void LocalEventsForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
