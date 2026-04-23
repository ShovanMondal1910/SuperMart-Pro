using System;

namespace SuperMart_Pro.Models
{
    public enum AdminType
    {
        SuperAdmin = 1,
        BranchAdmin = 2,
    }

    internal class Admin : User
    {
        private string _adminID = string.Empty;
        private AdminType _adminType;
        private bool _canManageUsers;
        private bool _canManageBranches;
        private bool _canViewReports;

        public Admin() 
        {
            Role = UserRole.Admin;
            _adminType = AdminType.BranchAdmin;
        }

        public Admin(string adminID, AdminType adminType, string userID, string fullName, DateTime dateOfBirth, string gender, byte[] photo,
            string phoneNumber, string email, string address, string username, string passwordHash,
            bool isActive, string branchID, string securityQuestion1, string securityAnswer1, string securityQuestion2, string securityAnswer2, DateTime? lastLogin, DateTime? lastLogout,
            bool canManageUsers, bool canManageBranches, bool canViewReports,
            DateTime createdAt, string createdBy, DateTime updatedAt, string updatedBy, DateTime? deletedAt, string deletedBy)
            : base(userID, fullName, dateOfBirth, gender, photo, phoneNumber, email, address,
                   username, passwordHash, UserRole.Admin, isActive, branchID, securityQuestion1, securityAnswer1, securityQuestion2, securityAnswer2, lastLogin, lastLogout,
                   createdAt, createdBy, updatedAt, updatedBy, deletedAt, deletedBy)
        {
            _adminID = adminID;
            _adminType = adminType;
            _canManageUsers = canManageUsers;
            _canManageBranches = canManageBranches;
            _canViewReports = canViewReports;
        }

        public string AdminID
        {
            get { return _adminID; }
            set { _adminID = value; }
        }

        public AdminType Type
        {
            get { return _adminType; }
            set { _adminType = value; }
        }

        public bool CanManageUsers
        {
            get { return _canManageUsers; }
            set { _canManageUsers = value; }
        }

        public bool CanManageBranches
        {
            get { return _canManageBranches; }
            set { _canManageBranches = value; }
        }

        public bool CanViewReports
        {
            get { return _canViewReports; }
            set { _canViewReports = value; }
        }
    }
}
