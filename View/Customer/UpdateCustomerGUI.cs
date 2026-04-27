using System;
using System.Windows.Forms;
using CustomerModel = SuperMart_Pro.Models.Customer;

namespace SuperMart_Pro.View.Customer
{
    public partial class UpdateCustomerGUI : Form
    {
        // Holds the customer loaded from the search so Save can reference it
        private CustomerModel? _currentCustomer = null;

        public UpdateCustomerGUI()
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

        private void BranchIDsearchbutton_Click(object sender, EventArgs e)
        {
            string branchQuery = BranchIDtextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(branchQuery))
            {
                MessageBox.Show("Please enter a Branch ID to search.",
                    "Search", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                BranchIDtextBox.Focus();
                return;
            }

            // TODO: replace with real branch lookup via controller/service layer
            // Branch? branch = BranchService.FindByID(branchQuery);
            // if (branch != null) BranchNametextBox.Text = branch.BranchName;
            BranchNametextBox.Text = string.Empty; // placeholder
        }

        // ─── Photo ────────────────────────────────────────────────────────────

        private void BrowsePhotobutton_Click(object sender, EventArgs e)
        {
            using var dlg = new OpenFileDialog();
            dlg.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (dlg.ShowDialog() == DialogResult.OK)
                PhotopictureBox.Image = System.Drawing.Image.FromFile(dlg.FileName);
        }

        // ─── Save ─────────────────────────────────────────────────────────────

        private void Savebutton_Click(object sender, EventArgs e)
        {
            if (_currentCustomer == null)
            {
                MessageBox.Show("Please search and load a customer before saving.",
                    "No Customer Loaded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInputs()) return;

            // Apply changes to the loaded customer object
            _currentCustomer.FullName    = FullNametextBox.Text.Trim();
            _currentCustomer.DateOfBirth = DateOfBirthdatePicker.Value;
            _currentCustomer.Gender      = MaleradioButton.Checked ? "Male" : "Female";
            _currentCustomer.PhoneNumber = PhoneNumbertextBox.Text.Trim();
            _currentCustomer.Email       = EmailtextBox.Text.Trim();
            _currentCustomer.Address     = AddressrichTextBox.Text.Trim();
            _currentCustomer.Username    = UsernametextBox.Text.Trim();
            _currentCustomer.IsActive    = IsActivecheckBox.Checked;
            _currentCustomer.BranchID    = BranchIDtextBox.Text.Trim();

            // Security questions
            _currentCustomer.SecurityQuestion1 = string.Empty;
            _currentCustomer.SecurityAnswer1   = string.Empty;
            _currentCustomer.SecurityQuestion2 = string.Empty;
            _currentCustomer.SecurityAnswer2   = string.Empty;

            // Only update password if the user typed something new
            if (!string.IsNullOrWhiteSpace(PasswordtextBox.Text))
                _currentCustomer.PasswordHash = PasswordtextBox.Text.Trim();

            // Update photo if a new one was selected
            if (PhotopictureBox.Image != null)
            {
                using var ms = new System.IO.MemoryStream();
                PhotopictureBox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                _currentCustomer.Photo = ms.ToArray();
            }

            // Refresh the read-only CustomerType display (derived from LoyaltyPoints)
            CustomerTypecomboBox.SelectedIndex = (int)_currentCustomer.Type - 1;

            // TODO: pass _currentCustomer to controller/service layer
            MessageBox.Show("Customer updated successfully.", "Success",
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

        /// <summary>Fills all form controls from the given <paramref name="customer"/>.</summary>
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
            PasswordtextBox.Text                    = string.Empty; // never pre-fill password
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

        /// <summary>Validates all required fields. Returns false and focuses the offending control on failure.</summary>
        private bool ValidateInputs()
        {
            // Full Name
            if (string.IsNullOrWhiteSpace(FullNametextBox.Text))
            {
                MessageBox.Show("Full Name is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                FullNametextBox.Focus();
                return false;
            }

            // Date of Birth – must be in the past
            if (DateOfBirthdatePicker.Value.Date >= DateTime.Today)
            {
                MessageBox.Show("Date of Birth must be in the past.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DateOfBirthdatePicker.Focus();
                return false;
            }

            // Gender
            if (!MaleradioButton.Checked && !FemaleradioButton.Checked)
            {
                MessageBox.Show("Please select a Gender.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MaleradioButton.Focus();
                return false;
            }

            // Phone Number
            if (string.IsNullOrWhiteSpace(PhoneNumbertextBox.Text))
            {
                MessageBox.Show("Phone Number is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                PhoneNumbertextBox.Focus();
                return false;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(PhoneNumbertextBox.Text.Trim(), @"^\+?[0-9\s\-]{7,15}$"))
            {
                MessageBox.Show("Phone Number is not valid.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                PhoneNumbertextBox.Focus();
                return false;
            }

            // Email
            if (string.IsNullOrWhiteSpace(EmailtextBox.Text))
            {
                MessageBox.Show("Email is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                EmailtextBox.Focus();
                return false;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(EmailtextBox.Text.Trim(), @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Email address is not valid.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                EmailtextBox.Focus();
                return false;
            }

            // Address
            if (string.IsNullOrWhiteSpace(AddressrichTextBox.Text))
            {
                MessageBox.Show("Address is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                AddressrichTextBox.Focus();
                return false;
            }

            // Username
            if (string.IsNullOrWhiteSpace(UsernametextBox.Text))
            {
                MessageBox.Show("Username is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                UsernametextBox.Focus();
                return false;
            }

            // Password – only validate length if the user typed something new
            if (!string.IsNullOrWhiteSpace(PasswordtextBox.Text) && PasswordtextBox.Text.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                PasswordtextBox.Focus();
                return false;
            }

            // Branch ID
            if (string.IsNullOrWhiteSpace(BranchIDtextBox.Text))
            {
                MessageBox.Show("Branch ID is required. Use the Search button to select a branch.",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                BranchIDtextBox.Focus();
                return false;
            }

            return true;
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
            PasswordtextBox.Clear();
            IsActivecheckBox.Checked                = false;
            BranchIDtextBox.Clear();
            BranchNametextBox.Clear();
            CustomerIDtextBox.Clear();
            CustomerTypecomboBox.SelectedIndex      = -1;
            SearchUserTextBox.Focus();
        }
    }
}
