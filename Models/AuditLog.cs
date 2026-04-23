using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMart_Pro.Models
{
    public enum AuditAction
    {
        Insert = 1,
        Update = 2,
        Delete = 3,
        Read = 4,
        Login = 5,
        Logout = 6,
        PasswordChange = 7,
        PermissionChange = 8,
        DataExport = 9,
        DataImport = 10
    }
    internal class AuditLog
    {
        private string _auditID = string.Empty;
        private string _tableName = string.Empty;
        private string _recordAuditID = string.Empty;
        private AuditAction _action;
        private string? _oldValues;
        private string? _newValues;
        private DateTime _changedAt;
        private string _changedBy = string.Empty;

        public AuditLog() { }

        public AuditLog(string auditID, string tableName, string recordAuditID, AuditAction action,
            string? oldValues, string? newValues, DateTime changedAt, string changedBy)
        {
            _auditID = auditID;
            _tableName = tableName;
            _recordAuditID = recordAuditID;
            _action = action;
            _oldValues = oldValues;
            _newValues = newValues;
            _changedAt = changedAt;
            _changedBy = changedBy;
        }

        public string AuditID
        {
            get { return _auditID; }
            set { _auditID = value; }
        }
        public string TableName
        {     
            get { return _tableName; }
            set { _tableName = value; }
        }
        public string RecordAuditID
        {
            get { return _recordAuditID; }
            set { _recordAuditID = value; }
        }
        public AuditAction Action
        {
            get { return _action; }
            set { _action = value; }
        }
        public string OldValues
        {
            get { return _oldValues ?? string.Empty; }
            set { _oldValues = value; }
        }
        public string NewValues
        {
            get { return _newValues ?? string.Empty; }
            set { _newValues = value; }
        }
        public DateTime ChangedAt
        {
            get { return _changedAt; }
            set { _changedAt = value; }
        }
        public string ChangedBy
        {
            get { return _changedBy; }
            set { _changedBy = value; }
        }
    }
}
