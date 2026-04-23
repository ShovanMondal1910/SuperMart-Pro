using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMart_Pro.Models
{
    internal class PurchaseItem
    {
        private string _purchaseItemID = string.Empty;
        private string _purchaseID = string.Empty;
        private string _productID = string.Empty;
        private Product? _product;
        private decimal _quantity;
        private decimal _unitPrice;

        public PurchaseItem() { }

        public PurchaseItem(string purchaseItemID, string purchaseID, string productID, Product product, decimal quantity, decimal unitPrice)
        {
            _purchaseItemID = purchaseItemID;
            _purchaseID = purchaseID;
            _productID = productID;
            _product = product;
            _quantity = quantity;
            _unitPrice = unitPrice;
        }

        public string PurchaseItemID
        {
            get { return _purchaseItemID; }
            set { _purchaseItemID = value; }
        }
        public string PurchaseID
        {
            get { return _purchaseID; }
            set { _purchaseID = value; }
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
        //TotalPrice is now auto-calculated (Quantity * UnitPrice)
        public decimal TotalPrice => _quantity * _unitPrice;
    }
}
