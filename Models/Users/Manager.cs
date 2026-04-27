using System;

namespace SuperMart_Pro.Models
{
    public enum ManagerType
    {
        BranchManager = 1,
        RegionalManager = 2
    }

    internal class Manager : User
    {
        private string _managerID = string.Empty;
        private ManagerType _managerType;
        private bool _canManageStaff;
        private bool _canManageInventory;
        private bool _canApprovePurchases;
        private bool _canViewBranchReports;

        public Manager()
        {
            Role = UserRole.Manager;
            _managerType = ManagerType.BranchManager;
        }

        public Manager(string managerID, ManagerType managerType, string userID, string fullName, DateTime dateOfBirth,
            string gender, byte[] photo, string phoneNumber, string email, string address, string username,
            string passwordHash, bool isActive, string branchID, string securityQuestion1, string securityAnswer1, string securityQuestion2, string securityAnswer2,
            DateTime? lastLogin, DateTime? lastLogout, bool canManageStaff, bool canManageInventory, bool canApprovePurchases,
            bool canViewBranchReports)
            : base(userID, fullName, dateOfBirth, gender, photo, phoneNumber, email, address,
                   username, passwordHash, UserRole.Manager, isActive, branchID, securityQuestion1, securityAnswer1, securityQuestion2, securityAnswer2,
                   lastLogin, lastLogout)
        {
            _managerID = managerID;
            _managerType = managerType;
            _canManageStaff = canManageStaff;
            _canManageInventory = canManageInventory;
            _canApprovePurchases = canApprovePurchases;
            _canViewBranchReports = canViewBranchReports;
        }

        public string ManagerID
        {
            get { return _managerID; }
            set { _managerID = value; }
        }

        public ManagerType Type
        {
            get { return _managerType; }
            set { _managerType = value; }
        }

        public bool CanManageStaff
        {
            get { return _canManageStaff; }
            set { _canManageStaff = value; }
        }

        public bool CanManageInventory
        {
            get { return _canManageInventory; }
            set { _canManageInventory = value; }
        }

        public bool CanApprovePurchases
        {
            get { return _canApprovePurchases; }
            set { _canApprovePurchases = value; }
        }

        public bool CanViewBranchReports
        {
            get { return _canViewBranchReports; }
            set { _canViewBranchReports = value; }
        }
    }
}
