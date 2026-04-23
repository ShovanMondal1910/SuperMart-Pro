using System;
using System.Windows.Forms;
using ManagerModel = SuperMart_Pro.Models.Manager;

namespace SuperMart_Pro.View.Manager
{
    public partial class DeleteManagerGUI : Form
    {
        // Holds the manager loaded from the search so Delete can reference it
        private ManagerModel? _currentManager = null;

        public DeleteManagerGUI()
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

        // ─── Delete ───────────────────────────────────────────────────────────

        private void Savebutton_Click(object sender, EventArgs e)
        {
            if (_currentManager == null)
            {
                MessageBox.Show("Please search and load a manager before deleting.",
                    "No Manager Loaded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show(
                $"Are you sure you want to delete manager \"{_currentManager.FullName}\" (ID: {_currentManager.ManagerID})?\n\nThis action cannot be undone.",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            // Soft-delete: mark as deleted rather than removing from DB
            _currentManager.DeletedAt = DateTime.Now;
            _currentManager.DeletedBy = Environment.UserName;
            _currentManager.IsActive  = false;

            // TODO: pass _currentManager to controller/service layer
            MessageBox.Show("Manager deleted successfully.", "Deleted",
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

        /// <summary>Fills all read-only controls from the given <paramref name="manager"/>.</summary>
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
