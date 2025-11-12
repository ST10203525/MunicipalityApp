using System;
using System.Drawing;
using System.Windows.Forms;

namespace MunicipalityApp
{
    partial class ReportIssuesForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            lblHeader = new Label();
            pnlContent = new Panel();

            lblLocation = new Label();
            txtLocation = new TextBox();
            lblCategory = new Label();
            cmbCategory = new ComboBox();
            lblDescription = new Label();
            rtbDescription = new RichTextBox();
            btnAttach = new Button();
            lblAttachmentStatus = new Label();
            progressBar1 = new ProgressBar();
            lblStatus = new Label();
            btnSubmit = new Button();
            btnBack = new Button();

            pnlHeader.SuspendLayout();
            pnlContent.SuspendLayout();
            SuspendLayout();

            // ===== HEADER PANEL =====
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Height = 80;
            pnlHeader.BackColor = Color.SteelBlue;
            pnlHeader.Controls.Add(lblHeader);

            lblHeader.Dock = DockStyle.Fill;
            lblHeader.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeader.ForeColor = Color.White;
            lblHeader.TextAlign = ContentAlignment.MiddleCenter;
            lblHeader.Text = "🛠️ Report a Municipal Issue";

            // ===== CONTENT PANEL =====
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.BackColor = Color.WhiteSmoke;
            pnlContent.Padding = new Padding(40);
            pnlContent.Controls.AddRange(new Control[]
            {
                lblLocation, txtLocation,
                lblCategory, cmbCategory,
                lblDescription, rtbDescription,
                btnAttach, lblAttachmentStatus,
                progressBar1, lblStatus,
                btnSubmit, btnBack
            });

            // ===== LABELS AND INPUTS =====
            Font labelFont = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            Font inputFont = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);

            // Location
            lblLocation.Text = "📍 Location:";
            lblLocation.Font = labelFont;
            lblLocation.AutoSize = true;
            lblLocation.Location = new Point(150, 70);

            txtLocation.Font = inputFont;
            txtLocation.Location = new Point(280, 68);
            txtLocation.Size = new Size(450, 27);
            txtLocation.BorderStyle = BorderStyle.FixedSingle;

            // Category
            lblCategory.Text = "📂 Category:";
            lblCategory.Font = labelFont;
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(150, 120);

            cmbCategory.Font = inputFont;
            cmbCategory.Location = new Point(280, 118);
            cmbCategory.Size = new Size(250, 28);
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.Items.AddRange(new object[] { "Sanitation", "Roads", "Utilities", "Public Safety", "Other" });

            // Description
            lblDescription.Text = "📝 Description:";
            lblDescription.Font = labelFont;
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(150, 170);

            rtbDescription.Font = inputFont;
            rtbDescription.Location = new Point(280, 168);
            rtbDescription.Size = new Size(450, 120);
            rtbDescription.BorderStyle = BorderStyle.FixedSingle;

            // Attachment
            btnAttach.Text = "📎 Attach File";
            btnAttach.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnAttach.BackColor = Color.DodgerBlue;
            btnAttach.ForeColor = Color.White;
            btnAttach.FlatStyle = FlatStyle.Flat;
            btnAttach.FlatAppearance.BorderSize = 0;
            btnAttach.Size = new Size(130, 35);
            btnAttach.Location = new Point(280, 305);
            btnAttach.Cursor = Cursors.Hand;
            btnAttach.Click += btnAttach_Click;
            btnAttach.MouseEnter += (s, e) => btnAttach.BackColor = Color.RoyalBlue;
            btnAttach.MouseLeave += (s, e) => btnAttach.BackColor = Color.DodgerBlue;

            lblAttachmentStatus.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            lblAttachmentStatus.ForeColor = Color.DimGray;
            lblAttachmentStatus.AutoSize = true;
            lblAttachmentStatus.Location = new Point(430, 312);
            lblAttachmentStatus.Text = "No file attached";

            // Progress and status
            lblStatus.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            lblStatus.ForeColor = Color.DimGray;
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(280, 355);
            lblStatus.Text = "Ready to submit your report.";

            progressBar1.Location = new Point(280, 380);
            progressBar1.Size = new Size(450, 15);
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.ForeColor = Color.SteelBlue;

            // ===== BUTTONS =====
            btnSubmit.Text = "✅ Submit Report";
            btnSubmit.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSubmit.BackColor = Color.MediumSeaGreen;
            btnSubmit.ForeColor = Color.White;
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.FlatAppearance.BorderSize = 0;
            btnSubmit.Size = new Size(180, 45);
            btnSubmit.Location = new Point(280, 420);
            btnSubmit.Cursor = Cursors.Hand;
            btnSubmit.Click += btnSubmit_Click;
            btnSubmit.MouseEnter += (s, e) => btnSubmit.BackColor = Color.SeaGreen;
            btnSubmit.MouseLeave += (s, e) => btnSubmit.BackColor = Color.MediumSeaGreen;

            btnBack.Text = "↩️ Back to Menu";
            btnBack.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnBack.BackColor = Color.IndianRed;
            btnBack.ForeColor = Color.White;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.Size = new Size(180, 45);
            btnBack.Location = new Point(470, 420);
            btnBack.Cursor = Cursors.Hand;
            btnBack.Click += btnBack_Click;
            btnBack.MouseEnter += (s, e) => btnBack.BackColor = Color.Firebrick;
            btnBack.MouseLeave += (s, e) => btnBack.BackColor = Color.IndianRed;

            // ===== FORM SETTINGS =====
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(900, 550);
            Controls.Add(pnlContent);
            Controls.Add(pnlHeader);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Report an Issue";

            pnlHeader.ResumeLayout(false);
            pnlContent.ResumeLayout(false);
            pnlContent.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblHeader;
        private Panel pnlContent;
        private Label lblLocation;
        private TextBox txtLocation;
        private Label lblCategory;
        private ComboBox cmbCategory;
        private Label lblDescription;
        private RichTextBox rtbDescription;
        private Button btnAttach;
        private Label lblAttachmentStatus;
        private ProgressBar progressBar1;
        private Label lblStatus;
        private Button btnSubmit;
        private Button btnBack;
    }
}
