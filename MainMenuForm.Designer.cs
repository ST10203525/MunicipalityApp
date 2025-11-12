using System;
using System.Drawing;
using System.Windows.Forms;

namespace MunicipalityApp
{
    partial class MainMenuForm
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
            lblTitle = new Label();
            pnlHeader = new Panel();
            pnlMain = new Panel();
            btnReportIssues = new Button();
            btnLocalEvents = new Button();
            btnServiceStatus = new Button();
            btnViewReports = new Button();

            pnlHeader.SuspendLayout();
            pnlMain.SuspendLayout();
            SuspendLayout();

            // ===== Header Panel =====
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.BackColor = Color.SteelBlue;
            pnlHeader.Height = 80;
            pnlHeader.Controls.Add(lblTitle);

            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.White;
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.Text = "🏛️ Municipality Services Dashboard";

            // ===== Main Panel =====
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.BackColor = Color.WhiteSmoke;
            pnlMain.Padding = new Padding(40);
            pnlMain.Controls.AddRange(new Control[]
            {
                btnReportIssues, btnLocalEvents, btnServiceStatus, btnViewReports
            });

            // ===== Buttons (shared style) =====
            Font buttonFont = new Font("Segoe UI", 12F, FontStyle.Bold);
            Size buttonSize = new Size(280, 80);

            // Report Issues
            btnReportIssues.Text = "🛠️ Report Community Issues";
            btnReportIssues.Font = buttonFont;
            btnReportIssues.Size = buttonSize;
            btnReportIssues.BackColor = Color.FromArgb(0, 123, 255);
            btnReportIssues.ForeColor = Color.White;
            btnReportIssues.FlatStyle = FlatStyle.Flat;
            btnReportIssues.FlatAppearance.BorderSize = 0;
            btnReportIssues.Location = new Point(350, 100);
            btnReportIssues.Cursor = Cursors.Hand;
            btnReportIssues.Click += btnReportIssues_Click;
            btnReportIssues.MouseEnter += (s, e) => btnReportIssues.BackColor = Color.FromArgb(0, 90, 190);
            btnReportIssues.MouseLeave += (s, e) => btnReportIssues.BackColor = Color.FromArgb(0, 123, 255);

            // Local Events
            btnLocalEvents.Text = "🎉 Local Events & Announcements";
            btnLocalEvents.Font = buttonFont;
            btnLocalEvents.Size = buttonSize;
            btnLocalEvents.BackColor = Color.MediumSeaGreen;
            btnLocalEvents.ForeColor = Color.White;
            btnLocalEvents.FlatStyle = FlatStyle.Flat;
            btnLocalEvents.FlatAppearance.BorderSize = 0;
            btnLocalEvents.Location = new Point(350, 220);
            btnLocalEvents.Cursor = Cursors.Hand;
            btnLocalEvents.Click += btnLocalEvents_Click;
            btnLocalEvents.MouseEnter += (s, e) => btnLocalEvents.BackColor = Color.SeaGreen;
            btnLocalEvents.MouseLeave += (s, e) => btnLocalEvents.BackColor = Color.MediumSeaGreen;

            // Service Request Status
            btnServiceStatus.Text = "📋 Service Request Status";
            btnServiceStatus.Font = buttonFont;
            btnServiceStatus.Size = buttonSize;
            btnServiceStatus.BackColor = Color.Orange;
            btnServiceStatus.ForeColor = Color.White;
            btnServiceStatus.FlatStyle = FlatStyle.Flat;
            btnServiceStatus.FlatAppearance.BorderSize = 0;
            btnServiceStatus.Location = new Point(350, 340);
            btnServiceStatus.Cursor = Cursors.Hand;
            btnServiceStatus.Click += btnServiceStatus_Click;
            btnServiceStatus.MouseEnter += (s, e) => btnServiceStatus.BackColor = Color.DarkOrange;
            btnServiceStatus.MouseLeave += (s, e) => btnServiceStatus.BackColor = Color.Orange;

            // View Reports
            btnViewReports.Text = "📊 View Submitted Reports";
            btnViewReports.Font = buttonFont;
            btnViewReports.Size = buttonSize;
            btnViewReports.BackColor = Color.MediumSlateBlue;
            btnViewReports.ForeColor = Color.White;
            btnViewReports.FlatStyle = FlatStyle.Flat;
            btnViewReports.FlatAppearance.BorderSize = 0;
            btnViewReports.Location = new Point(350, 460);
            btnViewReports.Cursor = Cursors.Hand;
            btnViewReports.Click += btnViewReports_Click;
            btnViewReports.MouseEnter += (s, e) => btnViewReports.BackColor = Color.SlateBlue;
            btnViewReports.MouseLeave += (s, e) => btnViewReports.BackColor = Color.MediumSlateBlue;

            // ===== Form Settings =====
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1000, 650);
            Controls.Add(pnlMain);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.Black;
            StartPosition = FormStartPosition.CenterScreen;
            Name = "MainMenuForm";
            Text = "Municipality Services";

            Load += MainMenuForm_Load;

            pnlHeader.ResumeLayout(false);
            pnlMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnReportIssues;
        private System.Windows.Forms.Button btnLocalEvents;
        private System.Windows.Forms.Button btnServiceStatus;
        private System.Windows.Forms.Button btnViewReports;
    }
}
