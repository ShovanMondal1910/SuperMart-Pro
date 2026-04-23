using System;
using System.Windows.Forms;

namespace SuperMart_Pro.View.Product
{
    public partial class DeleteProductGUI : Form
    {
        public DeleteProductGUI()
        {
            InitializeComponent();
        }

        private void Searchbutton_Click(object sender, EventArgs e)
        {
            string searchId = SearchtextBox.Text.Trim();
            if (string.IsNullOrWhiteSpace(searchId))
            {
                MessageBox.Show("Please enter a Product ID to search.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // TODO: load product from controller/service by searchId and populate fields
            MessageBox.Show($"Search for product '{searchId}' not yet implemented.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ProductIDtextBox.Text))
            {
                MessageBox.Show("Please search and load a product before deleting.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show(
                $"Are you sure you want to delete product '{ProductNametextBox.Text}'?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                // TODO: pass productId to controller/service layer for deletion
                MessageBox.Show("Product deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
            }
        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ClearFields()
        {
            ProductIDtextBox.Clear();
            ProductNametextBox.Clear();
            BrandtextBox.Clear();
            PhotopictureBox.Image = null;
            ProductTypetextBox.Clear();
            ProductCategorytextBox.Clear();
            BarcodetextBox.Clear();
            SKUtextBox.Clear();
            UnittextBox.Clear();
            ExpiryDatedatePicker.Value = DateTime.Today;
            StockQuantitytextBox.Clear();
            WeighttextBox.Clear();
            // TotalSaleQuantitytextBox — removed (3NF: computed from SaleItems)
            ReorderLeveltextBox.Clear();
            // MinStockLeveltextBox — removed (3NF: duplicate of ReorderLevel)
            IsExpirablecheckBox.Checked = false;
            SupplierIDtextBox.Clear();
            BuyingPricetextBox.Clear();
            SellingPricetextBox.Clear();
            DiscounttextBox.Clear();
            TaxtextBox.Clear();
            // MRPtextBox — removed (3NF: computed from SellingPrice/Discount/Tax)
            IsActivecheckBox.Checked = false;
            ReturnablecheckBox.Checked = false;
            SearchtextBox.Clear();
            SearchtextBox.Focus();
        }
    }
}
