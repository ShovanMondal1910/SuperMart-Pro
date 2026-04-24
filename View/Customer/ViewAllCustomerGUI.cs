using System;
using System.Windows.Forms;

namespace SuperMart_Pro.View.Customer
{
    public partial class ViewAllCustomerGUI : Form
    {
        public ViewAllCustomerGUI()
        {
            InitializeComponent();
        }

        private void ViewAllCustomerGUI_Load(object sender, EventArgs e)
        {
            SetupGrid();
            LoadData();
        }

        private void SetupGrid()
        {
            CustomerdataGridView.AutoGenerateColumns = false;
            CustomerdataGridView.Columns.Clear();

            CustomerdataGridView.Columns.Add(new DataGridViewTextBoxColumn  { Name = "CustomerID",       HeaderText = "Customer ID",    DataPropertyName = "CustomerID",      Width = 120 });
            CustomerdataGridView.Columns.Add(new DataGridViewTextBoxColumn  { Name = "UserID",           HeaderText = "User ID",        DataPropertyName = "UserID",          Width = 110 });
            CustomerdataGridView.Columns.Add(new DataGridViewTextBoxColumn  { Name = "FullName",         HeaderText = "Full Name",      DataPropertyName = "FullName",        Width = 180 });
            CustomerdataGridView.Columns.Add(new DataGridViewTextBoxColumn  { Name = "Gender",           HeaderText = "Gender",         DataPropertyName = "Gender",          Width = 80  });
            CustomerdataGridView.Columns.Add(new DataGridViewTextBoxColumn  { Name = "PhoneNumber",      HeaderText = "Phone",          DataPropertyName = "PhoneNumber",     Width = 130 });
            CustomerdataGridView.Columns.Add(new DataGridViewTextBoxColumn  { Name = "Email",            HeaderText = "Email",          DataPropertyName = "Email",           Width = 200 });
            CustomerdataGridView.Columns.Add(new DataGridViewTextBoxColumn  { Name = "BranchID",         HeaderText = "Branch ID",      DataPropertyName = "BranchID",        Width = 110 });
            CustomerdataGridView.Columns.Add(new DataGridViewTextBoxColumn  { Name = "Type",             HeaderText = "Customer Type",  DataPropertyName = "Type",            Width = 130 });
            CustomerdataGridView.Columns.Add(new DataGridViewTextBoxColumn  { Name = "Status",           HeaderText = "Status",         DataPropertyName = "Status",          Width = 100 });
            CustomerdataGridView.Columns.Add(new DataGridViewTextBoxColumn  { Name = "LoyaltyPoints",    HeaderText = "Loyalty Pts",    DataPropertyName = "LoyaltyPoints",   Width = 100 });
            CustomerdataGridView.Columns.Add(new DataGridViewTextBoxColumn  { Name = "TotalSpent",       HeaderText = "Total Spent",    DataPropertyName = "TotalSpent",      Width = 110 });
            CustomerdataGridView.Columns.Add(new DataGridViewTextBoxColumn  { Name = "DueAmount",        HeaderText = "Due Amount",     DataPropertyName = "DueAmount",       Width = 110 });
            CustomerdataGridView.Columns.Add(new DataGridViewCheckBoxColumn { Name = "IsActive",         HeaderText = "Active",         DataPropertyName = "IsActive",        Width = 70  });
            CustomerdataGridView.Columns.Add(new DataGridViewTextBoxColumn  { Name = "Role",             HeaderText = "Role",           DataPropertyName = "Role",            Width = 100 });
            CustomerdataGridView.Columns.Add(new DataGridViewTextBoxColumn  { Name = "LastLogin",        HeaderText = "Last Login",     DataPropertyName = "LastLogin",       Width = 150 });
            CustomerdataGridView.Columns.Add(new DataGridViewTextBoxColumn  { Name = "LastLogout",       HeaderText = "Last Logout",    DataPropertyName = "LastLogout",      Width = 150 });
            CustomerdataGridView.Columns.Add(new DataGridViewTextBoxColumn  { Name = "LastPurchaseDate", HeaderText = "Last Purchase",  DataPropertyName = "LastPurchaseDate",Width = 150 });
            CustomerdataGridView.Columns.Add(new DataGridViewTextBoxColumn  { Name = "CreatedAt",        HeaderText = "Created At",     DataPropertyName = "CreatedAt",       Width = 150 });
        }

        private void LoadData()
        {
            // TODO: replace with controller/service call
            CustomerdataGridView.DataSource = null;
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

        private void CustomerdataGridView_SelectionChanged(object sender, EventArgs e)
        {
            // Optional: show selected row details
        }
    }
}
