using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMart_Pro.Models
{
    internal class Supplier : AuditableEntity
    {
        private string _supplierId = string.Empty;
        private string _supplierName = string.Empty;
        private string _contactNumber = string.Empty;
        private string _email = string.Empty;
        private string _address = string.Empty;
        private string _country = string.Empty;
        private string _companyName = string.Empty;
        private bool _isActive;
        private string _website = string.Empty;

        public Supplier() { }

        public Supplier(string supplierId, string supplierName, string contactNumber, string email, string address,
            string country, string companyName, bool isActive, string website,
            DateTime createdAt, string createdBy, DateTime updatedAt, string updatedBy, DateTime? deletedAt, string deletedBy)
            : base(createdAt, createdBy, updatedAt, updatedBy, deletedAt, deletedBy)
        {
            _supplierId = supplierId;
            _supplierName = supplierName;
            _contactNumber = contactNumber;
            _email = email;
            _address = address;
            _country = country;
            _companyName = companyName;
            _isActive = isActive;
            _website = website;
        }

        public string SupplierId
        {
            get { return _supplierId; }
            set { _supplierId = value; }
        }
        public string SupplierName
        {
            get { return _supplierName; }
            set { _supplierName = value; }
        }
        public string ContactNumber
        {
            get { return _contactNumber; }
            set { _contactNumber = value; }
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
        public string Country
        {
            get { return _country; }
            set { _country = value; }
        }
        public string CompanyName
        {
            get { return _companyName; }
            set { _companyName = value; }
        }
        public bool IsActive
        {
            get { return _isActive; }
            set { _isActive = value; }
        }
        public string Website
        {
            get { return _website; }
            set { _website = value; }
        }
    }
}
