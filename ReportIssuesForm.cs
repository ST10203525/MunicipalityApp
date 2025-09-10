using System;
using System.Windows.Forms;
using MunicipalityApp.Models;
using MunicipalityApp.Data;

namespace MunicipalityApp
{
    public partial class ReportIssuesForm : Form
    {
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
                lblAttachmentStatus.Text = "File Attached: " + System.IO.Path.GetFileName(attachedFile);
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

            IssueRepository.AddIssue(newIssue); // Save issue

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
}
