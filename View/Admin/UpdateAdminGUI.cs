using System;
using System.Windows.Forms;
using AdminModel = SuperMart_Pro.Models.Admin;
using AdminType  = SuperMart_Pro.Models.AdminType;

namespace SuperMart_Pro.View.Admin
{
    public partial class UpdateAdminGUI : Form
    {
        // Holds the admin loaded from the search so Save can reference it
        private AdminModel? _currentAdmin = null;

        public UpdateAdminGUI()
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
            // AdminModel? found = AdminService.FindByQuery(query);
            AdminModel? found = null; // placeholder

            if (found == null)
            {
                MessageBox.Show("No admin found matching the given search term.",
                    "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                return;
            }

            _currentAdmin = found;
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
            if (_currentAdmin == null)
            {
                MessageBox.Show("Please search and load an admin before saving.",
                    "No Admin Loaded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInputs()) return;

            // Apply changes to the loaded admin object
            _currentAdmin.FullName           = FullNametextBox.Text.Trim();
            _currentAdmin.DateOfBirth        = DateOfBirthdatePicker.Value;
            _currentAdmin.Gender             = MaleradioButton.Checked ? "Male" : "Female";
            _currentAdmin.PhoneNumber        = PhoneNumbertextBox.Text.Trim();
            _currentAdmin.Email              = EmailtextBox.Text.Trim();
            _currentAdmin.Address            = AddressrichTextBox.Text.Trim();
            _currentAdmin.Username           = UsernametextBox.Text.Trim();
            _currentAdmin.IsActive           = IsActivecheckBox.Checked;
            _currentAdmin.BranchID           = BranchIDtextBox.Text.Trim();
            _currentAdmin.AdminID            = AdminIDtextBox.Text.Trim();
            _currentAdmin.Type               = (AdminType)(AdminTypecomboBox.SelectedIndex + 1);
            _currentAdmin.CanManageUsers     = CanManageUserscheckBox.Checked;
            _currentAdmin.CanManageBranches  = CanManageBranchescheckBox.Checked;
            _currentAdmin.CanViewReports     = CanViewReportscheckBox.Checked;

            // Only update password if the field was changed
            if (!string.IsNullOrWhiteSpace(PasswordtextBox.Text))
                _currentAdmin.PasswordHash = PasswordtextBox.Text.Trim();

            // Update photo if a new one was selected
            if (PhotopictureBox.Image != null)
            {
                using var ms = new System.IO.MemoryStream();
                PhotopictureBox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                _currentAdmin.Photo = ms.ToArray();
            }

            _currentAdmin.UpdatedAt = DateTime.Now;
            _currentAdmin.UpdatedBy = Environment.UserName;

            // TODO: pass _currentAdmin to controller/service layer
            MessageBox.Show("Admin updated successfully.", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            ClearFields();
            _currentAdmin = null;
        }

        // ─── Clear / Cancel ───────────────────────────────────────────────────

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            ClearFields();
            _currentAdmin = null;
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        // ─── Helpers ──────────────────────────────────────────────────────────

        /// <summary>Fills all form controls from the given <paramref name="admin"/>.</summary>
        private void PopulateFields(AdminModel admin)
        {
            UserIDtextBox.Text                = admin.UserID;
            FullNametextBox.Text              = admin.FullName;
            DateOfBirthdatePicker.Value       = admin.DateOfBirth;
            MaleradioButton.Checked           = admin.Gender == "Male";
            FemaleradioButton.Checked         = admin.Gender == "Female";
            PhoneNumbertextBox.Text           = admin.PhoneNumber;
            EmailtextBox.Text                 = admin.Email;
            AddressrichTextBox.Text           = admin.Address;
            UsernametextBox.Text              = admin.Username;
            PasswordtextBox.Text              = string.Empty; // never pre-fill password
            IsActivecheckBox.Checked          = admin.IsActive;
            BranchIDtextBox.Text              = admin.BranchID;
            AdminIDtextBox.Text               = admin.AdminID;
            AdminTypecomboBox.SelectedIndex   = (int)admin.Type - 1;
            CanManageUserscheckBox.Checked    = admin.CanManageUsers;
            CanManageBranchescheckBox.Checked = admin.CanManageBranches;
            CanViewReportscheckBox.Checked    = admin.CanViewReports;

            // Photo
            if (admin.Photo != null && admin.Photo.Length > 0)
            {
                using var ms = new System.IO.MemoryStream(admin.Photo);
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

            // Admin ID
            if (string.IsNullOrWhiteSpace(AdminIDtextBox.Text))
            {
                MessageBox.Show("Admin ID is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                AdminIDtextBox.Focus();
                return false;
            }

            // Admin Type
            if (AdminTypecomboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an Admin Type.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                AdminTypecomboBox.Focus();
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
            DateOfBirthdatePicker.Value       = DateTime.Today;
            MaleradioButton.Checked           = false;
            FemaleradioButton.Checked         = false;
            PhotopictureBox.Image             = null;
            PhoneNumbertextBox.Clear();
            EmailtextBox.Clear();
            AddressrichTextBox.Clear();
            UsernametextBox.Clear();
            PasswordtextBox.Clear();
            IsActivecheckBox.Checked          = false;
            BranchIDtextBox.Clear();
            BranchNametextBox.Clear();
            AdminIDtextBox.Clear();
            AdminTypecomboBox.SelectedIndex      = -1;
            CanManageUserscheckBox.Checked       = false;
            CanManageBranchescheckBox.Checked    = false;
            CanViewReportscheckBox.Checked       = false;
            SearchUserTextBox.Focus();
        }
    }
}
