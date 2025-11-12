using System;
using System.Drawing;
using System.Windows.Forms;

namespace MunicipalityApp
{
    partial class ServiceRequestStatusForm
    {
        private System.ComponentModel.IContainer components = null;
        private Panel pnlHeader;
        private Label lblHeader;
        private Panel pnlContent;
        private DataGridView dgvRequests;
        private TextBox txtSearch;
        private Button btnLoad;
        private Button btnSearch;
        private Button btnViewPriority;
        private Button btnGraph;
        private Button btnBack;
        private Label lblSearch;

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

            dgvRequests = new DataGridView();
            txtSearch = new TextBox();
            btnLoad = new Button();
            btnSearch = new Button();
            btnViewPriority = new Button();
            btnGraph = new Button();
            btnBack = new Button();
            lblSearch = new Label();

            pnlHeader.SuspendLayout();
            pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRequests).BeginInit();
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
            lblHeader.Text = "📊 Service Request Status Tracker";

            // ===== CONTENT PANEL =====
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.BackColor = Color.WhiteSmoke;
            pnlContent.Padding = new Padding(40);

            // ===== DATA GRID VIEW =====
            dgvRequests.Location = new Point(50, 100);
            dgvRequests.Size = new Size(840, 300);
            dgvRequests.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvRequests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRequests.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvRequests.BackgroundColor = Color.White;
            dgvRequests.GridColor = Color.LightGray;
            dgvRequests.BorderStyle = BorderStyle.FixedSingle;
            dgvRequests.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle()
            {
                Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold),
                BackColor = Color.AliceBlue,
                ForeColor = Color.Black
            };
            dgvRequests.DefaultCellStyle = new DataGridViewCellStyle()
            {
                Font = new Font("Segoe UI", 10F),
                SelectionBackColor = Color.LightSteelBlue,
                SelectionForeColor = Color.Black
            };
            dgvRequests.EnableHeadersVisualStyles = false;

            // ===== SEARCH LABEL =====
            lblSearch.Text = "🔎 Search by ID:";
            lblSearch.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(50, 420);

            // ===== SEARCH BOX =====
            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Location = new Point(170, 418);
            txtSearch.Size = new Size(150, 27);

            // ===== BUTTON STYLE BASE =====
            Font btnFont = new Font("Segoe UI", 10.5F, FontStyle.Bold);

            // Load Button
            btnLoad.Text = "📂 Load Requests";
            btnLoad.Font = btnFont;
            btnLoad.BackColor = Color.DodgerBlue;
            btnLoad.ForeColor = Color.White;
            btnLoad.FlatStyle = FlatStyle.Flat;
            btnLoad.FlatAppearance.BorderSize = 0;
            btnLoad.Size = new Size(160, 40);
            btnLoad.Location = new Point(340, 415);
            btnLoad.Cursor = Cursors.Hand;
            btnLoad.Click += btnLoad_Click;
            btnLoad.MouseEnter += (s, e) => btnLoad.BackColor = Color.RoyalBlue;
            btnLoad.MouseLeave += (s, e) => btnLoad.BackColor = Color.DodgerBlue;

            // Search Button
            btnSearch.Text = "🔍 Search";
            btnSearch.Font = btnFont;
            btnSearch.BackColor = Color.MediumSeaGreen;
            btnSearch.ForeColor = Color.White;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.Size = new Size(120, 40);
            btnSearch.Location = new Point(520, 415);
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.Click += btnSearch_Click;
            btnSearch.MouseEnter += (s, e) => btnSearch.BackColor = Color.SeaGreen;
            btnSearch.MouseLeave += (s, e) => btnSearch.BackColor = Color.MediumSeaGreen;

            // Priority Button
            btnViewPriority.Text = "⚡ View Priority Queue";
            btnViewPriority.Font = btnFont;
            btnViewPriority.BackColor = Color.MediumSlateBlue;
            btnViewPriority.ForeColor = Color.White;
            btnViewPriority.FlatStyle = FlatStyle.Flat;
            btnViewPriority.FlatAppearance.BorderSize = 0;
            btnViewPriority.Size = new Size(200, 40);
            btnViewPriority.Location = new Point(660, 415);
            btnViewPriority.Cursor = Cursors.Hand;
            btnViewPriority.Click += btnViewPriority_Click;
            btnViewPriority.MouseEnter += (s, e) => btnViewPriority.BackColor = Color.SlateBlue;
            btnViewPriority.MouseLeave += (s, e) => btnViewPriority.BackColor = Color.MediumSlateBlue;

            // Graph Button
            btnGraph.Text = "📈 Graph Traversal";
            btnGraph.Font = btnFont;
            btnGraph.BackColor = Color.Teal;
            btnGraph.ForeColor = Color.White;
            btnGraph.FlatStyle = FlatStyle.Flat;
            btnGraph.FlatAppearance.BorderSize = 0;
            btnGraph.Size = new Size(200, 40);
            btnGraph.Location = new Point(340, 470);
            btnGraph.Cursor = Cursors.Hand;
            btnGraph.Click += btnGraph_Click;
            btnGraph.MouseEnter += (s, e) => btnGraph.BackColor = Color.DarkCyan;
            btnGraph.MouseLeave += (s, e) => btnGraph.BackColor = Color.Teal;

            // Back Button
            btnBack.Text = "↩️ Back to Menu";
            btnBack.Font = btnFont;
            btnBack.BackColor = Color.IndianRed;
            btnBack.ForeColor = Color.White;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.Size = new Size(200, 40);
            btnBack.Location = new Point(560, 470);
            btnBack.Cursor = Cursors.Hand;
            btnBack.Click += btnBack_Click;
            btnBack.MouseEnter += (s, e) => btnBack.BackColor = Color.Firebrick;
            btnBack.MouseLeave += (s, e) => btnBack.BackColor = Color.IndianRed;

            // ===== ADD CONTROLS =====
            pnlContent.Controls.Add(dgvRequests);
            pnlContent.Controls.Add(lblSearch);
            pnlContent.Controls.Add(txtSearch);
            pnlContent.Controls.Add(btnLoad);
            pnlContent.Controls.Add(btnSearch);
            pnlContent.Controls.Add(btnViewPriority);
            pnlContent.Controls.Add(btnGraph);
            pnlContent.Controls.Add(btnBack);

            // ===== FORM SETTINGS =====
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(960, 560);
            Controls.Add(pnlContent);
            Controls.Add(pnlHeader);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Service Request Status";

            pnlHeader.ResumeLayout(false);
            pnlContent.ResumeLayout(false);
            pnlContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRequests).EndInit();
            ResumeLayout(false);
        }
    }
}
