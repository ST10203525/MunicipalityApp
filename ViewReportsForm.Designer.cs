using System;
using System.Drawing;
using System.Windows.Forms;

namespace MunicipalityApp
{
    partial class ViewReportsForm
    {
        private System.ComponentModel.IContainer components = null;
        private Panel pnlHeader;
        private Label lblHeader;
        private Panel pnlContent;
        private DataGridView dgvReports;
        private Button btnBack;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            lblHeader = new Label();
            pnlContent = new Panel();
            dgvReports = new DataGridView();
            btnBack = new Button();

            pnlHeader.SuspendLayout();
            pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReports).BeginInit();
            SuspendLayout();

            // ===== HEADER =====
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Height = 90;
            pnlHeader.BackColor = Color.SteelBlue;
            pnlHeader.Controls.Add(lblHeader);

            lblHeader.Dock = DockStyle.Fill;
            lblHeader.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblHeader.ForeColor = Color.White;
            lblHeader.TextAlign = ContentAlignment.MiddleCenter;
            lblHeader.Text = "📄 View Reported Issues";

            // ===== CONTENT PANEL =====
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.BackColor = Color.WhiteSmoke;
            pnlContent.Padding = new Padding(40);

            // ===== DATA GRID VIEW =====
            dgvReports.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvReports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReports.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvReports.BackgroundColor = Color.White;
            dgvReports.GridColor = Color.LightGray;
            dgvReports.BorderStyle = BorderStyle.FixedSingle;
            dgvReports.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle()
            {
                Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold),
                BackColor = Color.AliceBlue,
                ForeColor = Color.Black
            };
            dgvReports.DefaultCellStyle = new DataGridViewCellStyle()
            {
                Font = new Font("Segoe UI", 10F),
                SelectionBackColor = Color.LightSteelBlue,
                SelectionForeColor = Color.Black
            };
            dgvReports.EnableHeadersVisualStyles = false;

            // Initial size and position
            dgvReports.Location = new Point(0, 0);
            dgvReports.Width = pnlContent.ClientSize.Width;
            dgvReports.Height = pnlContent.ClientSize.Height - 80; // leave space for Back button

            // ===== BACK BUTTON =====
            btnBack.Text = "↩️ Back to Menu";
            btnBack.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnBack.BackColor = Color.IndianRed;
            btnBack.ForeColor = Color.White;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.Size = new Size(180, 45);
            btnBack.Cursor = Cursors.Hand;

            // Initial position
            btnBack.Location = new Point(pnlContent.ClientSize.Width - btnBack.Width - 20,
                                         pnlContent.ClientSize.Height - btnBack.Height - 10);

            // Event handlers
            btnBack.Click += btnBack_Click;
            btnBack.MouseEnter += (s, e) => btnBack.BackColor = Color.Firebrick;
            btnBack.MouseLeave += (s, e) => btnBack.BackColor = Color.IndianRed;

            // ===== HANDLE RESIZING =====
            this.Resize += (s, e) =>
            {
                // Resize DataGridView
                dgvReports.Width = pnlContent.ClientSize.Width;
                dgvReports.Height = pnlContent.ClientSize.Height - btnBack.Height - 20;

                // Reposition Back Button
                btnBack.Location = new Point(pnlContent.ClientSize.Width - btnBack.Width - 20,
                                             pnlContent.ClientSize.Height - btnBack.Height - 10);
            };

            // ===== ADD CONTROLS =====
            pnlContent.Controls.Add(dgvReports);
            pnlContent.Controls.Add(btnBack);

            // ===== FORM SETTINGS =====
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(960, 560);
            Controls.Add(pnlContent);
            Controls.Add(pnlHeader);
            Name = "ViewReportsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "View Reported Issues";
            Load += ViewReportsForm_Load;

            pnlHeader.ResumeLayout(false);
            pnlContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReports).EndInit();
            ResumeLayout(false);
        }
    }
}
