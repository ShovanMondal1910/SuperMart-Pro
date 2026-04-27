using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMart_Pro.Models
{
    public enum PurchaseStatus
    {
        Pending = 1,
        Completed = 2,
        Cancelled = 3
    }
    internal class Purchase
    {
        private string _purchaseID = string.Empty;
        private string _supplierID = string.Empty;
        private Supplier _supplier = null!;
        private DateTime _orderDate;
        private DateTime? _estimatedDeliveryDate;
        private PurchaseStatus _status;
        private decimal _paidAmount;
        private List<PurchaseItem> _purchaseItems;

        public Purchase()
        {
            _purchaseItems = new List<PurchaseItem>();
        }

        public Purchase(string purchaseID, string supplierID, DateTime orderDate,
            DateTime? estimatedDeliveryDate, PurchaseStatus status, decimal paidAmount)
        {
            _purchaseID = purchaseID;
            _supplierID = supplierID;
            _orderDate = orderDate;
            _estimatedDeliveryDate = estimatedDeliveryDate;
            _status = status;
            _paidAmount = paidAmount;
            _purchaseItems = new List<PurchaseItem>();
        }

        public string PurchaseID
        {
            get { return _purchaseID; }
            set { _purchaseID = value; }
        }
        public string SupplierID
        {
            get { return _supplierID; }
            set { _supplierID = value; }
        }
        public Supplier Supplier
        {
            get { return _supplier; }
            set { _supplier = value; }
        }
        public DateTime OrderDate
        {
            get { return _orderDate; }
            set { _orderDate = value; }
        }
        public DateTime? EstimatedDeliveryDate
        {
            get { return _estimatedDeliveryDate; }
            set { _estimatedDeliveryDate = value; }
        }
        public PurchaseStatus Status
        {
            get { return _status; }
            set { _status = value; }
        }
        public decimal TotalAmount => _purchaseItems?.Sum(i => i.TotalPrice) ?? 0m;

        public decimal PaidAmount
        {
            get { return _paidAmount; }
            set { _paidAmount = value; }
        }
        public decimal DueAmount => TotalAmount - _paidAmount;
        public List<PurchaseItem> PurchaseItems
        {
            get { return _purchaseItems; }
            set { _purchaseItems = value; }
        }
    }
}
