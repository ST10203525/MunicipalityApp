namespace MunicipalityApp
{
    partial class AddEventForm
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
            txtTitle = new TextBox();
            lblCategory = new Label();
            cboCategory = new ComboBox();
            lblDate = new Label();
            dtpDate = new DateTimePicker();
            lblDescription = new Label();
            txtDescription = new TextBox();
            btnAdd = new Button();
            btnCancel = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(376, 219);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(41, 20);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Title:";
            // 
            // txtTitle
            // 
            txtTitle.Anchor = AnchorStyles.None;
            txtTitle.Location = new Point(456, 216);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(250, 27);
            txtTitle.TabIndex = 1;
            // 
            // lblCategory
            // 
            lblCategory.Anchor = AnchorStyles.None;
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(376, 259);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(72, 20);
            lblCategory.TabIndex = 2;
            lblCategory.Text = "Category:";
            // 
            // cboCategory
            // 
            cboCategory.Anchor = AnchorStyles.None;
            cboCategory.Location = new Point(456, 256);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(250, 28);
            cboCategory.TabIndex = 3;
            // 
            // lblDate
            // 
            lblDate.Anchor = AnchorStyles.None;
            lblDate.AutoSize = true;
            lblDate.Location = new Point(376, 299);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(44, 20);
            lblDate.TabIndex = 4;
            lblDate.Text = "Date:";
            // 
            // dtpDate
            // 
            dtpDate.Anchor = AnchorStyles.None;
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpDate.Location = new Point(460, 292);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(150, 27);
            dtpDate.TabIndex = 5;
            // 
            // lblDescription
            // 
            lblDescription.Anchor = AnchorStyles.None;
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(376, 339);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(88, 20);
            lblDescription.TabIndex = 6;
            lblDescription.Text = "Description:";
            // 
            // txtDescription
            // 
            txtDescription.Anchor = AnchorStyles.None;
            txtDescription.Location = new Point(456, 339);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(250, 80);
            txtDescription.TabIndex = 7;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.None;
            btnAdd.Location = new Point(456, 429);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(78, 33);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.None;
            btnCancel.Location = new Point(556, 429);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(84, 33);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.Click += btnCancel_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.None;
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.BackColor = Color.Turquoise;
            flowLayoutPanel1.Location = new Point(362, 167);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(359, 351);
            flowLayoutPanel1.TabIndex = 10;
            // 
            // AddEventForm
            // 
            ClientSize = new Size(1112, 679);
            Controls.Add(lblTitle);
            Controls.Add(txtTitle);
            Controls.Add(lblCategory);
            Controls.Add(cboCategory);
            Controls.Add(lblDate);
            Controls.Add(dtpDate);
            Controls.Add(lblDescription);
            Controls.Add(txtDescription);
            Controls.Add(btnAdd);
            Controls.Add(btnCancel);
            Controls.Add(flowLayoutPanel1);
            Name = "AddEventForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add New Event";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblCategory;
        public System.Windows.Forms.ComboBox cboCategory; // Can remain public for internal use
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
