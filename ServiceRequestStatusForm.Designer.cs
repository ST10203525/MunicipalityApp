namespace MunicipalityApp
{
    partial class ServiceRequestStatusForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvRequests = new System.Windows.Forms.DataGridView();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnViewPriority = new System.Windows.Forms.Button();
            this.btnGraph = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvRequests)).BeginInit();
            this.SuspendLayout();

            // 
            // dgvRequests
            // 
            this.dgvRequests.AllowUserToAddRows = false;
            this.dgvRequests.AllowUserToDeleteRows = false;
            this.dgvRequests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRequests.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequests.Location = new System.Drawing.Point(50, 100);
            this.dgvRequests.Name = "dgvRequests";
            this.dgvRequests.ReadOnly = true;
            this.dgvRequests.Size = new System.Drawing.Size(850, 300);
            this.dgvRequests.TabIndex = 0;

            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(50, 420);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(120, 30);
            this.btnLoad.Text = "Load Requests";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);

            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(300, 420);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(120, 30);
            this.btnSearch.Text = "Search by ID";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(180, 424);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 23);

            // 
            // btnViewPriority
            // 
            this.btnViewPriority.Location = new System.Drawing.Point(450, 420);
            this.btnViewPriority.Name = "btnViewPriority";
            this.btnViewPriority.Size = new System.Drawing.Size(150, 30);
            this.btnViewPriority.Text = "View Priority Queue";
            this.btnViewPriority.Click += new System.EventHandler(this.btnViewPriority_Click);

            // 
            // btnGraph
            // 
            this.btnGraph.Location = new System.Drawing.Point(620, 420);
            this.btnGraph.Name = "btnGraph";
            this.btnGraph.Size = new System.Drawing.Size(150, 30);
            this.btnGraph.Text = "Graph Traversal";
            this.btnGraph.Click += new System.EventHandler(this.btnGraph_Click);

            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(790, 420);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(110, 30);
            this.btnBack.Text = "Back to Menu";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);

            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(340, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(300, 25);
            this.lblTitle.Text = "Service Request Status Tracker";

            // 
            // ServiceRequestStatusForm
            // 
            this.ClientSize = new System.Drawing.Size(960, 480);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvRequests);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnViewPriority);
            this.Controls.Add(this.btnGraph);
            this.Controls.Add(this.btnBack);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Service Request Status";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DataGridView dgvRequests;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnViewPriority;
        private System.Windows.Forms.Button btnGraph;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnBack;
    }
}
