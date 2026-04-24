using System;
using System.Windows.Forms;

namespace SuperMart_Pro.View.Admin
{
    public partial class ViewAllAdminGUI : Form
    {
        public ViewAllAdminGUI()
        {
            InitializeComponent();
        }

        private void ViewAllAdminGUI_Load(object sender, EventArgs e)
        {
            SetupGrid();
            LoadData();
        }

        private void SetupGrid()
        {
            AdmindataGridView.AutoGenerateColumns = false;
            AdmindataGridView.Columns.Clear();

            AdmindataGridView.Columns.Add(new DataGridViewTextBoxColumn  { Name = "AdminID",           HeaderText = "Admin ID",        DataPropertyName = "AdminID",        Width = 110 });
            AdmindataGridView.Columns.Add(new DataGridViewTextBoxColumn  { Name = "UserID",            HeaderText = "User ID",         DataPropertyName = "UserID",         Width = 110 });
            AdmindataGridView.Columns.Add(new DataGridViewTextBoxColumn  { Name = "FullName",          HeaderText = "Full Name",       DataPropertyName = "FullName",       Width = 180 });
            AdmindataGridView.Columns.Add(new DataGridViewTextBoxColumn  { Name = "Gender",            HeaderText = "Gender",          DataPropertyName = "Gender",         Width = 80  });
            AdmindataGridView.Columns.Add(new DataGridViewTextBoxColumn  { Name = "PhoneNumber",       HeaderText = "Phone",           DataPropertyName = "PhoneNumber",    Width = 130 });
            AdmindataGridView.Columns.Add(new DataGridViewTextBoxColumn  { Name = "Email",             HeaderText = "Email",           DataPropertyName = "Email",          Width = 200 });
            AdmindataGridView.Columns.Add(new DataGridViewTextBoxColumn  { Name = "Username",          HeaderText = "Username",        DataPropertyName = "Username",       Width = 130 });
            AdmindataGridView.Columns.Add(new DataGridViewTextBoxColumn  { Name = "BranchID",          HeaderText = "Branch ID",       DataPropertyName = "BranchID",       Width = 110 });
            AdmindataGridView.Columns.Add(new DataGridViewTextBoxColumn  { Name = "Type",              HeaderText = "Admin Type",      DataPropertyName = "Type",           Width = 120 });
            AdmindataGridView.Columns.Add(new DataGridViewCheckBoxColumn { Name = "IsActive",          HeaderText = "Active",          DataPropertyName = "IsActive",       Width = 70  });
            AdmindataGridView.Columns.Add(new DataGridViewTextBoxColumn  { Name = "Role",              HeaderText = "Role",            DataPropertyName = "Role",           Width = 100 });
            AdmindataGridView.Columns.Add(new DataGridViewTextBoxColumn  { Name = "LastLogin",         HeaderText = "Last Login",      DataPropertyName = "LastLogin",      Width = 150 });
            AdmindataGridView.Columns.Add(new DataGridViewTextBoxColumn  { Name = "LastLogout",        HeaderText = "Last Logout",     DataPropertyName = "LastLogout",     Width = 150 });
            AdmindataGridView.Columns.Add(new DataGridViewTextBoxColumn  { Name = "CreatedAt",         HeaderText = "Created At",      DataPropertyName = "CreatedAt",      Width = 150 });
        }

        private void LoadData()
        {
            // TODO: replace with controller/service call
            AdmindataGridView.DataSource = null;
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

        private void AdmindataGridView_SelectionChanged(object sender, EventArgs e)
        {
            // Optional: show selected row details
        }
    }
}
