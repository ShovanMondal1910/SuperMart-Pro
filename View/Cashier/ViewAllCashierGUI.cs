using System;
using System.Windows.Forms;

namespace SuperMart_Pro.View.Cashier
{
    public partial class ViewAllCashierGUI : Form
    {
        public ViewAllCashierGUI()
        {
            InitializeComponent();
        }

        private void ViewAllCashierGUI_Load(object sender, EventArgs e)
        {
            SetupGrid();
            LoadData();
        }

        private void SetupGrid()
        {
            CashierdataGridView.AutoGenerateColumns = false;
            CashierdataGridView.Columns.Clear();

            CashierdataGridView.Columns.Add(new DataGridViewTextBoxColumn  { Name = "CashierID",   HeaderText = "Cashier ID",   DataPropertyName = "CashierID",   Width = 120 });
            CashierdataGridView.Columns.Add(new DataGridViewTextBoxColumn  { Name = "UserID",      HeaderText = "User ID",      DataPropertyName = "UserID",      Width = 110 });
            CashierdataGridView.Columns.Add(new DataGridViewTextBoxColumn  { Name = "FullName",    HeaderText = "Full Name",    DataPropertyName = "FullName",    Width = 180 });
            CashierdataGridView.Columns.Add(new DataGridViewTextBoxColumn  { Name = "Gender",      HeaderText = "Gender",       DataPropertyName = "Gender",      Width = 80  });
            CashierdataGridView.Columns.Add(new DataGridViewTextBoxColumn  { Name = "PhoneNumber", HeaderText = "Phone",        DataPropertyName = "PhoneNumber", Width = 130 });
            CashierdataGridView.Columns.Add(new DataGridViewTextBoxColumn  { Name = "Email",       HeaderText = "Email",        DataPropertyName = "Email",       Width = 200 });
            CashierdataGridView.Columns.Add(new DataGridViewTextBoxColumn  { Name = "Username",    HeaderText = "Username",     DataPropertyName = "Username",    Width = 130 });
            CashierdataGridView.Columns.Add(new DataGridViewTextBoxColumn  { Name = "BranchID",    HeaderText = "Branch ID",    DataPropertyName = "BranchID",    Width = 110 });
            CashierdataGridView.Columns.Add(new DataGridViewTextBoxColumn  { Name = "Type",        HeaderText = "Cashier Type", DataPropertyName = "Type",        Width = 130 });
            CashierdataGridView.Columns.Add(new DataGridViewCheckBoxColumn { Name = "IsActive",    HeaderText = "Active",       DataPropertyName = "IsActive",    Width = 70  });
            CashierdataGridView.Columns.Add(new DataGridViewTextBoxColumn  { Name = "Role",        HeaderText = "Role",         DataPropertyName = "Role",        Width = 100 });
            CashierdataGridView.Columns.Add(new DataGridViewTextBoxColumn  { Name = "LastLogin",   HeaderText = "Last Login",   DataPropertyName = "LastLogin",   Width = 150 });
            CashierdataGridView.Columns.Add(new DataGridViewTextBoxColumn  { Name = "LastLogout",  HeaderText = "Last Logout",  DataPropertyName = "LastLogout",  Width = 150 });
            CashierdataGridView.Columns.Add(new DataGridViewTextBoxColumn  { Name = "CreatedAt",   HeaderText = "Created At",   DataPropertyName = "CreatedAt",   Width = 150 });
        }

        private void LoadData()
        {
            // TODO: replace with controller/service call
            CashierdataGridView.DataSource = null;
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
            LoadData();
        }

        private void Closebutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CashierdataGridView_SelectionChanged(object sender, EventArgs e)
        {
            // Optional: show selected row details
        }
    }
}
