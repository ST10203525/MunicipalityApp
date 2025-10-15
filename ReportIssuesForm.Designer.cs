namespace MunicipalityApp
{
    partial class ReportIssuesForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Button btnAttach;
        private System.Windows.Forms.Label lblAttachmentStatus;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblStatus;

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
            lblLocation = new Label();
            txtLocation = new TextBox();
            lblCategory = new Label();
            cmbCategory = new ComboBox();
            lblDescription = new Label();
            rtbDescription = new RichTextBox();
            btnAttach = new Button();
            lblAttachmentStatus = new Label();
            btnSubmit = new Button();
            btnBack = new Button();
            progressBar1 = new ProgressBar();
            lblStatus = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // lblLocation
            // 
            lblLocation.Anchor = AnchorStyles.None;
            lblLocation.AutoSize = true;
            lblLocation.Location = new Point(163, 101);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(69, 20);
            lblLocation.TabIndex = 0;
            lblLocation.Text = "Location:";
            // 
            // txtLocation
            // 
            txtLocation.Anchor = AnchorStyles.None;
            txtLocation.Location = new Point(253, 98);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(414, 27);
            txtLocation.TabIndex = 1;
            // 
            // lblCategory
            // 
            lblCategory.Anchor = AnchorStyles.None;
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(163, 141);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(72, 20);
            lblCategory.TabIndex = 2;
            lblCategory.Text = "Category:";
            // 
            // cmbCategory
            // 
            cmbCategory.Anchor = AnchorStyles.None;
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "Sanitation", "Roads", "Utilities" });
            cmbCategory.Location = new Point(246, 133);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(429, 28);
            cmbCategory.TabIndex = 3;
            // 
            // lblDescription
            // 
            lblDescription.Anchor = AnchorStyles.None;
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(163, 181);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(88, 20);
            lblDescription.TabIndex = 4;
            lblDescription.Text = "Description:";
            // 
            // rtbDescription
            // 
            rtbDescription.Anchor = AnchorStyles.None;
            rtbDescription.Location = new Point(249, 177);
            rtbDescription.Name = "rtbDescription";
            rtbDescription.Size = new Size(423, 93);
            rtbDescription.TabIndex = 5;
            rtbDescription.Text = "";
            // 
            // btnAttach
            // 
            btnAttach.Anchor = AnchorStyles.None;
            btnAttach.AutoSize = true;
            btnAttach.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAttach.Location = new Point(255, 291);
            btnAttach.Name = "btnAttach";
            btnAttach.Size = new Size(89, 30);
            btnAttach.TabIndex = 6;
            btnAttach.Text = "Attach File";
            btnAttach.UseVisualStyleBackColor = true;
            btnAttach.Click += btnAttach_Click;
            // 
            // lblAttachmentStatus
            // 
            lblAttachmentStatus.Anchor = AnchorStyles.None;
            lblAttachmentStatus.AutoSize = true;
            lblAttachmentStatus.Location = new Point(381, 292);
            lblAttachmentStatus.Name = "lblAttachmentStatus";
            lblAttachmentStatus.Size = new Size(116, 20);
            lblAttachmentStatus.TabIndex = 7;
            lblAttachmentStatus.Text = "No file attached";
            // 
            // btnSubmit
            // 
            btnSubmit.Anchor = AnchorStyles.None;
            btnSubmit.AutoSize = true;
            btnSubmit.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSubmit.Location = new Point(255, 488);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(66, 30);
            btnSubmit.TabIndex = 8;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.None;
            btnBack.AutoSize = true;
            btnBack.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnBack.Location = new Point(558, 488);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(109, 30);
            btnBack.TabIndex = 9;
            btnBack.Text = "Back to Menu";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // progressBar1
            // 
            progressBar1.Anchor = AnchorStyles.None;
            progressBar1.Location = new Point(253, 458);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(414, 15);
            progressBar1.TabIndex = 10;
            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.None;
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(255, 419);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(119, 20);
            lblStatus.TabIndex = 11;
            lblStatus.Text = "Ready to Submit";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.None;
            flowLayoutPanel1.BackColor = Color.PowderBlue;
            flowLayoutPanel1.Location = new Point(133, 73);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(614, 457);
            flowLayoutPanel1.TabIndex = 12;
            // 
            // ReportIssuesForm
            // 
            BackColor = Color.SkyBlue;
            ClientSize = new Size(830, 605);
            Controls.Add(lblStatus);
            Controls.Add(progressBar1);
            Controls.Add(btnBack);
            Controls.Add(btnSubmit);
            Controls.Add(lblAttachmentStatus);
            Controls.Add(btnAttach);
            Controls.Add(rtbDescription);
            Controls.Add(lblDescription);
            Controls.Add(cmbCategory);
            Controls.Add(lblCategory);
            Controls.Add(txtLocation);
            Controls.Add(lblLocation);
            Controls.Add(flowLayoutPanel1);
            Name = "ReportIssuesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Report an Issue";
            ResumeLayout(false);
            PerformLayout();


        }
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
