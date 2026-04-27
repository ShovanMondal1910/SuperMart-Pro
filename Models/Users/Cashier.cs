using System;

namespace SuperMart_Pro.Models
{
    public enum CashierType
    {
        SaleCashier = 1,
        StockKeeper = 2,
        Accountant = 3
    }

    internal class Cashier : User
    {
        private string _cashierID = string.Empty;
        private CashierType _cashierType;
        private bool _canProcessSales;
        private bool _canProcessReturns;
        private bool _canManageStock;

        public Cashier()
        {
            Role = UserRole.Cashier;
            _cashierType = CashierType.SaleCashier;
        }

        public Cashier(string cashierID, CashierType cashierType, string userID, string fullName, DateTime dateOfBirth,
            string gender, byte[] photo, string phoneNumber, string email, string address, string username,
            string passwordHash, bool isActive, string branchID, string securityQuestion1, string securityAnswer1, string securityQuestion2, string securityAnswer2,
            DateTime? lastLogin, DateTime? lastLogout, bool canProcessSales, bool canProcessReturns, bool canManageStock)
            : base(userID, fullName, dateOfBirth, gender, photo, phoneNumber, email, address,
                   username, passwordHash, UserRole.Cashier, isActive, branchID, securityQuestion1, securityAnswer1, securityQuestion2, securityAnswer2,
                   lastLogin, lastLogout)
        {
            _cashierID = cashierID;
            _cashierType = cashierType;
            _canProcessSales = canProcessSales;
            _canProcessReturns = canProcessReturns;
            _canManageStock = canManageStock;
        }

        public string CashierID
        {
            get { return _cashierID; }
            set { _cashierID = value; }
        }

        public CashierType Type
        {
            get { return _cashierType; }
            set { _cashierType = value; }
        }

        public bool CanProcessSales
        {
            get { return _canProcessSales; }
            set { _canProcessSales = value; }
        }

        public bool CanProcessReturns
        {
            get { return _canProcessReturns; }
            set { _canProcessReturns = value; }
        }

        public bool CanManageStock
        {
            get { return _canManageStock; }
            set { _canManageStock = value; }
        }
    }
}
