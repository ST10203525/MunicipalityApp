namespace MunicipalityApp
{
    partial class MainMenuForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnLocalEvents = new Button();
            btnViewReports = new Button();
            btnServiceStatus = new Button();
            btnReportIssues = new Button();
            tableLayout = new TableLayoutPanel();
            tableLayout.SuspendLayout();
            SuspendLayout();
            // 
            // btnLocalEvents
            // 
            btnLocalEvents.Anchor = AnchorStyles.None;
            btnLocalEvents.AutoSize = true;
            btnLocalEvents.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLocalEvents.ForeColor = Color.BlueViolet;
            btnLocalEvents.Location = new Point(385, 236);
            btnLocalEvents.Name = "btnLocalEvents";
            btnLocalEvents.Size = new Size(214, 30);
            btnLocalEvents.TabIndex = 1;
            btnLocalEvents.Text = "Local Events & Announcements";
            btnLocalEvents.UseVisualStyleBackColor = true;
            btnLocalEvents.Click += btnLocalEvents_Click;
            // 
            // btnViewReports
            // 
            btnViewReports.Anchor = AnchorStyles.None;
            btnViewReports.AutoSize = true;
            btnViewReports.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnViewReports.BackColor = Color.White;
            btnViewReports.Location = new Point(439, 561);
            btnViewReports.Name = "btnViewReports";
            btnViewReports.Size = new Size(106, 30);
            btnViewReports.TabIndex = 3;
            btnViewReports.Text = "View Reports";
            btnViewReports.UseVisualStyleBackColor = false;
            btnViewReports.Click += btnViewReports_Click;
            // 
            // btnServiceStatus
            // 
            btnServiceStatus.Anchor = AnchorStyles.None;
            btnServiceStatus.AutoSize = true;
            btnServiceStatus.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnServiceStatus.Location = new Point(408, 395);
            btnServiceStatus.Name = "btnServiceStatus";
            btnServiceStatus.Size = new Size(167, 30);
            btnServiceStatus.TabIndex = 2;
            btnServiceStatus.Text = "Service Request Status";
            btnServiceStatus.UseVisualStyleBackColor = true;
            // 
            // btnReportIssues
            // 
            btnReportIssues.Anchor = AnchorStyles.None;
            btnReportIssues.AutoSize = true;
            btnReportIssues.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnReportIssues.Location = new Point(439, 72);
            btnReportIssues.Name = "btnReportIssues";
            btnReportIssues.Size = new Size(106, 30);
            btnReportIssues.TabIndex = 0;
            btnReportIssues.Text = "Report Issues";
            btnReportIssues.UseVisualStyleBackColor = true;
            btnReportIssues.Click += btnReportIssues_Click;
            // 
            // tableLayout
            // 
            tableLayout.ColumnCount = 1;
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayout.Controls.Add(btnReportIssues, 0, 0);
            tableLayout.Controls.Add(btnServiceStatus, 0, 2);
            tableLayout.Controls.Add(btnViewReports, 0, 3);
            tableLayout.Controls.Add(btnLocalEvents, 0, 1);
            tableLayout.Dock = DockStyle.Fill;
            tableLayout.Location = new Point(0, 0);
            tableLayout.Name = "tableLayout";
            tableLayout.RowCount = 4;
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 26.4036427F));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 23.36874F));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayout.Size = new Size(984, 659);
            tableLayout.TabIndex = 4;
            // 
            // MainMenuForm
            // 
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(984, 659);
            Controls.Add(tableLayout);
            ForeColor = Color.Blue;
            Name = "MainMenuForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Municipality Services";
            Load += MainMenuForm_Load;
            tableLayout.ResumeLayout(false);
            tableLayout.PerformLayout();
            ResumeLayout(false);


        }
        private Button btnLocalEvents;
        private Button btnViewReports;
        private Button btnServiceStatus;
        private Button btnReportIssues;
        private TableLayoutPanel tableLayout;
    }
}