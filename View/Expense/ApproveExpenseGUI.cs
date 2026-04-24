using SuperMart_Pro.Models;
using System;
using System.Windows.Forms;

namespace SuperMart_Pro.View.Expense
{
    public partial class ApproveExpenseGUI : Form
    {
        public ApproveExpenseGUI()
        {
            InitializeComponent();
        }

        private void ApproveExpenseGUI_Load(object sender, EventArgs e)
        {
            SetupGrid();
            LoadPendingExpenses();
        }

        // ─────────────────────────────────────────────────────────────────────
        //  GRID SETUP & DATA
        // ─────────────────────────────────────────────────────────────────────

        private void SetupGrid()
        {
            PendingExpensesdataGridView.AutoGenerateColumns = false;
            PendingExpensesdataGridView.Columns.Clear();

            PendingExpensesdataGridView.Columns.Add(new DataGridViewTextBoxColumn { Name = "ExpenseID",     HeaderText = "Expense ID",     DataPropertyName = "ExpenseID",     Width = 120 });
            PendingExpensesdataGridView.Columns.Add(new DataGridViewTextBoxColumn { Name = "Description",   HeaderText = "Description",    DataPropertyName = "Description",   Width = 200 });
            PendingExpensesdataGridView.Columns.Add(new DataGridViewTextBoxColumn { Name = "ExpenseType",   HeaderText = "Type",           DataPropertyName = "ExpenseType",   Width = 130 });
            PendingExpensesdataGridView.Columns.Add(new DataGridViewTextBoxColumn { Name = "Amount",        HeaderText = "Amount",         DataPropertyName = "Amount",        Width = 110 });
            PendingExpensesdataGridView.Columns.Add(new DataGridViewTextBoxColumn { Name = "Date",          HeaderText = "Date",           DataPropertyName = "Date",          Width = 110 });
            PendingExpensesdataGridView.Columns.Add(new DataGridViewTextBoxColumn { Name = "PaymentMethod", HeaderText = "Payment Method", DataPropertyName = "PaymentMethod", Width = 140 });
            PendingExpensesdataGridView.Columns.Add(new DataGridViewTextBoxColumn { Name = "BranchID",      HeaderText = "Branch ID",      DataPropertyName = "BranchID",      Width = 110 });
            PendingExpensesdataGridView.Columns.Add(new DataGridViewTextBoxColumn { Name = "CreatedBy",     HeaderText = "Submitted By",   DataPropertyName = "CreatedBy",     Width = 130 });
            PendingExpensesdataGridView.Columns.Add(new DataGridViewTextBoxColumn { Name = "CreatedAt",     HeaderText = "Submitted At",   DataPropertyName = "CreatedAt",     Width = 150 });

            PendingExpensesdataGridView.Columns["Amount"]!.DefaultCellStyle.Format    = "N2";
            PendingExpensesdataGridView.Columns["Amount"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            PendingExpensesdataGridView.Columns["Date"]!.DefaultCellStyle.Format      = "yyyy-MM-dd";
            PendingExpensesdataGridView.Columns["CreatedAt"]!.DefaultCellStyle.Format = "yyyy-MM-dd HH:mm";
        }

        private void LoadPendingExpenses()
        {
            // TODO: load pending (unapproved) expenses from controller/service
            PendingExpensesdataGridView.DataSource = null;
            PendingCountlabel.Text = "Pending: 0";
            ClearDetailPanel();
        }

        // ─────────────────────────────────────────────────────────────────────
        //  GRID SELECTION → POPULATE DETAIL PANEL
        // ─────────────────────────────────────────────────────────────────────

        private void PendingExpensesdataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (PendingExpensesdataGridView.CurrentRow == null) return;

            // TODO: replace with real object from bound source
            // For now just populate from cell values as a placeholder
            var row = PendingExpensesdataGridView.CurrentRow;

            DetailExpenseIDtextBox.Text    = row.Cells["ExpenseID"].Value?.ToString()     ?? string.Empty;
            DetailDescriptiontextBox.Text  = row.Cells["Description"].Value?.ToString()   ?? string.Empty;
            DetailTypetextBox.Text         = row.Cells["ExpenseType"].Value?.ToString()   ?? string.Empty;
            DetailAmounttextBox.Text       = row.Cells["Amount"].Value?.ToString()        ?? string.Empty;
            DetailDatetextBox.Text         = row.Cells["Date"].Value?.ToString()          ?? string.Empty;
            DetailPaymentMethodtextBox.Text= row.Cells["PaymentMethod"].Value?.ToString() ?? string.Empty;
            DetailBranchIDtextBox.Text     = row.Cells["BranchID"].Value?.ToString()      ?? string.Empty;
            DetailSubmittedBytextBox.Text  = row.Cells["CreatedBy"].Value?.ToString()     ?? string.Empty;

            // Receipt image: TODO load from bound Expense object
            ReceiptpictureBox.Image = null;

            // Clear previous approver notes
            ApproverNotesrichtextBox.Clear();

            // Enable action buttons
            Approvebutton.Enabled = true;
            Rejectbutton.Enabled  = true;
        }

        // ─────────────────────────────────────────────────────────────────────
        //  APPROVE
        // ─────────────────────────────────────────────────────────────────────

        private void Approvebutton_Click(object sender, EventArgs e)
        {
            if (PendingExpensesdataGridView.CurrentRow == null)
            {
                MessageBox.Show("Please select an expense to approve.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string expenseId = DetailExpenseIDtextBox.Text.Trim();
            string approverNotes = ApproverNotesrichtextBox.Text.Trim();

            var confirm = MessageBox.Show(
                $"Approve expense '{expenseId}'?",
                "Confirm Approval",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            // TODO: call controller/service to approve expense
            //   - set ApprovedBy = Environment.UserName
            //   - set ApprovalStatus = Approved
            //   - save approverNotes
            MessageBox.Show($"Expense '{expenseId}' approved successfully.", "Approved",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadPendingExpenses();
        }

        // ─────────────────────────────────────────────────────────────────────
        //  REJECT
        // ─────────────────────────────────────────────────────────────────────

        private void Rejectbutton_Click(object sender, EventArgs e)
        {
            if (PendingExpensesdataGridView.CurrentRow == null)
            {
                MessageBox.Show("Please select an expense to reject.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string expenseId = DetailExpenseIDtextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(ApproverNotesrichtextBox.Text))
            {
                MessageBox.Show("Please provide a reason for rejection in the Approver Notes field.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ApproverNotesrichtextBox.Focus();
                return;
            }

            var confirm = MessageBox.Show(
                $"Reject expense '{expenseId}'?",
                "Confirm Rejection",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            // TODO: call controller/service to reject expense
            //   - set ApprovalStatus = Rejected
            //   - save approverNotes as rejection reason
            MessageBox.Show($"Expense '{expenseId}' rejected.", "Rejected",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadPendingExpenses();
        }

        // ─────────────────────────────────────────────────────────────────────
        //  SEARCH / REFRESH / CLOSE
        // ─────────────────────────────────────────────────────────────────────

        private void Searchbutton_Click(object sender, EventArgs e)
        {
            string keyword = SearchtextBox.Text.Trim();
            // TODO: filter pending expenses by keyword via controller/service
            MessageBox.Show($"Search for '{keyword}' not yet implemented.", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Refreshbutton_Click(object sender, EventArgs e)
        {
            SearchtextBox.Clear();
            LoadPendingExpenses();
        }

        private void Closebutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        // ─────────────────────────────────────────────────────────────────────
        //  HELPERS
        // ─────────────────────────────────────────────────────────────────────

        private void ClearDetailPanel()
        {
            DetailExpenseIDtextBox.Clear();
            DetailDescriptiontextBox.Clear();
            DetailTypetextBox.Clear();
            DetailAmounttextBox.Clear();
            DetailDatetextBox.Clear();
            DetailPaymentMethodtextBox.Clear();
            DetailBranchIDtextBox.Clear();
            DetailSubmittedBytextBox.Clear();
            ApproverNotesrichtextBox.Clear();
            ReceiptpictureBox.Image = null;
            Approvebutton.Enabled  = false;
            Rejectbutton.Enabled   = false;
        }
    }
}
