namespace MunicipalityApp
{
    partial class LocalEventsForm
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
            lblHeading = new Label();
            pnlSearch = new Panel();
            lblCategory = new Label();
            cboCategory = new ComboBox();
            lblKeywords = new Label();
            txtKeywords = new TextBox();
            lblStartDate = new Label();
            dtpStartDate = new DateTimePicker();
            lblEndDate = new Label();
            dtpEndDate = new DateTimePicker();
            btnSearch = new Button();
            btnRecommendations = new Button();
            dgvEvents = new DataGridView();
            grpRecommendations = new GroupBox();
            lstRecommendations = new ListBox();
            btnAddEvent = new Button();
            btnBack = new Button();

            ((System.ComponentModel.ISupportInitialize)dgvEvents).BeginInit();
            pnlSearch.SuspendLayout();
            grpRecommendations.SuspendLayout();
            SuspendLayout();

            // ======= Header =======
            lblHeading.Dock = DockStyle.Top;
            lblHeading.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeading.ForeColor = Color.White;
            lblHeading.BackColor = Color.SteelBlue;
            lblHeading.Height = 70;
            lblHeading.TextAlign = ContentAlignment.MiddleCenter;
            lblHeading.Text = "🌆 Local Community Events";

            // ======= Search Panel =======
            pnlSearch.BackColor = Color.AliceBlue;
            pnlSearch.BorderStyle = BorderStyle.FixedSingle;
            pnlSearch.Location = new Point(20, 90);
            pnlSearch.Size = new Size(820, 110);
            pnlSearch.Controls.AddRange(new Control[]
            {
                lblCategory, cboCategory, lblKeywords, txtKeywords,
                lblStartDate, dtpStartDate, lblEndDate, dtpEndDate,
                btnSearch, btnRecommendations
            });

            // Category
            lblCategory.Location = new Point(15, 20);
            lblCategory.Text = "Category:";
            lblCategory.AutoSize = true;
            cboCategory.Location = new Point(95, 17);
            cboCategory.Size = new Size(150, 28);
            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;

            // Keywords
            lblKeywords.Location = new Point(270, 20);
            lblKeywords.Text = "Keywords:";
            lblKeywords.AutoSize = true;
            txtKeywords.Location = new Point(350, 17);
            txtKeywords.Size = new Size(160, 27);

            // Start date
            lblStartDate.Location = new Point(15, 65);
            lblStartDate.Text = "Start Date:";
            lblStartDate.AutoSize = true;
            dtpStartDate.Format = DateTimePickerFormat.Short;
            dtpStartDate.ShowCheckBox = true;
            dtpStartDate.Location = new Point(95, 62);
            dtpStartDate.Size = new Size(150, 27);

            // End date
            lblEndDate.Location = new Point(270, 65);
            lblEndDate.Text = "End Date:";
            lblEndDate.AutoSize = true;
            dtpEndDate.Format = DateTimePickerFormat.Short;
            dtpEndDate.ShowCheckBox = true;
            dtpEndDate.Location = new Point(350, 62);
            dtpEndDate.Size = new Size(160, 27);

            // Search button
            btnSearch.Text = "🔍 Search";
            btnSearch.BackColor = Color.SteelBlue;
            btnSearch.ForeColor = Color.White;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.Location = new Point(540, 25);
            btnSearch.Size = new Size(100, 30);

            // Recommendations button
            btnRecommendations.Text = "💡 Recommendations";
            btnRecommendations.BackColor = Color.MediumSeaGreen;
            btnRecommendations.ForeColor = Color.White;
            btnRecommendations.FlatStyle = FlatStyle.Flat;
            btnRecommendations.FlatAppearance.BorderSize = 0;
            btnRecommendations.Location = new Point(540, 65);
            btnRecommendations.Size = new Size(160, 30);

            // ======= Data Grid =======
            dgvEvents.Location = new Point(20, 220);
            dgvEvents.Size = new Size(820, 400);
            dgvEvents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEvents.BackgroundColor = Color.White;
            dgvEvents.BorderStyle = BorderStyle.Fixed3D;
            dgvEvents.ReadOnly = true;
            dgvEvents.RowHeadersVisible = false;
            dgvEvents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEvents.MultiSelect = false;
            dgvEvents.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
            dgvEvents.DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue;

            // ======= Recommendations Panel =======
            grpRecommendations.Text = "⭐ Recommended Events";
            grpRecommendations.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpRecommendations.Location = new Point(860, 90);
            grpRecommendations.Size = new Size(260, 530);
            grpRecommendations.BackColor = Color.White;
            grpRecommendations.Controls.Add(lstRecommendations);

            lstRecommendations.Dock = DockStyle.Fill;
            lstRecommendations.BorderStyle = BorderStyle.None;
            lstRecommendations.Font = new Font("Segoe UI", 10F);
            lstRecommendations.BackColor = Color.WhiteSmoke;
            lstRecommendations.HorizontalScrollbar = true;

            // ======= Add and Back Buttons =======
            btnAddEvent.Text = "➕ Add Event";
            btnAddEvent.BackColor = Color.DodgerBlue;
            btnAddEvent.ForeColor = Color.White;
            btnAddEvent.FlatStyle = FlatStyle.Flat;
            btnAddEvent.FlatAppearance.BorderSize = 0;
            btnAddEvent.Location = new Point(860, 640);
            btnAddEvent.Size = new Size(120, 35);

            btnBack.Text = "⬅️ Back";
            btnBack.BackColor = Color.Gray;
            btnBack.ForeColor = Color.White;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.Location = new Point(1000, 640);
            btnBack.Size = new Size(120, 35);

            // ======= Form Settings =======
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1140, 700);
            Controls.AddRange(new Control[]
            {
                lblHeading, pnlSearch, dgvEvents,
                grpRecommendations, btnAddEvent, btnBack
            });
            Font = new Font("Segoe UI", 10F);
            Name = "LocalEventsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Local Events";

            ((System.ComponentModel.ISupportInitialize)dgvEvents).EndInit();
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            grpRecommendations.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label lblKeywords;
        private System.Windows.Forms.TextBox txtKeywords;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRecommendations;
        private System.Windows.Forms.DataGridView dgvEvents;
        private System.Windows.Forms.GroupBox grpRecommendations;
        private System.Windows.Forms.ListBox lstRecommendations;
        private System.Windows.Forms.Button btnAddEvent;
        private System.Windows.Forms.Button btnBack;
    }
}
