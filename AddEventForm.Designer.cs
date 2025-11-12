using System;
using System.Drawing;
using System.Windows.Forms;

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
            pnlHeader = new Panel();
            lblHeader = new Label();
            pnlContent = new Panel();
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
            lblHeader.Text = "➕ Add New Community Event";

            // ===== CONTENT PANEL =====
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.BackColor = Color.WhiteSmoke;
            pnlContent.Padding = new Padding(40);
            pnlContent.Controls.AddRange(new Control[]
            {
                lblTitle, txtTitle,
                lblCategory, cboCategory,
                lblDate, dtpDate,
                lblDescription, txtDescription,
                btnAdd, btnCancel
            });

            // ===== LABELS AND INPUTS =====
            Font labelFont = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            Font inputFont = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);

            // Title
            lblTitle.Text = "Event Title:";
            lblTitle.Font = labelFont;
            lblTitle.Location = new Point(180, 80);
            lblTitle.AutoSize = true;

            txtTitle.Font = inputFont;
            txtTitle.Location = new Point(340, 78);
            txtTitle.Size = new Size(380, 27);

            // Category
            lblCategory.Text = "Category:";
            lblCategory.Font = labelFont;
            lblCategory.Location = new Point(180, 130);
            lblCategory.AutoSize = true;

            cboCategory.Font = inputFont;
            cboCategory.Location = new Point(340, 128);
            cboCategory.Size = new Size(250, 28);
            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;

            // Date
            lblDate.Text = "Event Date:";
            lblDate.Font = labelFont;
            lblDate.Location = new Point(180, 180);
            lblDate.AutoSize = true;

            dtpDate.Font = inputFont;
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpDate.Location = new Point(340, 178);
            dtpDate.Size = new Size(150, 27);

            // Description
            lblDescription.Text = "Description:";
            lblDescription.Font = labelFont;
            lblDescription.Location = new Point(180, 230);
            lblDescription.AutoSize = true;

            txtDescription.Font = inputFont;
            txtDescription.Location = new Point(340, 230);
            txtDescription.Multiline = true;
            txtDescription.Size = new Size(380, 130);
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.BorderStyle = BorderStyle.FixedSingle;

            // ===== BUTTONS =====
            btnAdd.Text = "✅ Add Event";
            btnAdd.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnAdd.BackColor = Color.MediumSeaGreen;
            btnAdd.ForeColor = Color.White;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.Size = new Size(140, 45);
            btnAdd.Location = new Point(340, 390);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.Click += btnAdd_Click;
            btnAdd.MouseEnter += (s, e) => btnAdd.BackColor = Color.SeaGreen;
            btnAdd.MouseLeave += (s, e) => btnAdd.BackColor = Color.MediumSeaGreen;

            btnCancel.Text = "❌ Cancel";
            btnCancel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCancel.BackColor = Color.IndianRed;
            btnCancel.ForeColor = Color.White;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.Size = new Size(140, 45);
            btnCancel.Location = new Point(520, 390);
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.Click += btnCancel_Click;
            btnCancel.MouseEnter += (s, e) => btnCancel.BackColor = Color.Firebrick;
            btnCancel.MouseLeave += (s, e) => btnCancel.BackColor = Color.IndianRed;

            // ===== FORM SETTINGS =====
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(900, 550);
            Controls.Add(pnlContent);
            Controls.Add(pnlHeader);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add New Event";

            pnlHeader.ResumeLayout(false);
            pnlContent.ResumeLayout(false);
            pnlContent.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblHeader;
        private Panel pnlContent;
        private Label lblTitle;
        private TextBox txtTitle;
        private Label lblCategory;
        public ComboBox cboCategory;
        private Label lblDate;
        private DateTimePicker dtpDate;
        private Label lblDescription;
        private TextBox txtDescription;
        private Button btnAdd;
        private Button btnCancel;
    }
}
