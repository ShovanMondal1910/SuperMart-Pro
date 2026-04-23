using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMart_Pro.Models
{
    internal class SaleItem
    {
        private string _saleItemID = string.Empty;
        private string _saleID = string.Empty;
        private string _productID = string.Empty;
        private Product? _product = null;
        private decimal _quantity;
        private decimal _unitPrice;
        private decimal _discountAmount;

        public SaleItem() { }

        public SaleItem(string saleItemID, string saleID, string productID, Product product,
            decimal quantity, decimal unitPrice, decimal discountAmount = 0)
        {
            _saleItemID = saleItemID;
            _saleID = saleID;
            _productID = productID;
            _product = product;
            _quantity = quantity;
            _unitPrice = unitPrice;
            _discountAmount = discountAmount;
        }

        public string SaleItemID
        {
            get { return _saleItemID; }
            set { _saleItemID = value; }
        }
        public string SaleID
        {
            get { return _saleID; }
            set { _saleID = value; }
        }
        public string ProductID
        {
            get { return _productID; }
            set { _productID = value; }
        }
        public Product? Product
        {
            get { return _product; }
            set { _product = value; }
        }
        public decimal Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }
        public decimal UnitPrice
        {
            get { return _unitPrice; }
            set { _unitPrice = value; }
        }

        // Discount amount snapshotted at time of sale
        public decimal DiscountAmount
        {
            get { return _discountAmount; }
            set { _discountAmount = value; }
        }

        // Net total: (UnitPrice * Quantity) - Discount
        public decimal TotalPrice => (_unitPrice * _quantity) - _discountAmount;
    }
}
