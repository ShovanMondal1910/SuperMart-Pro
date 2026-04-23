using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMart_Pro.Models
{
    public enum PaymentMethod
    {
        Cash = 1,
        Card = 2,
        MobilePay = 3,
        Mixed = 4
    }

    internal class Sale : AuditableEntity
    {
        private string _saleId = string.Empty;
        private DateTime _saleTime;
        private string _customerId = string.Empty;
        private string _userId = string.Empty;
        private string _branchID = string.Empty;
        private string _terminal = string.Empty;
        private decimal _discountAmount;
        private decimal _vatPercent;
        private decimal _amountPaid;
        private PaymentMethod _paymentMethod;
        private List<SaleItem> _saleItems = new List<SaleItem>();

        public Sale() { }

        public Sale(string saleId, DateTime saleTime,
            string customerId, string userId, string branchID, string terminal,
            decimal discountAmount, decimal vatPercent, decimal amountPaid,
            PaymentMethod paymentMethod,
            DateTime createdAt, string createdBy, DateTime updatedAt, string updatedBy, DateTime? deletedAt, string deletedBy)
            : base(createdAt, createdBy, updatedAt, updatedBy, deletedAt, deletedBy)
        {
            _saleId = saleId;
            _saleTime = saleTime;
            _customerId = customerId;
            _userId = userId;
            _branchID = branchID;
            _terminal = terminal;
            _discountAmount = discountAmount;
            _vatPercent = vatPercent;
            _amountPaid = amountPaid;
            _paymentMethod = paymentMethod;
        }

        public string SaleId
        {
            get { return _saleId; }
            set { _saleId = value; }
        }
        public DateTime SaleTime
        {
            get { return _saleTime; }
            set { _saleTime = value; }
        }
        public string CustomerId
        {
            get { return _customerId; }
            set { _customerId = value; }
        }
        public string UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }
        public string BranchID
        {
            get { return _branchID; }
            set { _branchID = value; }
        }
        public string Terminal
        {
            get { return _terminal; }
            set { _terminal = value; }
        }

        // Sum of all item totals before discount/tax
        public decimal SubTotal => _saleItems?.Sum(i => i.TotalPrice) ?? 0m;

        public decimal DiscountAmount
        {
            get { return _discountAmount; }
            set { _discountAmount = value; }
        }

        // VAT stored as a percentage (e.g. 15 means 15%)
        public decimal VatPercent
        {
            get { return _vatPercent; }
            set { _vatPercent = value; }
        }

        // Computed VAT amount from SubTotal after discount
        public decimal VatAmount => (SubTotal - _discountAmount) * (_vatPercent / 100m);

        public decimal TotalAmount => SubTotal - _discountAmount + VatAmount;

        public decimal AmountPaid
        {
            get { return _amountPaid; }
            set { _amountPaid = value; }
        }

        // Change to return to customer
        public decimal ChangeGiven => _amountPaid - TotalAmount;

        public PaymentMethod PaymentMethod
        {
            get { return _paymentMethod; }
            set { _paymentMethod = value; }
        }
        public List<SaleItem> SaleItems
        {
            get { return _saleItems; }
            set { _saleItems = value; }
        }
    }
}
