using System;
using System.Windows.Forms;
using CustomerModel = SuperMart_Pro.Models.Customer;

namespace SuperMart_Pro.View.Customer
{
    public partial class DeleteCustomerGUI : Form
    {
        // Holds the customer loaded from the search so Delete can reference it
        private CustomerModel? _currentCustomer = null;

        public DeleteCustomerGUI()
        {
            InitializeComponent();
        }

        // ─── Search ───────────────────────────────────────────────────────────

        private void UserSearchbutton_Click(object sender, EventArgs e)
        {
            string query = SearchUserTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(query))
            {
                MessageBox.Show("Please enter a User ID, phone number, or username to search.",
                    "Search", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SearchUserTextBox.Focus();
                return;
            }

            // TODO: replace with real lookup via controller/service layer
            // CustomerModel? found = CustomerService.FindByQuery(query);
            CustomerModel? found = null; // placeholder

            if (found == null)
            {
                MessageBox.Show("No customer found matching the given search term.",
                    "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                return;
            }

            _currentCustomer = found;
            PopulateFields(found);
        }

        // ─── Delete ───────────────────────────────────────────────────────────

        private void Savebutton_Click(object sender, EventArgs e)
        {
            if (_currentCustomer == null)
            {
                MessageBox.Show("Please search and load a customer before deleting.",
                    "No Customer Loaded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show(
                $"Are you sure you want to delete customer \"{_currentCustomer.FullName}\" (ID: {_currentCustomer.CustomerID})?\n\nThis action cannot be undone.",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            // Soft-delete: mark as deleted rather than removing from DB
            _currentCustomer.IsActive  = false;

            // TODO: pass _currentCustomer to controller/service layer
            MessageBox.Show("Customer deleted successfully.", "Deleted",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            ClearFields();
            _currentCustomer = null;
        }

        // ─── Clear / Cancel ───────────────────────────────────────────────────

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            ClearFields();
            _currentCustomer = null;
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        // ─── Helpers ──────────────────────────────────────────────────────────

        /// <summary>Fills all read-only controls from the given <paramref name="customer"/>.</summary>
        private void PopulateFields(CustomerModel customer)
        {
            UserIDtextBox.Text                      = customer.UserID;
            FullNametextBox.Text                    = customer.FullName;
            DateOfBirthdatePicker.Value             = customer.DateOfBirth;
            MaleradioButton.Checked                 = customer.Gender == "Male";
            FemaleradioButton.Checked               = customer.Gender == "Female";
            PhoneNumbertextBox.Text                 = customer.PhoneNumber;
            EmailtextBox.Text                       = customer.Email;
            AddressrichTextBox.Text                 = customer.Address;
            UsernametextBox.Text                    = customer.Username;
            IsActivecheckBox.Checked                = customer.IsActive;
            BranchIDtextBox.Text                    = customer.BranchID;
            CustomerIDtextBox.Text                  = customer.CustomerID;
            // CustomerType is read-only, derived from LoyaltyPoints
            CustomerTypecomboBox.SelectedIndex      = (int)customer.Type - 1;

            // Photo
            if (customer.Photo != null && customer.Photo.Length > 0)
            {
                using var ms = new System.IO.MemoryStream(customer.Photo);
                PhotopictureBox.Image = System.Drawing.Image.FromStream(ms);
            }
            else
            {
                PhotopictureBox.Image = null;
            }
        }

        /// <summary>Resets all form controls to their default state.</summary>
        private void ClearFields()
        {
            SearchUserTextBox.Clear();
            UserIDtextBox.Clear();
            FullNametextBox.Clear();
            DateOfBirthdatePicker.Value             = DateTime.Today;
            MaleradioButton.Checked                 = false;
            FemaleradioButton.Checked               = false;
            PhotopictureBox.Image                   = null;
            PhoneNumbertextBox.Clear();
            EmailtextBox.Clear();
            AddressrichTextBox.Clear();
            UsernametextBox.Clear();
            IsActivecheckBox.Checked                = false;
            BranchIDtextBox.Clear();
            BranchNametextBox.Clear();
            CustomerIDtextBox.Clear();
            CustomerTypecomboBox.SelectedIndex      = -1;
            SearchUserTextBox.Focus();
        }
    }
}
