using System;
using System.Windows.Forms;
using CashierModel = SuperMart_Pro.Models.Cashier;
using CashierType  = SuperMart_Pro.Models.CashierType;

namespace SuperMart_Pro.View.Cashier
{
    public partial class UpdateCashierGUI : Form
    {
        // Holds the cashier loaded from the search so Save can reference it
        private CashierModel? _currentCashier = null;

        public UpdateCashierGUI()
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
            // CashierModel? found = CashierService.FindByQuery(query);
            CashierModel? found = null; // placeholder

            if (found == null)
            {
                MessageBox.Show("No cashier found matching the given search term.",
                    "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                return;
            }

            _currentCashier = found;
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
            if (_currentCashier == null)
            {
                MessageBox.Show("Please search and load a cashier before saving.",
                    "No Cashier Loaded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInputs()) return;

            // Apply changes to the loaded cashier object
            _currentCashier.FullName            = FullNametextBox.Text.Trim();
            _currentCashier.DateOfBirth         = DateOfBirthdatePicker.Value;
            _currentCashier.Gender              = MaleradioButton.Checked ? "Male" : "Female";
            _currentCashier.PhoneNumber         = PhoneNumbertextBox.Text.Trim();
            _currentCashier.Email               = EmailtextBox.Text.Trim();
            _currentCashier.Address             = AddressrichTextBox.Text.Trim();
            _currentCashier.Username            = UsernametextBox.Text.Trim();
            _currentCashier.IsActive            = IsActivecheckBox.Checked;
            _currentCashier.BranchID            = BranchIDtextBox.Text.Trim();
            _currentCashier.Type                = (CashierType)(CashierTypecomboBox.SelectedIndex + 1);
            _currentCashier.CanProcessSales     = CanProcessSalescheckBox.Checked;
            _currentCashier.CanProcessReturns   = CanProcessReturnscheckBox.Checked;
            _currentCashier.CanManageStock      = CanManageStockcheckBox.Checked;

            // Only update password if the user typed something new
            if (!string.IsNullOrWhiteSpace(PasswordtextBox.Text))
                _currentCashier.PasswordHash = PasswordtextBox.Text.Trim();

            // Update photo if a new one was selected
            if (PhotopictureBox.Image != null)
            {
                using var ms = new System.IO.MemoryStream();
                PhotopictureBox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                _currentCashier.Photo = ms.ToArray();
            }

            // TODO: pass _currentCashier to controller/service layer
            MessageBox.Show("Cashier updated successfully.", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            ClearFields();
            _currentCashier = null;
        }

        // ─── Clear / Cancel ───────────────────────────────────────────────────

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            ClearFields();
            _currentCashier = null;
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        // ─── Helpers ──────────────────────────────────────────────────────────

        /// <summary>Fills all form controls from the given <paramref name="cashier"/>.</summary>
        private void PopulateFields(CashierModel cashier)
        {
            UserIDtextBox.Text                  = cashier.UserID;
            FullNametextBox.Text                = cashier.FullName;
            DateOfBirthdatePicker.Value         = cashier.DateOfBirth;
            MaleradioButton.Checked             = cashier.Gender == "Male";
            FemaleradioButton.Checked           = cashier.Gender == "Female";
            PhoneNumbertextBox.Text             = cashier.PhoneNumber;
            EmailtextBox.Text                   = cashier.Email;
            AddressrichTextBox.Text             = cashier.Address;
            UsernametextBox.Text                = cashier.Username;
            PasswordtextBox.Text                = string.Empty; // never pre-fill password
            IsActivecheckBox.Checked            = cashier.IsActive;
            BranchIDtextBox.Text                = cashier.BranchID;
            CashierIDtextBox.Text               = cashier.CashierID;
            CashierTypecomboBox.SelectedIndex   = (int)cashier.Type - 1;
            CanProcessSalescheckBox.Checked     = cashier.CanProcessSales;
            CanProcessReturnscheckBox.Checked   = cashier.CanProcessReturns;
            CanManageStockcheckBox.Checked      = cashier.CanManageStock;

            // Photo
            if (cashier.Photo != null && cashier.Photo.Length > 0)
            {
                using var ms = new System.IO.MemoryStream(cashier.Photo);
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

            // Cashier Type
            if (CashierTypecomboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Cashier Type.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CashierTypecomboBox.Focus();
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
            DateOfBirthdatePicker.Value         = DateTime.Today;
            MaleradioButton.Checked             = false;
            FemaleradioButton.Checked           = false;
            PhotopictureBox.Image               = null;
            PhoneNumbertextBox.Clear();
            EmailtextBox.Clear();
            AddressrichTextBox.Clear();
            UsernametextBox.Clear();
            PasswordtextBox.Clear();
            IsActivecheckBox.Checked            = false;
            BranchIDtextBox.Clear();
            BranchNametextBox.Clear();
            CashierIDtextBox.Clear();
            CashierTypecomboBox.SelectedIndex   = -1;
            CanProcessSalescheckBox.Checked     = false;
            CanProcessReturnscheckBox.Checked   = false;
            CanManageStockcheckBox.Checked      = false;
            SearchUserTextBox.Focus();
        }
    }
}
