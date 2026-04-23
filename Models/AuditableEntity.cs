using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMart_Pro.Models
{
    internal abstract class AuditableEntity
    {
        private DateTime _createdAt;
        private string _createdBy = string.Empty;
        private DateTime _updatedAt;
        private string _updatedBy = string.Empty;
        private bool _isDeleted;
        private DateTime? _deletedAt;
        private string _deletedBy = string.Empty;

        public AuditableEntity() { }

        public AuditableEntity(DateTime createdAt, string createdBy, DateTime updatedAt, string updatedBy, DateTime? deletedAt, string deletedBy)
        {
            _createdAt = createdAt;
            _createdBy = createdBy;
            _updatedAt = updatedAt;
            _updatedBy = updatedBy;
            _deletedAt = deletedAt;
            _deletedBy = deletedBy;
        }

        public DateTime CreatedAt
        {
            get { return _createdAt; }
            set { _createdAt = value; }
        }
        public string CreatedBy
        {
            get { return _createdBy; }
            set { _createdBy = value; }
        }
        public DateTime UpdatedAt
        {
            get { return _updatedAt; }
            set { _updatedAt = value; }
        }
        public string UpdatedBy
        {
            get { return _updatedBy; }
            set { _updatedBy = value; }
        }
        public DateTime? DeletedAt
        {
            get { return _deletedAt; }
            set { _deletedAt = value; }
        }
        public string DeletedBy
        {
            get { return _deletedBy; }
            set { _deletedBy = value; }
        }
        public bool IsDeleted
        {
            get { return _isDeleted; }
            set { _isDeleted = value; }
        }
    }
}
