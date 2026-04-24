using SuperMart_Pro.Models;
using System;   
using System.Windows.Forms;

namespace SuperMart_Pro.View.Product
{
    public partial class AddProductGUI : Form
    {
        public AddProductGUI()
        {
            InitializeComponent();
        }

        private void BrowsePhotobutton_Click(object sender, EventArgs e)
        {
            using var dlg = new OpenFileDialog();
            dlg.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (dlg.ShowDialog() == DialogResult.OK)
                PhotopictureBox.Image = System.Drawing.Image.FromFile(dlg.FileName);
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            var product = new Models.Product(
                productID: ProductIDtextBox.Text.Trim(),
                productName: ProductNametextBox.Text.Trim(),
                brand: BrandtextBox.Text.Trim(),
                photo: Array.Empty<byte>(),
                productCategory: ProductCategorytextBox.Text.Trim(),
                barcode: BarcodetextBox.Text.Trim(),
                sku: SKUtextBox.Text.Trim(),
                unit: UnittextBox.Text.Trim(),
                expiryDate: ExpiryDatedatePicker.Value,
                stockQuantity: decimal.TryParse(StockQuantitytextBox.Text, out var sq) ? sq : 0,
                weight: decimal.TryParse(WeighttextBox.Text, out var wt) ? wt : 0,
                reorderLevel: decimal.TryParse(ReorderLeveltextBox.Text, out var rl) ? rl : 0,
                isExpirable: IsExpirablecheckBox.Checked,
                supplierID: SupplierIDtextBox.Text.Trim(),
                buyingPrice: decimal.TryParse(BuyingPricetextBox.Text, out var bp) ? bp : 0,
                sellingPrice: decimal.TryParse(SellingPricetextBox.Text, out var sp) ? sp : 0,
                discount: decimal.TryParse(DiscounttextBox.Text, out var disc) ? disc : 0,
                tax: decimal.TryParse(TaxtextBox.Text, out var tax) ? tax : 0,
                isActive: IsActivecheckBox.Checked,
                returnable: ReturnablecheckBox.Checked,
                createdAt: DateTime.Now,
                createdBy: Environment.UserName,
                updatedAt: DateTime.Now,
                updatedBy: Environment.UserName,
                deletedAt: null,
                deletedBy: string.Empty
            );

            // TODO: pass product to controller/service layer
            MessageBox.Show("Product saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearFields();
        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(ProductIDtextBox.Text))
            {
                MessageBox.Show("Product ID is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ProductIDtextBox.Focus(); return false;
            }
            if (string.IsNullOrWhiteSpace(ProductNametextBox.Text))
            {
                MessageBox.Show("Product Name is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ProductNametextBox.Focus(); return false;
            }
            if (string.IsNullOrWhiteSpace(BarcodetextBox.Text))
            {
                MessageBox.Show("Barcode is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                BarcodetextBox.Focus(); return false;
            }
            if (string.IsNullOrWhiteSpace(SKUtextBox.Text))
            {
                MessageBox.Show("SKU is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SKUtextBox.Focus(); return false;
            }
            if (string.IsNullOrWhiteSpace(UnittextBox.Text))
            {
                MessageBox.Show("Unit is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                UnittextBox.Focus(); return false;
            }
            if (string.IsNullOrWhiteSpace(SupplierIDtextBox.Text))
            {
                MessageBox.Show("Supplier ID is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SupplierIDtextBox.Focus(); return false;
            }
            if (string.IsNullOrWhiteSpace(BuyingPricetextBox.Text) || !decimal.TryParse(BuyingPricetextBox.Text, out var bp) || bp < 0)
            {
                MessageBox.Show("Buying Price must be a valid non-negative number.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                BuyingPricetextBox.Focus(); return false;
            }
            if (string.IsNullOrWhiteSpace(SellingPricetextBox.Text) || !decimal.TryParse(SellingPricetextBox.Text, out var sp) || sp <= 0)
            {
                MessageBox.Show("Selling Price must be a valid positive number.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SellingPricetextBox.Focus(); return false;
            }
            return true;
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
            ProductIDtextBox.Focus();
        }
    }
}
