using SuperMart_Pro.Models;
using System;
using System.Windows.Forms;

namespace SuperMart_Pro.View.Supplier
{
    public partial class AddSupplierGUI : Form
    {
        public AddSupplierGUI()
        {
            InitializeComponent();
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
                website: WebsitetextBox.Text.Trim(),
                createdAt: DateTime.Now,
                createdBy: Environment.UserName,
                updatedAt: DateTime.Now,
                updatedBy: Environment.UserName,
                deletedAt: null,
                deletedBy: string.Empty
            );

            // TODO: pass supplier to controller/service layer
            MessageBox.Show("Supplier saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (!IsActivecheckBox.Checked && string.IsNullOrWhiteSpace(SupplierIDtextBox.Text))
            {
                // IsActive is optional, no validation needed
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
            SupplierIDtextBox.Focus();
        }

    }
}
