using Microsoft.VisualBasic;
using MunicipalityApp.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace MunicipalityApp
{
    public partial class AddEventForm : Form
    {
        public Event CreatedEvent { get; private set; }

        public AddEventForm()
        {
            InitializeComponent();
        }

        // Public property to set categories from LocalEventsForm
        public string[] Categories
        {
            get => cboCategory.Items.Cast<string>().ToArray();
            set
            {
                cboCategory.Items.Clear();
                if (value != null && value.Length > 0)
                    cboCategory.Items.AddRange(value);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text.Trim();
            string category = cboCategory.Text.Trim();
            DateTime date = dtpDate.Value.Date;
            string description = txtDescription.Text.Trim();

            if (string.IsNullOrWhiteSpace(title))
            {
                MessageBox.Show("Please enter a title.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(category))
            {
                MessageBox.Show("Please select or enter a category.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Create the event object (ID will be assigned by EventManager)
            CreatedEvent = new Event(0, title, category, date, description);

            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
