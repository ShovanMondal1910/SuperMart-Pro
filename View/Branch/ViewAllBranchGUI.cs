using System;
using System.Windows.Forms;

namespace SuperMart_Pro.View.Branch
{
    public partial class ViewAllBranchGUI : Form
    {
        public ViewAllBranchGUI()
        {
            InitializeComponent();
        }

        private void ViewAllBranchGUI_Load(object sender, EventArgs e)
        {
            SetupGrid();
            LoadData();
        }

        private void SetupGrid()
        {
            BranchdataGridView.AutoGenerateColumns = false;
            BranchdataGridView.Columns.Clear();

            BranchdataGridView.Columns.Add(new DataGridViewTextBoxColumn  { Name = "BranchID",      HeaderText = "Branch ID",      DataPropertyName = "BranchID",      Width = 110 });
            BranchdataGridView.Columns.Add(new DataGridViewTextBoxColumn  { Name = "BranchName",    HeaderText = "Branch Name",    DataPropertyName = "BranchName",    Width = 160 });
            BranchdataGridView.Columns.Add(new DataGridViewTextBoxColumn  { Name = "BranchType",    HeaderText = "Type",           DataPropertyName = "BranchType",    Width = 100 });
            BranchdataGridView.Columns.Add(new DataGridViewTextBoxColumn  { Name = "BranchAddress", HeaderText = "Address",        DataPropertyName = "BranchAddress", Width = 200 });
            BranchdataGridView.Columns.Add(new DataGridViewTextBoxColumn  { Name = "BranchZip",     HeaderText = "Zip",            DataPropertyName = "BranchZip",     Width = 80  });
            BranchdataGridView.Columns.Add(new DataGridViewTextBoxColumn  { Name = "BranchPhone",   HeaderText = "Phone",          DataPropertyName = "BranchPhone",   Width = 130 });
            BranchdataGridView.Columns.Add(new DataGridViewTextBoxColumn  { Name = "BranchEmail",   HeaderText = "Email",          DataPropertyName = "BranchEmail",   Width = 180 });
            BranchdataGridView.Columns.Add(new DataGridViewTextBoxColumn  { Name = "ManagerID",     HeaderText = "Manager ID",     DataPropertyName = "ManagerID",     Width = 110 });
            BranchdataGridView.Columns.Add(new DataGridViewCheckBoxColumn { Name = "IsActive",      HeaderText = "Active",         DataPropertyName = "IsActive",      Width = 70  });
        }

        private void LoadData()
        {
            // TODO: replace with controller/service call
            BranchdataGridView.DataSource = null;
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

        private void BranchdataGridView_SelectionChanged(object sender, EventArgs e)
        {
            // Optional: show selected row details
        }
    }
}
