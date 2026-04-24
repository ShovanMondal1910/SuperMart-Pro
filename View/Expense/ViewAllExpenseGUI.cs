using System;
using System.Windows.Forms;

namespace SuperMart_Pro.View.Expense
{
    public partial class ViewAllExpenseGUI : Form
    {
        public ViewAllExpenseGUI()
        {
            InitializeComponent();
        }

        private void ViewAllExpenseGUI_Load(object sender, EventArgs e)
        {
            SetupGrid();
            LoadData();
        }

        private void SetupGrid()
        {
            ExpensedataGridView.AutoGenerateColumns = false;
            ExpensedataGridView.Columns.Clear();

            ExpensedataGridView.Columns.Add(new DataGridViewTextBoxColumn { Name = "ExpenseID",      HeaderText = "Expense ID",      DataPropertyName = "ExpenseID",      Width = 120 });
            ExpensedataGridView.Columns.Add(new DataGridViewTextBoxColumn { Name = "Description",    HeaderText = "Description",     DataPropertyName = "Description",    Width = 220 });
            ExpensedataGridView.Columns.Add(new DataGridViewTextBoxColumn { Name = "ExpenseType",    HeaderText = "Type",            DataPropertyName = "ExpenseType",    Width = 130 });
            ExpensedataGridView.Columns.Add(new DataGridViewTextBoxColumn { Name = "Amount",         HeaderText = "Amount",          DataPropertyName = "Amount",         Width = 110 });
            ExpensedataGridView.Columns.Add(new DataGridViewTextBoxColumn { Name = "Date",           HeaderText = "Date",            DataPropertyName = "Date",           Width = 110 });
            ExpensedataGridView.Columns.Add(new DataGridViewTextBoxColumn { Name = "PaymentMethod",  HeaderText = "Payment Method",  DataPropertyName = "PaymentMethod",  Width = 140 });
            ExpensedataGridView.Columns.Add(new DataGridViewTextBoxColumn { Name = "BranchID",       HeaderText = "Branch ID",       DataPropertyName = "BranchID",       Width = 110 });
            ExpensedataGridView.Columns.Add(new DataGridViewTextBoxColumn { Name = "ApprovedBy",     HeaderText = "Approved By",     DataPropertyName = "ApprovedBy",     Width = 120 });
            ExpensedataGridView.Columns.Add(new DataGridViewTextBoxColumn { Name = "Notes",          HeaderText = "Notes",           DataPropertyName = "Notes",          Width = 180 });
            ExpensedataGridView.Columns.Add(new DataGridViewTextBoxColumn { Name = "CreatedAt",      HeaderText = "Created At",      DataPropertyName = "CreatedAt",      Width = 150 });
            ExpensedataGridView.Columns.Add(new DataGridViewTextBoxColumn { Name = "CreatedBy",      HeaderText = "Created By",      DataPropertyName = "CreatedBy",      Width = 120 });

            // Format Amount column to show 2 decimal places
            ExpensedataGridView.Columns["Amount"]!.DefaultCellStyle.Format = "N2";
            ExpensedataGridView.Columns["Amount"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // Format Date column
            ExpensedataGridView.Columns["Date"]!.DefaultCellStyle.Format = "yyyy-MM-dd";
        }

        private void LoadData()
        {
            // TODO: replace with controller/service call
            ExpensedataGridView.DataSource = null;
            TotalRecordslabel.Text = "Total Records: 0";
        }

        private void Searchbutton_Click(object sender, EventArgs e)
        {
            string keyword = SearchtextBox.Text.Trim();
            // TODO: filter grid by keyword via controller/service
            MessageBox.Show($"Search for '{keyword}' not yet implemented.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Refreshbutton_Click(object sender, EventArgs e)
        {
            SearchtextBox.Clear();
            ExpenseTypeFiltercomboBox.SelectedIndex = -1;
            FromDatedatePicker.Value = DateTime.Today.AddMonths(-1);
            ToDatedatePicker.Value = DateTime.Today;
            LoadData();
        }

        private void FilterbyDatebutton_Click(object sender, EventArgs e)
        {
            if (FromDatedatePicker.Value.Date > ToDatedatePicker.Value.Date)
            {
                MessageBox.Show("'From' date cannot be later than 'To' date.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // TODO: filter by date range via controller/service
            MessageBox.Show("Date filter not yet implemented.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Closebutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ExpensedataGridView_SelectionChanged(object sender, EventArgs e)
        {
            // Optional: show selected row details
        }
    }
}
