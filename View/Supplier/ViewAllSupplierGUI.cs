using System;
using System.Windows.Forms;

namespace SuperMart_Pro.View.Supplier
{
    public partial class ViewAllSupplierGUI : Form
    {
        public ViewAllSupplierGUI()
        {
            InitializeComponent();
        }

        private void ViewAllSupplierGUI_Load(object sender, EventArgs e)
        {
            SetupGrid();
            LoadData();
        }

        private void SetupGrid()
        {
            SupplierdataGridView.AutoGenerateColumns = false;
            SupplierdataGridView.Columns.Clear();

            SupplierdataGridView.Columns.Add(new DataGridViewTextBoxColumn  { Name = "SupplierId",           HeaderText = "Supplier ID",        DataPropertyName = "SupplierId",           FillWeight = 90  });
            SupplierdataGridView.Columns.Add(new DataGridViewTextBoxColumn  { Name = "SupplierName",         HeaderText = "Supplier Name",      DataPropertyName = "SupplierName",         FillWeight = 130 });
            SupplierdataGridView.Columns.Add(new DataGridViewTextBoxColumn  { Name = "CompanyName",          HeaderText = "Company",            DataPropertyName = "CompanyName",          FillWeight = 120 });
            SupplierdataGridView.Columns.Add(new DataGridViewTextBoxColumn  { Name = "ContactNumber",        HeaderText = "Contact",            DataPropertyName = "ContactNumber",        FillWeight = 100 });
            SupplierdataGridView.Columns.Add(new DataGridViewTextBoxColumn  { Name = "Email",                HeaderText = "Email",              DataPropertyName = "Email",                FillWeight = 140 });
            SupplierdataGridView.Columns.Add(new DataGridViewTextBoxColumn  { Name = "Address",              HeaderText = "Address",            DataPropertyName = "Address",              FillWeight = 160 });
            SupplierdataGridView.Columns.Add(new DataGridViewTextBoxColumn  { Name = "Country",              HeaderText = "Country",            DataPropertyName = "Country",              FillWeight = 85  });
            SupplierdataGridView.Columns.Add(new DataGridViewTextBoxColumn  { Name = "Website",              HeaderText = "Website",            DataPropertyName = "Website",              FillWeight = 125 });
            // TotalPurchaseAmount removed — 3NF: SUM(Purchase.TotalAmount) WHERE SupplierID
            // DueAmount removed — 3NF: SUM(Purchase.DueAmount) WHERE SupplierID
            SupplierdataGridView.Columns.Add(new DataGridViewCheckBoxColumn { Name = "IsActive",             HeaderText = "Active",             DataPropertyName = "IsActive",             FillWeight = 50  });
        }

        private void LoadData()
        {
            // TODO: replace with controller/service call
            SupplierdataGridView.DataSource = null;
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

        private void Closebutton_Click(object sender, EventArgs e) => this.Close();

        private void SupplierdataGridView_SelectionChanged(object sender, EventArgs e)
        {
            // Optional: show selected row details
        }
    }
}
