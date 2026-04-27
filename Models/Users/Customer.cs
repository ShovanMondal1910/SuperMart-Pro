using System;
using System.Collections.Generic;

namespace SuperMart_Pro.Models
{
    public enum CustomerType
    {
        Regular = 1,
        Premium = 2,
        VIP = 3
    }

    public enum CustomerStatus
    {
        Active = 1,
        Inactive = 2
    }

    internal class Customer : User
    {
        private string _customerID = string.Empty;
        private CustomerType _customerType;
        private decimal _loyaltyPoints = 0m;
        private decimal _totalSpent = 0m;
        private decimal _dueAmount = 0m;
        private CustomerStatus _customerStatus;
        private DateTime? _lastPurchaseDate;
        private ICollection<Sale> _sale;

        public Customer()
        {
            Role = UserRole.Customer;
            _customerStatus = CustomerStatus.Active;
            _sale = new HashSet<Sale>();
        }

        public Customer(
            string customerID, string userID, string fullName, DateTime dateOfBirth, string gender, byte[] photo,
            string phoneNumber, string email, string address, string username, string passwordHash,
            bool isActive, string branchID, string securityQuestion1, string securityAnswer1, string securityQuestion2, string securityAnswer2,
            DateTime? lastLogin, DateTime? lastLogout, decimal loyaltyPoints, decimal totalSpent, decimal dueAmount, CustomerStatus customerStatus)
            : base(userID, fullName, dateOfBirth, gender, photo, phoneNumber, email, address,
                   username, passwordHash, UserRole.Customer, isActive, branchID, securityQuestion1, securityAnswer1, securityQuestion2, securityAnswer2,
                   lastLogin, lastLogout)
        {
            _customerID = customerID;
            _loyaltyPoints = loyaltyPoints;
            _totalSpent = totalSpent;
            _dueAmount = dueAmount;
            _customerStatus = customerStatus;
            UpdateCustomerType();
            _sale = new HashSet<Sale>();
        }

        public string CustomerID
        {
            get { return _customerID; }
            set { _customerID = value; }
        }

        public CustomerType Type
        {
            get { return _customerType; }
            private set { _customerType = value; }
        }

        public decimal LoyaltyPoints
        {
            get { return _loyaltyPoints; }
            set
            {
                _loyaltyPoints = value;
                UpdateCustomerType();
            }
        }

        public decimal TotalSpent
        {
            get { return _totalSpent; }
            set { _totalSpent = value; }
        }

        public decimal DueAmount
        {
            get { return _dueAmount; }
            set { _dueAmount = value; }
        }

        public CustomerStatus Status
        {
            get { return _customerStatus; }
            set { _customerStatus = value; }
        }

        public DateTime? LastPurchaseDate
        {
            get { return _lastPurchaseDate; }
            set { _lastPurchaseDate = value; }
        }

        public virtual ICollection<Sale> Sale
        {
            get { return _sale; }
            set { _sale = value; }
        }

        // Adds loyalty points based on purchase amount (1 point per 1000 taka)
        // and updates CustomerType based on total points earned
        public void AddPurchase(decimal amount)
        {
            if (amount <= 0) 
            { 
                return; 
            }

            _totalSpent += amount;
            _loyaltyPoints += Math.Floor(amount / 1000m);
            _lastPurchaseDate = DateTime.Now;

            UpdateCustomerType();
            CheckAndUpdateStatus();
        }

        // Sets status to Inactive if no purchase in the last 3 months, otherwise Active
        public void CheckAndUpdateStatus()
        {
            if (_lastPurchaseDate == null || _lastPurchaseDate < DateTime.Now.AddMonths(-3))
            {
                _customerStatus = CustomerStatus.Inactive;
            }
            else
            {
                _customerStatus = CustomerStatus.Active;
            }
        }

        private void UpdateCustomerType()
        {
            if (_loyaltyPoints >= 2000)
            {
                _customerType = CustomerType.VIP;
            }
            else if (_loyaltyPoints >= 1000)
            {
                _customerType = CustomerType.Premium;
            }
            else
            {
                _customerType = CustomerType.Regular;
            }
        }
    }
}
