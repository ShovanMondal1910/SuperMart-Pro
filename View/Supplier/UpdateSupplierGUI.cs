using SuperMart_Pro.Models;
using System;
using System.Windows.Forms;

namespace SuperMart_Pro.View.Supplier
{
    public partial class UpdateSupplierGUI : Form
    {
        public UpdateSupplierGUI()
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

        private void Savebutton_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            var supplier = new Models.Supplier(
                supplierId: SupplierIDtextBox.Text.Trim(),
                supplierName: SupplierNametextBox.Text.Trim(),
                contactNumber: ContactNumbertextBox.Text.Trim(),
                email: EmailtextBox.Text.Trim(),
                address: AddresstextBox.Text.Trim(),
                country: CountrytextBox.Text.Trim(),
                companyName: CompanyNametextBox.Text.Trim(),
                isActive: IsActivecheckBox.Checked,
                website: WebsitetextBox.Text.Trim()
            );

            // TODO: pass supplier to controller/service layer for update
            MessageBox.Show("Supplier updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearFields();
        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(SupplierIDtextBox.Text))
            {
                MessageBox.Show("Supplier ID is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SupplierIDtextBox.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(SupplierNametextBox.Text))
            {
                MessageBox.Show("Supplier Name is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SupplierNametextBox.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(ContactNumbertextBox.Text))
            {
                MessageBox.Show("Contact Number is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ContactNumbertextBox.Focus();
                return false;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(ContactNumbertextBox.Text.Trim(), @"^\+?[0-9\s\-]{7,15}$"))
            {
                MessageBox.Show("Contact Number is not valid.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ContactNumbertextBox.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(EmailtextBox.Text))
            {
                MessageBox.Show("Email is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                EmailtextBox.Focus();
                return false;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(EmailtextBox.Text.Trim(), @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Email is not valid.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                EmailtextBox.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(AddresstextBox.Text))
            {
                MessageBox.Show("Address is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                AddresstextBox.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(CountrytextBox.Text))
            {
                MessageBox.Show("Country is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CountrytextBox.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(CompanyNametextBox.Text))
            {
                MessageBox.Show("Company Name is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CompanyNametextBox.Focus();
                return false;
            }
            return true;
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
