using System;
using System.Windows.Forms;
using MunicipalityApp.Data;

namespace MunicipalityApp
{
    public partial class ViewReportsForm : Form
    {
        public ViewReportsForm()
        {
            InitializeComponent();
        }

        private void ViewReportsForm_Load(object sender, EventArgs e)
        {
            // Load all issues into the DataGridView
            dgvReports.DataSource = null;
            dgvReports.DataSource = IssueRepository.Issues;

            // Auto-resize columns
            dgvReports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainMenuForm mainMenu = new MainMenuForm();
            mainMenu.Show();
            this.Close();
        }
    }
}

