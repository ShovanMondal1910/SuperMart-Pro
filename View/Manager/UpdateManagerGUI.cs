using System;
using System.Windows.Forms;
using ManagerModel = SuperMart_Pro.Models.Manager;
using ManagerType  = SuperMart_Pro.Models.ManagerType;

namespace SuperMart_Pro.View.Manager
{
    public partial class UpdateManagerGUI : Form
    {
        // Holds the manager loaded from the search so Save can reference it
        private ManagerModel? _currentManager = null;

        public UpdateManagerGUI()
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
            // ManagerModel? found = ManagerService.FindByQuery(query);
            ManagerModel? found = null; // placeholder

            if (found == null)
            {
                MessageBox.Show("No manager found matching the given search term.",
                    "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                return;
            }

            _currentManager = found;
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
            if (_currentManager == null)
            {
                MessageBox.Show("Please search and load a manager before saving.",
                    "No Manager Loaded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInputs()) return;

            // Apply changes to the loaded manager object
            _currentManager.FullName              = FullNametextBox.Text.Trim();
            _currentManager.DateOfBirth           = DateOfBirthdatePicker.Value;
            _currentManager.Gender                = MaleradioButton.Checked ? "Male" : "Female";
            _currentManager.PhoneNumber           = PhoneNumbertextBox.Text.Trim();
            _currentManager.Email                 = EmailtextBox.Text.Trim();
            _currentManager.Address               = AddressrichTextBox.Text.Trim();
            _currentManager.Username              = UsernametextBox.Text.Trim();
            _currentManager.IsActive              = IsActivecheckBox.Checked;
            _currentManager.BranchID              = BranchIDtextBox.Text.Trim();
            _currentManager.Type                  = (ManagerType)(ManagerTypecomboBox.SelectedIndex + 1);
            _currentManager.CanManageStaff        = CanManageStuffcheckBox.Checked;
            _currentManager.CanManageInventory    = CanManageInventoryescheckBox.Checked;
            _currentManager.CanApprovePurchases   = CanApprovePurchasescheckBox.Checked;
            _currentManager.CanViewBranchReports  = CanViewBranchReportscheckBox.Checked;

            // Only update password if the field was changed
            if (!string.IsNullOrWhiteSpace(PasswordtextBox.Text))
                _currentManager.PasswordHash = PasswordtextBox.Text.Trim();

            // Update photo if a new one was selected
            if (PhotopictureBox.Image != null)
            {
                using var ms = new System.IO.MemoryStream();
                PhotopictureBox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                _currentManager.Photo = ms.ToArray();
            }

            _currentManager.UpdatedAt = DateTime.Now;
            _currentManager.UpdatedBy = Environment.UserName;

            // TODO: pass _currentManager to controller/service layer
            MessageBox.Show("Manager updated successfully.", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            ClearFields();
            _currentManager = null;
        }

        // ─── Clear / Cancel ───────────────────────────────────────────────────

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            ClearFields();
            _currentManager = null;
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        // ─── Helpers ──────────────────────────────────────────────────────────

        /// <summary>Fills all form controls from the given <paramref name="manager"/>.</summary>
        private void PopulateFields(ManagerModel manager)
        {
            UserIDtextBox.Text                      = manager.UserID;
            FullNametextBox.Text                    = manager.FullName;
            DateOfBirthdatePicker.Value             = manager.DateOfBirth;
            MaleradioButton.Checked                 = manager.Gender == "Male";
            FemaleradioButton.Checked               = manager.Gender == "Female";
            PhoneNumbertextBox.Text                 = manager.PhoneNumber;
            EmailtextBox.Text                       = manager.Email;
            AddressrichTextBox.Text                 = manager.Address;
            UsernametextBox.Text                    = manager.Username;
            PasswordtextBox.Text                    = string.Empty; // never pre-fill password
            IsActivecheckBox.Checked                = manager.IsActive;
            BranchIDtextBox.Text                    = manager.BranchID;
            ManagerIDtextBox.Text                   = manager.ManagerID;
            ManagerTypecomboBox.SelectedIndex       = (int)manager.Type - 1;
            CanManageStuffcheckBox.Checked          = manager.CanManageStaff;
            CanManageInventoryescheckBox.Checked    = manager.CanManageInventory;
            CanApprovePurchasescheckBox.Checked     = manager.CanApprovePurchases;
            CanViewBranchReportscheckBox.Checked    = manager.CanViewBranchReports;

            // Photo
            if (manager.Photo != null && manager.Photo.Length > 0)
            {
                using var ms = new System.IO.MemoryStream(manager.Photo);
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

            // Manager Type
            if (ManagerTypecomboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Manager Type.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ManagerTypecomboBox.Focus();
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
            ManagerIDtextBox.Clear();
            ManagerTypecomboBox.SelectedIndex       = -1;
            CanManageStuffcheckBox.Checked          = false;
            CanManageInventoryescheckBox.Checked    = false;
            CanApprovePurchasescheckBox.Checked     = false;
            CanViewBranchReportscheckBox.Checked    = false;
            SearchUserTextBox.Focus();
        }
    }
}
