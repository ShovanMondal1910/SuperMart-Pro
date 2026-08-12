using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMart_Pro.Models
{
    public class Branch
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
        private string _createdBy = string.Empty;
        private DateTime _createdAt;
        private string _updatedBy = string.Empty;
        private DateTime _updatedAt;

        public Branch() { }

        public Branch(string branchID, string branchName, string branchType, string branchAddress, string branchZip,
            string branchPhone, string branchEmail, bool isActive, string managerID,
            string createdBy = "", DateTime createdAt = default, string updatedBy = "", DateTime updatedAt = default)
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
            _createdBy = createdBy;
            _createdAt = createdAt;
            _updatedBy = updatedBy;
            _updatedAt = updatedAt;
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
        public string CreatedBy
        {
            get { return _createdBy; }
            set { _createdBy = value; }
        }
        public DateTime CreatedAt
        {
            get { return _createdAt; }
            set { _createdAt = value; }
        }
        public string UpdatedBy
        {
            get { return _updatedBy; }
            set { _updatedBy = value; }
        }
        public DateTime UpdatedAt
        {
            get { return _updatedAt; }
            set { _updatedAt = value; }
        }
    }
}
