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
            // Disable other options
            btnLocalEvents.Enabled = false;
            btnServiceStatus.Enabled = false;
        }

        private void btnReportIssues_Click(object sender, EventArgs e)
        {
            ReportIssuesForm reportForm = new ReportIssuesForm();
            reportForm.Show();
            this.Hide();
        }
        private void btnViewReports_Click(object sender, EventArgs e)
        {
            ViewReportsForm viewReports = new ViewReportsForm();
            viewReports.Show();
            this.Hide();
        }
    }
}

