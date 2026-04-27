using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMart_Pro.Models
{
    public enum UserRole
    {
        Admin = 1,
        Manager = 2,
        Cashier = 3,
        Customer = 4
    }

    internal class User
    {
        private string _userID = string.Empty;
        
        // Personal Info
        private string _fullName = string.Empty;
        private DateTime _dateOfBirth;
        private string _gender = string.Empty;
        private byte[] _photo = Array.Empty<byte>();

        // Contact Info
        private string _phoneNumber = string.Empty;
        private string _email = string.Empty;
        private string _address = string.Empty;

        // Account Info
        private string _username = string.Empty;
        private string _passwordHash = string.Empty;
        private UserRole _role;
        private bool _isActive;

        //  BranchID
        private string _branchID = string.Empty;

        //Security Info
        private string _securityQuestion1 = string.Empty;
        private string _securityAnswer1 = string.Empty;
        private string _securityQuestion2 = string.Empty;
        private string _securityAnswer2 = string.Empty;

        // Session Info
        private DateTime? _lastLogin;
        private DateTime? _lastLogout;

        public User() { }

        public User(string userID, string fullName, DateTime dateOfBirth, string gender, byte[] photo, string phoneNumber,
            string email, string address, string username, string passwordHash, UserRole role, bool isActive,
            string branchID, string securityQuestion1, string securityAnswer1, string securityQuestion2, string securityAnswer2,
            DateTime? lastLogin, DateTime? lastLogout)
        {
            _userID = userID;
            _fullName = fullName;
            _dateOfBirth = dateOfBirth;
            _gender = gender;
            _photo = photo;
            _phoneNumber = phoneNumber;
            _email = email;
            _address = address;
            _username = username;
            _passwordHash = passwordHash;
            _role = role;
            _isActive = isActive;
            _branchID = branchID;
            _securityQuestion1 = securityQuestion1;
            _securityAnswer1 = securityAnswer1;
            _securityQuestion2 = securityQuestion2;
            _securityAnswer2 = securityAnswer2; 
            _lastLogin = lastLogin;
            _lastLogout = lastLogout;
        }

        public string UserID
        {
            get { return _userID; }
            set { _userID = value; }
        }
        
        public string FullName
        {
            get { return _fullName; }
            set { _fullName = value; }
        }
        public DateTime DateOfBirth
        {
            get { return _dateOfBirth; }
            set { _dateOfBirth = value; }
        }
        public int Age
        {
            get
            {
                var today = DateTime.Today;
                int age = today.Year - _dateOfBirth.Year;
                if (_dateOfBirth.Date > today.AddYears(-age)) age--;
                return age;
            }
        }
        public string Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
        public byte[] Photo
        {
            get { return _photo; }
            set { _photo = value; }
        }
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }
        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }
        public string PasswordHash
        {
            get { return _passwordHash; }
            set { _passwordHash = value; }
        }
        public UserRole Role
        {
            get { return _role; }
            set { _role = value; }
        }
        public bool IsActive
        {
            get { return _isActive; }
            set { _isActive = value; }
        }
        public string BranchID
        {
            get { return _branchID; }
            set { _branchID = value; }
        }
        public DateTime? LastLogin
        {
            get { return _lastLogin; }
            set { _lastLogin = value; }
        }
        public DateTime? LastLogout
        {
            get { return _lastLogout; }
            set { _lastLogout = value; }
        }
        public string SecurityQuestion1
        {
            get { return _securityQuestion1; }
            set { _securityQuestion1 = value; }
        }
        public string SecurityAnswer1
        {
            get { return _securityAnswer1; }
            set { _securityAnswer1 = value; }
        }
        public string SecurityQuestion2
        {
            get { return _securityQuestion2; }
            set { _securityQuestion2 = value; }
        }
        public string SecurityAnswer2
        {
            get { return _securityAnswer2; }
            set { _securityAnswer2 = value; }
        }

    }
}
