using System;
using System.Windows.Forms;
using CashierModel = SuperMart_Pro.Models.Cashier;

namespace SuperMart_Pro.View.Cashier
{
    public partial class DeleteCashierGUI : Form
    {
        // Holds the cashier loaded from the search so Delete can reference it
        private CashierModel? _currentCashier = null;

        public DeleteCashierGUI()
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

        // ─── Delete ───────────────────────────────────────────────────────────

        private void Savebutton_Click(object sender, EventArgs e)
        {
            if (_currentCashier == null)
            {
                MessageBox.Show("Please search and load a cashier before deleting.",
                    "No Cashier Loaded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show(
                $"Are you sure you want to delete cashier \"{_currentCashier.FullName}\" (ID: {_currentCashier.CashierID})?\n\nThis action cannot be undone.",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            // Soft-delete: mark as deleted rather than removing from DB
            _currentCashier.IsActive  = false;

            // TODO: pass _currentCashier to controller/service layer
            MessageBox.Show("Cashier deleted successfully.", "Deleted",
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

        /// <summary>Fills all read-only controls from the given <paramref name="cashier"/>.</summary>
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
