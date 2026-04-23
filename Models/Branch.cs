using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMart_Pro.Models
{
    internal class Branch : AuditableEntity
    {
        private string _branchID = string.Empty;
        private string _branchName = string.Empty;
        private string _branchType = string.Empty;
        private string _branchAddress = string.Empty;
        private string _branchZip = string.Empty;
        private string _branchPhone = string.Empty;
        private string _branchEmail = string.Empty;
        private bool _isActive;
        private string _managerID = string.Empty;

        public Branch() { }

        public Branch(string branchID, string branchName, string branchType, string branchAddress, string branchZip,
            string branchPhone, string branchEmail, bool isActive, string managerID,
            DateTime createdAt, string createdBy, DateTime updatedAt, string updatedBy, DateTime? deletedAt, string deletedBy)
            : base(createdAt, createdBy, updatedAt, updatedBy, deletedAt, deletedBy)
        {
            _branchID = branchID;
            _branchName = branchName;
            _branchType = branchType;
            _branchAddress = branchAddress;
            _branchZip = branchZip;
            _branchPhone = branchPhone;
            _branchEmail = branchEmail;
            _isActive = isActive;
            _managerID = managerID;
        }

        public string BranchID
        {
            get { return _branchID; }
            set { _branchID = value; }
        }
        public string BranchName
        {
            get { return _branchName; }
            set { _branchName = value; }
        }
        public string BranchType
        {
            get { return _branchType; }
            set { _branchType = value; }
        }
        public string BranchAddress
        {
            get { return _branchAddress; }
            set { _branchAddress = value; }
        }
        public string BranchZip
        {
            get { return _branchZip; }
            set { _branchZip = value; }
        }
        public string BranchPhone
        {
            get { return _branchPhone; }
            set { _branchPhone = value; }
        }
        public string BranchEmail
        {
            get { return _branchEmail; }
            set { _branchEmail = value; }
        }
        public bool IsActive
        {
            get { return _isActive; }
            set { _isActive = value; }
        }
        public string ManagerID
        {
            get { return _managerID; }
            set { _managerID = value; }
        }
    }
}
