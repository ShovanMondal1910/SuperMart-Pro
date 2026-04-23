using System;
using System.Windows.Forms;
using AdminModel = SuperMart_Pro.Models.Admin;

namespace SuperMart_Pro.View.Admin
{
    public partial class DeleteAdminGUI : Form
    {
        // Holds the admin loaded from the search so Delete can reference it
        private AdminModel? _currentAdmin = null;

        public DeleteAdminGUI()
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

        // ─── Delete ───────────────────────────────────────────────────────────

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            if (_currentAdmin == null)
            {
                MessageBox.Show("Please search and load an admin before deleting.",
                    "No Admin Loaded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show(
                $"Are you sure you want to delete admin \"{_currentAdmin.FullName}\" (ID: {_currentAdmin.AdminID})?\n\nThis action cannot be undone.",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            // Soft-delete: mark as deleted rather than removing from DB
            _currentAdmin.DeletedAt = DateTime.Now;
            _currentAdmin.DeletedBy = Environment.UserName;
            _currentAdmin.IsActive  = false;

            // TODO: pass _currentAdmin to controller/service layer
            MessageBox.Show("Admin deleted successfully.", "Deleted",
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

        /// <summary>Fills all read-only controls from the given <paramref name="admin"/>.</summary>
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
