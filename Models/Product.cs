using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMart_Pro.Models
{
    internal class Product : AuditableEntity
    {
        private string _productID = string.Empty;
        private string _productName = string.Empty;
        private string _brand = string.Empty;
        private byte[] _photo = Array.Empty<byte>();
        private string _productCategory = string.Empty;
        private string _barcode = string.Empty;
        private string _sku = string.Empty;
        private string _unit = string.Empty;
        private DateTime _expiryDate;
        private decimal _stockQuantity;
        private decimal _weight;
        private decimal _reorderLevel;
        private bool _isExpirable;
        private string _supplierID = string.Empty;
        private Supplier? _supplier;
        private decimal _buyingPrice;
        private decimal _sellingPrice;
        private decimal _discount;
        private decimal _tax;
        private bool _isActive;
        private bool _returnable;

        public Product() { }

        public Product(string productID, string productName, string brand, byte[] photo, string productCategory,
                    string barcode, string sku, string unit, DateTime expiryDate, decimal stockQuantity, decimal weight,
                    decimal reorderLevel, bool isExpirable, string supplierID,
                    decimal buyingPrice, decimal sellingPrice, decimal discount, decimal tax,
                    bool isActive, bool returnable,
                    DateTime createdAt, string createdBy, DateTime updatedAt, string updatedBy, DateTime? deletedAt, string deletedBy)
                    : base(createdAt, createdBy, updatedAt, updatedBy, deletedAt, deletedBy)
        {
            _productID = productID;
            _productName = productName;
            _brand = brand;
            _photo = photo ?? Array.Empty<byte>();
            _productCategory = productCategory;
            _barcode = barcode;
            _sku = sku;
            _unit = unit;
            _expiryDate = expiryDate;
            _stockQuantity = stockQuantity;
            _weight = weight;
            _reorderLevel = reorderLevel;
            _isExpirable = isExpirable;
            _supplierID = supplierID;
            _buyingPrice = buyingPrice;
            _sellingPrice = sellingPrice;
            _discount = discount;
            _tax = tax;
            _isActive = isActive;
            _returnable = returnable;
        }

        public string ProductID
        {
            get { return _productID; }
            set { _productID = value; }
        }
        public string ProductName
        {
            get { return _productName; }
            set { _productName = value; }
        }
        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }
        public byte[] Photo
        {
            get { return _photo; }
            set { _photo = value; }
        }
        public string ProductCategory
        {
            get { return _productCategory; }
            set { _productCategory = value; }
        }
        public string Barcode
        {
            get { return _barcode; }
            set { _barcode = value; }
        }
        public string SKU
        {
            get { return _sku; }
            set { _sku = value; }
        }
        public string Unit
        {
            get { return _unit; }
            set { _unit = value; }
        }
        public DateTime ExpiryDate
        {
            get { return _expiryDate; }
            set { _expiryDate = value; }
        }
        public decimal StockQuantity
        {
            get { return _stockQuantity; }
            set { _stockQuantity = value; }
        }
        public decimal Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }
        public decimal ReorderLevel
        {
            get { return _reorderLevel; }
            set { _reorderLevel = value; }
        }
        public bool IsExpirable
        {
            get { return _isExpirable; }
            set { _isExpirable = value; }
        }
        public string SupplierID
        {
            get { return _supplierID; }
            set { _supplierID = value; }
        }
        public Supplier? Supplier
        {
            get { return _supplier; }
            set { _supplier = value; }
        }
        public decimal BuyingPrice
        {
            get { return _buyingPrice; }
            set { _buyingPrice = value; }
        }
        public decimal SellingPrice
        {
            get { return _sellingPrice; }
            set { _sellingPrice = value; }
        }
        public decimal Discount
        {
            get { return _discount; }
            set { _discount = value; }
        }
        public decimal Tax
        {
            get { return _tax; }
            set { _tax = value; }
        }
        //Calculated MRP = SellingPrice after Discount (%), then Tax (%) applied on top.
        //Formula: MRP = (SellingPrice - SellingPrice * Discount/100) * (1 + Tax/100)
        public decimal MRP
        {
            get
            {
                decimal priceAfterDiscount = _sellingPrice - (_sellingPrice * _discount / 100m);
                return priceAfterDiscount + (priceAfterDiscount * _tax / 100m);
            }
        }
        public bool IsActive
        {
            get { return _isActive; }
            set { _isActive = value; }
        }
        public bool Returnable
        {
            get { return _returnable; }
            set { _returnable = value; }
        }

        public void RecordSale(decimal quantity)
        {
            if (quantity <= 0)
            {
                return;
            }
            _stockQuantity -= quantity;
        }
    }
}
