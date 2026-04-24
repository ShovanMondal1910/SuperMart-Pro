using System;
using System.Windows.Forms;

namespace SuperMart_Pro.View.Manager
{
    public partial class ViewAllManagerGUI : Form
    {
        public ViewAllManagerGUI()
        {
            InitializeComponent();
        }

        private void ViewAllManagerGUI_Load(object sender, EventArgs e)
        {
            SetupGrid();
            LoadData();
        }

        private void SetupGrid()
        {
            ManagerdataGridView.AutoGenerateColumns = false;
            ManagerdataGridView.Columns.Clear();

            ManagerdataGridView.Columns.Add(new DataGridViewTextBoxColumn  { Name = "ManagerID",   HeaderText = "Manager ID",   DataPropertyName = "ManagerID",   Width = 120 });
            ManagerdataGridView.Columns.Add(new DataGridViewTextBoxColumn  { Name = "UserID",      HeaderText = "User ID",      DataPropertyName = "UserID",      Width = 110 });
            ManagerdataGridView.Columns.Add(new DataGridViewTextBoxColumn  { Name = "FullName",    HeaderText = "Full Name",    DataPropertyName = "FullName",    Width = 180 });
            ManagerdataGridView.Columns.Add(new DataGridViewTextBoxColumn  { Name = "Gender",      HeaderText = "Gender",       DataPropertyName = "Gender",      Width = 80  });
            ManagerdataGridView.Columns.Add(new DataGridViewTextBoxColumn  { Name = "PhoneNumber", HeaderText = "Phone",        DataPropertyName = "PhoneNumber", Width = 130 });
            ManagerdataGridView.Columns.Add(new DataGridViewTextBoxColumn  { Name = "Email",       HeaderText = "Email",        DataPropertyName = "Email",       Width = 200 });
            ManagerdataGridView.Columns.Add(new DataGridViewTextBoxColumn  { Name = "Username",    HeaderText = "Username",     DataPropertyName = "Username",    Width = 130 });
            ManagerdataGridView.Columns.Add(new DataGridViewTextBoxColumn  { Name = "BranchID",    HeaderText = "Branch ID",    DataPropertyName = "BranchID",    Width = 110 });
            ManagerdataGridView.Columns.Add(new DataGridViewTextBoxColumn  { Name = "Type",        HeaderText = "Manager Type", DataPropertyName = "Type",        Width = 140 });
            ManagerdataGridView.Columns.Add(new DataGridViewCheckBoxColumn { Name = "IsActive",    HeaderText = "Active",       DataPropertyName = "IsActive",    Width = 70  });
            ManagerdataGridView.Columns.Add(new DataGridViewTextBoxColumn  { Name = "Role",        HeaderText = "Role",         DataPropertyName = "Role",        Width = 100 });
            ManagerdataGridView.Columns.Add(new DataGridViewTextBoxColumn  { Name = "LastLogin",   HeaderText = "Last Login",   DataPropertyName = "LastLogin",   Width = 150 });
            ManagerdataGridView.Columns.Add(new DataGridViewTextBoxColumn  { Name = "LastLogout",  HeaderText = "Last Logout",  DataPropertyName = "LastLogout",  Width = 150 });
            ManagerdataGridView.Columns.Add(new DataGridViewTextBoxColumn  { Name = "CreatedAt",   HeaderText = "Created At",   DataPropertyName = "CreatedAt",   Width = 150 });
        }

        private void LoadData()
        {
            // TODO: replace with controller/service call
            ManagerdataGridView.DataSource = null;
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

        private void ManagerdataGridView_SelectionChanged(object sender, EventArgs e)
        {
            // Optional: show selected row details
        }
    }
}
