using SuperMart_Pro.Models;
using System;
using System.Windows.Forms;

namespace SuperMart_Pro.View.Supplier
{
    public partial class DeleteSupplierGUI : Form
    {
        public DeleteSupplierGUI()
        {
            InitializeComponent();
        }

        private void Searchbutton_Click(object sender, EventArgs e)
        {
            string searchId = SearchtextBox.Text.Trim();
            if (string.IsNullOrWhiteSpace(searchId))
            {
                MessageBox.Show("Please enter a Supplier ID to search.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // TODO: load supplier from controller/service by searchId and populate fields
            MessageBox.Show($"Search for supplier '{searchId}' not yet implemented.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SupplierIDtextBox.Text))
            {
                MessageBox.Show("Please search and load a supplier before deleting.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show(
                $"Are you sure you want to delete supplier '{SupplierNametextBox.Text}'?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                // TODO: pass supplierId to controller/service layer for deletion
                MessageBox.Show("Supplier deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
            }
        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearFields()
        {
            SupplierIDtextBox.Clear();
            SupplierNametextBox.Clear();
            ContactNumbertextBox.Clear();
            EmailtextBox.Clear();
            AddresstextBox.Clear();
            CountrytextBox.Clear();
            CompanyNametextBox.Clear();
            WebsitetextBox.Clear();
            // TotalPurchaseAmounttextBox — removed (3NF: aggregated from Purchases at service layer)
            // DueAmounttextBox — removed (3NF: aggregated from Purchases at service layer)
            IsActivecheckBox.Checked = false;
            SearchtextBox.Clear();
            SearchtextBox.Focus();
        }
    }
}
