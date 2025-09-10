using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MunicipalityApp
{
    public partial class ReportIssuesForm : Form
    {
        // Data structure to store issues
        public static List<Issue> reportedIssues = new List<Issue>();

        string attachedFile = "";

        public ReportIssuesForm()
        {
            InitializeComponent();
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image or Document|*.jpg;*.jpeg;*.png;*.pdf;*.docx";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                attachedFile = fileDialog.FileName;
                lblAttachmentStatus.Text = "File Attached: " + Path.GetFileName(attachedFile);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtLocation.Text == "" || cmbCategory.SelectedIndex == -1 || rtbDescription.Text == "")
            {
                MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Issue newIssue = new Issue
            {
                Location = txtLocation.Text,
                Category = cmbCategory.SelectedItem.ToString(),
                Description = rtbDescription.Text,
                Attachment = attachedFile
            };

            reportedIssues.Add(newIssue);

            progressBar1.Value = 100;
            lblStatus.Text = "Report Submitted Successfully!";
            MessageBox.Show("Thank you for reporting the issue!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Reset fields
            txtLocation.Clear();
            cmbCategory.SelectedIndex = -1;
            rtbDescription.Clear();
            attachedFile = "";
            lblAttachmentStatus.Text = "No file attached";
            progressBar1.Value = 0;
            lblStatus.Text = "Ready to Submit";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainMenuForm mainMenu = new MainMenuForm();
            mainMenu.Show();
            this.Close();
        }
    }

    // Data Structure for Issues
    public class Issue
    {
        public string Location { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string Attachment { get; set; }
    }
}
