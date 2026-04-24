using SuperMart_Pro.Models;
using System;
using System.IO;
using System.Windows.Forms;

namespace SuperMart_Pro.View.Expense
{
    public partial class AddExpenseGUI : Form
    {
        private byte[] _receiptImageBytes = Array.Empty<byte>();

        public AddExpenseGUI()
        {
            InitializeComponent();
            DatedatePicker.Value = DateTime.Today;
        }

        private void BrowseReceiptbutton_Click(object sender, EventArgs e)
        {
            using var dlg = new OpenFileDialog();
            dlg.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                _receiptImageBytes = File.ReadAllBytes(dlg.FileName);
                ReceiptpictureBox.Image = System.Drawing.Image.FromFile(dlg.FileName);
            }
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            var expense = new Models.Expense(
                expenseID: ExpenseIDtextBox.Text.Trim(),
                description: DescriptionrichTextBox.Text.Trim(),
                expenseType: (ExpenseType)(ExpenseTypecomboBox.SelectedIndex + 1),
                amount: decimal.Parse(AmounttextBox.Text.Trim()),
                date: DatedatePicker.Value,
                receiptImage: _receiptImageBytes,
                notes: NotesrichTextBox.Text.Trim(),
                branchID: BranchIDtextBox.Text.Trim(),
                approvedBy: string.Empty,   // set by Manager/Admin during approval workflow
                paymentMethod: (PaymentMethod)(PaymentMethodcomboBox.SelectedIndex + 1),
                createdAt: DateTime.Now,
                createdBy: Environment.UserName,
                updatedAt: DateTime.Now,
                updatedBy: Environment.UserName,
                deletedAt: null,
                deletedBy: string.Empty
            );

            // TODO: pass expense to controller/service layer
            MessageBox.Show("Expense saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearFields();
        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BranchIDsearchbutton_Click(object sender, EventArgs e)
        {
            // TODO: open branch search dialog
        }

        private bool ValidateInputs()
        {
            // Expense ID
            if (string.IsNullOrWhiteSpace(ExpenseIDtextBox.Text))
            {
                MessageBox.Show("Expense ID is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ExpenseIDtextBox.Focus();
                return false;
            }

            // Description
            if (string.IsNullOrWhiteSpace(DescriptionrichTextBox.Text))
            {
                MessageBox.Show("Description is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DescriptionrichTextBox.Focus();
                return false;
            }

            // Expense Type
            if (ExpenseTypecomboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an Expense Type.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ExpenseTypecomboBox.Focus();
                return false;
            }

            // Amount
            if (string.IsNullOrWhiteSpace(AmounttextBox.Text))
            {
                MessageBox.Show("Amount is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                AmounttextBox.Focus();
                return false;
            }
            if (!decimal.TryParse(AmounttextBox.Text.Trim(), out decimal amount) || amount <= 0)
            {
                MessageBox.Show("Amount must be a positive number.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                AmounttextBox.Focus();
                return false;
            }

            // Date – must not be in the future
            if (DatedatePicker.Value.Date > DateTime.Today)
            {
                MessageBox.Show("Date cannot be in the future.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DatedatePicker.Focus();
                return false;
            }

            // Branch ID
            if (string.IsNullOrWhiteSpace(BranchIDtextBox.Text))
            {
                MessageBox.Show("Branch ID is required. Use the Search button to select a branch.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                BranchIDtextBox.Focus();
                return false;
            }

            // Payment Method
            if (PaymentMethodcomboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Payment Method.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                PaymentMethodcomboBox.Focus();
                return false;
            }

            return true;
        }

        private void ClearFields()
        {
            ExpenseIDtextBox.Clear();
            DescriptionrichTextBox.Clear();
            ExpenseTypecomboBox.SelectedIndex = -1;
            AmounttextBox.Clear();
            DatedatePicker.Value = DateTime.Today;
            _receiptImageBytes = Array.Empty<byte>();
            ReceiptpictureBox.Image = null;
            NotesrichTextBox.Clear();
            BranchIDtextBox.Clear();
            BranchNametextBox.Clear();
            PaymentMethodcomboBox.SelectedIndex = -1;
            ExpenseIDtextBox.Focus();
        }
    }
}
