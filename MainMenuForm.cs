using System;
using System.Windows.Forms;

namespace MunicipalityApp
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            // Enable all options since all modules (Part 1–3) are now implemented
            btnServiceStatus.Enabled = true;
        }

        private void btnReportIssues_Click(object sender, EventArgs e)
        {
            var reportForm = new ReportIssuesForm();
            reportForm.Show();
            this.Hide();
        }

        private void btnLocalEvents_Click(object sender, EventArgs e)
        {
            var localEventsForm = new LocalEventsForm();
            localEventsForm.Show();
            this.Hide();
        }

        private void btnViewReports_Click(object sender, EventArgs e)
        {
            var viewReports = new ViewReportsForm();
            viewReports.Show();
            this.Hide();
        }

        private void btnServiceStatus_Click(object sender, EventArgs e)
        {
            // Navigate to Service Request Status form (Task 3)
            var statusForm = new ServiceRequestStatusForm();
            statusForm.Show();
            this.Hide();
        }
    }
}
