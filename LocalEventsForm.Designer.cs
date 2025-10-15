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
            btnAddEvent = new Button();
            btnBack = new Button();
            dgvEvents = new DataGridView();
            lblRecommendations = new Label();
            lstRecommendations = new ListBox();
            ((System.ComponentModel.ISupportInitialize)dgvEvents).BeginInit();
            SuspendLayout();
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Dock = DockStyle.Top;
            lblHeading.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblHeading.Location = new Point(0, 0);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(361, 41);
            lblHeading.TabIndex = 0;
            lblHeading.Text = "Local Community Events";
            // 
            // lblCategory
            // 
            lblCategory.Anchor = AnchorStyles.None;
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(23, 93);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(72, 20);
            lblCategory.TabIndex = 1;
            lblCategory.Text = "Category:";
            // 
            // cboCategory
            // 
            cboCategory.Anchor = AnchorStyles.None;
            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategory.Location = new Point(91, 89);
            cboCategory.Margin = new Padding(3, 4, 3, 4);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(171, 28);
            cboCategory.TabIndex = 2;
            // 
            // lblKeywords
            // 
            lblKeywords.Anchor = AnchorStyles.None;
            lblKeywords.AutoSize = true;
            lblKeywords.Location = new Point(286, 93);
            lblKeywords.Name = "lblKeywords";
            lblKeywords.Size = new Size(76, 20);
            lblKeywords.TabIndex = 3;
            lblKeywords.Text = "Keywords:";
            // 
            // txtKeywords
            // 
            txtKeywords.Anchor = AnchorStyles.None;
            txtKeywords.Location = new Point(366, 89);
            txtKeywords.Margin = new Padding(3, 4, 3, 4);
            txtKeywords.Name = "txtKeywords";
            txtKeywords.Size = new Size(171, 27);
            txtKeywords.TabIndex = 4;
            // 
            // lblStartDate
            // 
            lblStartDate.Anchor = AnchorStyles.None;
            lblStartDate.AutoSize = true;
            lblStartDate.Location = new Point(16, 138);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(79, 20);
            lblStartDate.TabIndex = 5;
            lblStartDate.Text = "Start Date:";
            // 
            // dtpStartDate
            // 
            dtpStartDate.Anchor = AnchorStyles.None;
            dtpStartDate.Format = DateTimePickerFormat.Short;
            dtpStartDate.Location = new Point(91, 133);
            dtpStartDate.Margin = new Padding(3, 4, 3, 4);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.ShowCheckBox = true;
            dtpStartDate.Size = new Size(171, 27);
            dtpStartDate.TabIndex = 6;
            // 
            // lblEndDate
            // 
            lblEndDate.Anchor = AnchorStyles.None;
            lblEndDate.AutoSize = true;
            lblEndDate.Location = new Point(286, 140);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(73, 20);
            lblEndDate.TabIndex = 7;
            lblEndDate.Text = "End Date:";
            // 
            // dtpEndDate
            // 
            dtpEndDate.Anchor = AnchorStyles.None;
            dtpEndDate.Format = DateTimePickerFormat.Short;
            dtpEndDate.Location = new Point(366, 133);
            dtpEndDate.Margin = new Padding(3, 4, 3, 4);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.ShowCheckBox = true;
            dtpEndDate.Size = new Size(171, 27);
            dtpEndDate.TabIndex = 8;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.None;
            btnSearch.AutoSize = true;
            btnSearch.Location = new Point(571, 89);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(114, 33);
            btnSearch.TabIndex = 9;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnRecommendations
            // 
            btnRecommendations.Anchor = AnchorStyles.None;
            btnRecommendations.AutoSize = true;
            btnRecommendations.Location = new Point(571, 133);
            btnRecommendations.Margin = new Padding(3, 4, 3, 4);
            btnRecommendations.Name = "btnRecommendations";
            btnRecommendations.Size = new Size(143, 33);
            btnRecommendations.TabIndex = 10;
            btnRecommendations.Text = "Recommendations";
            btnRecommendations.UseVisualStyleBackColor = true;
            // 
            // btnAddEvent
            // 
            btnAddEvent.Anchor = AnchorStyles.None;
            btnAddEvent.AutoSize = true;
            btnAddEvent.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAddEvent.Location = new Point(743, 89);
            btnAddEvent.Margin = new Padding(3, 4, 3, 4);
            btnAddEvent.Name = "btnAddEvent";
            btnAddEvent.Size = new Size(87, 30);
            btnAddEvent.TabIndex = 11;
            btnAddEvent.Text = "Add Event";
            btnAddEvent.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.None;
            btnBack.AutoSize = true;
            btnBack.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnBack.Location = new Point(743, 133);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(50, 30);
            btnBack.TabIndex = 12;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // dgvEvents
            // 
            dgvEvents.AllowUserToAddRows = false;
            dgvEvents.AllowUserToDeleteRows = false;
            dgvEvents.Anchor = AnchorStyles.None;
            dgvEvents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEvents.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvEvents.BackgroundColor = Color.White;
            dgvEvents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEvents.Location = new Point(23, 187);
            dgvEvents.Margin = new Padding(3, 4, 3, 4);
            dgvEvents.MultiSelect = false;
            dgvEvents.Name = "dgvEvents";
            dgvEvents.ReadOnly = true;
            dgvEvents.RowHeadersWidth = 51;
            dgvEvents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEvents.Size = new Size(834, 301);
            dgvEvents.TabIndex = 13;
            // 
            // lblRecommendations
            // 
            lblRecommendations.Anchor = AnchorStyles.Top;
            lblRecommendations.AutoSize = true;
            lblRecommendations.Location = new Point(905, 27);
            lblRecommendations.Name = "lblRecommendations";
            lblRecommendations.Size = new Size(136, 20);
            lblRecommendations.TabIndex = 14;
            lblRecommendations.Text = "Recommendations:";
            lblRecommendations.Click += lblRecommendations_Click;
            // 
            // lstRecommendations
            // 
            lstRecommendations.Anchor = AnchorStyles.None;
            lstRecommendations.FormattingEnabled = true;
            lstRecommendations.HorizontalScrollbar = true;
            lstRecommendations.Location = new Point(882, 53);
            lstRecommendations.Margin = new Padding(3, 4, 3, 4);
            lstRecommendations.Name = "lstRecommendations";
            lstRecommendations.Size = new Size(257, 784);
            lstRecommendations.TabIndex = 15;
            lstRecommendations.SelectedIndexChanged += lstRecommendations_SelectedIndexChanged_1;
            // 
            // LocalEventsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(1141, 880);
            Controls.Add(lstRecommendations);
            Controls.Add(lblRecommendations);
            Controls.Add(dgvEvents);
            Controls.Add(btnBack);
            Controls.Add(btnAddEvent);
            Controls.Add(btnRecommendations);
            Controls.Add(btnSearch);
            Controls.Add(dtpEndDate);
            Controls.Add(lblEndDate);
            Controls.Add(dtpStartDate);
            Controls.Add(lblStartDate);
            Controls.Add(txtKeywords);
            Controls.Add(lblKeywords);
            Controls.Add(cboCategory);
            Controls.Add(lblCategory);
            Controls.Add(lblHeading);
            Margin = new Padding(3, 4, 3, 4);
            Name = "LocalEventsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Local Events";
            Load += LocalEventsForm_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvEvents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
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
        private System.Windows.Forms.Button btnAddEvent; // New button added
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvEvents;
        private System.Windows.Forms.Label lblRecommendations;
        private System.Windows.Forms.ListBox lstRecommendations;
    }
}
