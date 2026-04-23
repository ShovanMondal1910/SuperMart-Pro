using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMart_Pro.Models
{
    public enum ExpenseType
    {
        Food = 1,
        Transportation = 2,
        Entertainment = 3,
        Utilities = 4,
        Healthcare = 5,
        Education = 6,
        Miscellaneous = 7
    }
    internal class Expense : AuditableEntity
    {
        private string _expenseID = string.Empty;
        private string _description = string.Empty;
        private ExpenseType _expenseType;
        private decimal _amount;
        private DateTime _date;
        private byte[] _receiptImage = Array.Empty<byte>();
        private string _notes = string.Empty;
        private string _branchID = string.Empty;
        private string _approvedBy = string.Empty;
        private PaymentMethod _paymentMethod;

        public Expense() { }

        public Expense(string expenseID, string description, ExpenseType expenseType, decimal amount,
            DateTime date, byte[] receiptImage, string notes, string branchID, string approvedBy,
            PaymentMethod paymentMethod,
            DateTime createdAt, string createdBy, DateTime updatedAt, string updatedBy, DateTime? deletedAt, string deletedBy)
            : base(createdAt, createdBy, updatedAt, updatedBy, deletedAt, deletedBy)
        {
            _expenseID = expenseID;
            _description = description;
            _expenseType = expenseType;
            _amount = amount;
            _date = date;
            _receiptImage = receiptImage;
            _notes = notes;
            _branchID = branchID;
            _approvedBy = approvedBy;
            _paymentMethod = paymentMethod;
        }

        public string ExpenseID
        {
            get { return _expenseID; }
            set { _expenseID = value; }
        }
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        public ExpenseType ExpenseType
        {
            get { return _expenseType; }
            set { _expenseType = value; }
        }
        public decimal Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }
        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }
        public byte[] ReceiptImage
        {
            get { return _receiptImage; }
            set { _receiptImage = value; }
        }
        public string Notes
        {
            get { return _notes; }
            set { _notes = value; }
        }
        public string BranchID
        {
            get { return _branchID; }
            set { _branchID = value; }
        }
        public string ApprovedBy
        {
            get { return _approvedBy; }
            set { _approvedBy = value; }
        }
        public PaymentMethod PaymentMethod
        {
            get { return _paymentMethod; }
            set { _paymentMethod = value; }
        }
    }
}
