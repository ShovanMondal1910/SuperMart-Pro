using System;
using System.Windows.Forms;

namespace SuperMart_Pro.View.Product
{
    public partial class ViewAllProductGUI : Form
    {
        public ViewAllProductGUI()
        {
            InitializeComponent();
        }

        private void ViewAllProductGUI_Load(object sender, EventArgs e)
        {
            SetupGrid();
            LoadData();
        }

        private void SetupGrid()
        {
            ProductdataGridView.AutoGenerateColumns = false;
            ProductdataGridView.Columns.Clear();

            ProductdataGridView.Columns.Add(new DataGridViewTextBoxColumn  { Name = "ProductID",        HeaderText = "Product ID",       DataPropertyName = "ProductID",        FillWeight = 80  });
            ProductdataGridView.Columns.Add(new DataGridViewTextBoxColumn  { Name = "ProductName",      HeaderText = "Product Name",     DataPropertyName = "ProductName",      FillWeight = 130 });
            ProductdataGridView.Columns.Add(new DataGridViewTextBoxColumn  { Name = "Brand",            HeaderText = "Brand",            DataPropertyName = "Brand",            FillWeight = 90  });
            ProductdataGridView.Columns.Add(new DataGridViewTextBoxColumn  { Name = "ProductType",      HeaderText = "Type",             DataPropertyName = "ProductType",      FillWeight = 75  });
            ProductdataGridView.Columns.Add(new DataGridViewTextBoxColumn  { Name = "ProductCategory",  HeaderText = "Category",         DataPropertyName = "ProductCategory",  FillWeight = 90  });
            ProductdataGridView.Columns.Add(new DataGridViewTextBoxColumn  { Name = "Barcode",          HeaderText = "Barcode",          DataPropertyName = "Barcode",          FillWeight = 95  });
            ProductdataGridView.Columns.Add(new DataGridViewTextBoxColumn  { Name = "SKU",              HeaderText = "SKU",              DataPropertyName = "SKU",              FillWeight = 75  });
            ProductdataGridView.Columns.Add(new DataGridViewTextBoxColumn  { Name = "Unit",             HeaderText = "Unit",             DataPropertyName = "Unit",             FillWeight = 50  });
            ProductdataGridView.Columns.Add(new DataGridViewTextBoxColumn  { Name = "ExpiryDate",       HeaderText = "Expiry Date",      DataPropertyName = "ExpiryDate",       FillWeight = 80  });
            ProductdataGridView.Columns.Add(new DataGridViewTextBoxColumn  { Name = "StockQuantity",    HeaderText = "Stock Qty",        DataPropertyName = "StockQuantity",    FillWeight = 65  });
            ProductdataGridView.Columns.Add(new DataGridViewTextBoxColumn  { Name = "Weight",           HeaderText = "Weight",           DataPropertyName = "Weight",           FillWeight = 55  });
            // TotalSaleQuantity removed — 3NF: computed from SaleItems at service layer
            ProductdataGridView.Columns.Add(new DataGridViewTextBoxColumn  { Name = "ReorderLevel",     HeaderText = "Reorder Lvl",      DataPropertyName = "ReorderLevel",     FillWeight = 75  });
            // MinStockLevel removed — 3NF: duplicate of ReorderLevel
            ProductdataGridView.Columns.Add(new DataGridViewTextBoxColumn  { Name = "SupplierID",       HeaderText = "Supplier ID",      DataPropertyName = "SupplierID",       FillWeight = 80  });
            ProductdataGridView.Columns.Add(new DataGridViewTextBoxColumn  { Name = "BuyingPrice",      HeaderText = "Buy Price",        DataPropertyName = "BuyingPrice",      FillWeight = 70  });
            ProductdataGridView.Columns.Add(new DataGridViewTextBoxColumn  { Name = "SellingPrice",     HeaderText = "Sell Price",       DataPropertyName = "SellingPrice",     FillWeight = 70  });
            ProductdataGridView.Columns.Add(new DataGridViewTextBoxColumn  { Name = "Discount",         HeaderText = "Discount",         DataPropertyName = "Discount",         FillWeight = 60  });
            ProductdataGridView.Columns.Add(new DataGridViewTextBoxColumn  { Name = "Tax",              HeaderText = "Tax",              DataPropertyName = "Tax",              FillWeight = 45  });
            ProductdataGridView.Columns.Add(new DataGridViewTextBoxColumn  { Name = "MRP",              HeaderText = "MRP",              DataPropertyName = "MRP",              FillWeight = 55  });
            ProductdataGridView.Columns.Add(new DataGridViewCheckBoxColumn { Name = "IsExpirable",      HeaderText = "Expirable",        DataPropertyName = "IsExpirable",      FillWeight = 60  });
            ProductdataGridView.Columns.Add(new DataGridViewCheckBoxColumn { Name = "IsActive",         HeaderText = "Active",           DataPropertyName = "IsActive",         FillWeight = 50  });
            ProductdataGridView.Columns.Add(new DataGridViewCheckBoxColumn { Name = "Returnable",       HeaderText = "Returnable",       DataPropertyName = "Returnable",       FillWeight = 65  });
        }

        private void LoadData()
        {
            // TODO: replace with controller/service call
            ProductdataGridView.DataSource = null;
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

        private void ProductdataGridView_SelectionChanged(object sender, EventArgs e)
        {
            // Optional: show selected row details
        }
    }
}
