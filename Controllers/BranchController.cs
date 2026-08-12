using Npgsql;
using SuperMart_Pro.Database;
using SuperMart_Pro.Models;
using System;

namespace SuperMart_Pro.Controllers
{
    public static class BranchController
    {
        /// <summary>
        /// Inserts a new Branch record into the PostgreSQL database.
        /// </summary>
        /// <param name="branch">The Branch model instance to add.</param>
        /// <param name="errorMessage">Out parameter returning error message if operation fails.</param>
        /// <returns>True if insertion succeeded; otherwise false.</returns>
        public static bool AddBranch(Branch branch, out string errorMessage)
        {
            errorMessage = string.Empty;

            if (!string.IsNullOrWhiteSpace(branch.BranchAddress) && IsAddressExists(branch.BranchAddress))
            {
                errorMessage = "Branch Address already exists.";
                return false;
            }

            if (!string.IsNullOrWhiteSpace(branch.BranchPhone) && IsPhoneExists(branch.BranchPhone))
            {
                errorMessage = "Branch Phone number already exists.";
                return false;
            }

            if (!string.IsNullOrWhiteSpace(branch.BranchEmail) && IsEmailExists(branch.BranchEmail))
            {
                errorMessage = "Branch Email address already exists.";
                return false;
            }

            if (!string.IsNullOrWhiteSpace(branch.ManagerID) && IsManagerIDExists(branch.ManagerID))
            {
                errorMessage = "Manager ID is already assigned to another branch.";
                return false;
            }

            try
            {
                using var conn = Connection.GetConnection();
                conn.Open();

                string query = @"
                    INSERT INTO ""Branches"" 
                    (""BranchID"", ""BranchName"", ""BranchType"", ""BranchAddress"", ""BranchZip"", 
                     ""BranchPhone"", ""BranchEmail"", ""IsActive"", ""ManagerID"", ""CreatedBy"", ""CreatedAt"", ""UpdatedBy"", ""UpdatedAt"")
                    VALUES 
                    (@BranchID, @BranchName, @BranchType, @BranchAddress, @BranchZip, 
                     @BranchPhone, @BranchEmail, @IsActive, @ManagerID, @CreatedBy, @CreatedAt, @UpdatedBy, @UpdatedAt);";

                using var cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@BranchID", branch.BranchID);
                cmd.Parameters.AddWithValue("@BranchName", branch.BranchName);
                cmd.Parameters.AddWithValue("@BranchType", (object?)branch.BranchType ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@BranchAddress", (object?)branch.BranchAddress ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@BranchZip", (object?)branch.BranchZip ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@BranchPhone", (object?)branch.BranchPhone ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@BranchEmail", (object?)branch.BranchEmail ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@IsActive", branch.IsActive);
                cmd.Parameters.AddWithValue("@ManagerID", string.IsNullOrWhiteSpace(branch.ManagerID) ? DBNull.Value : branch.ManagerID);
                cmd.Parameters.AddWithValue("@CreatedBy", string.IsNullOrWhiteSpace(branch.CreatedBy) ? "System" : branch.CreatedBy);
                cmd.Parameters.AddWithValue("@CreatedAt", branch.CreatedAt == default ? DateTime.Now : branch.CreatedAt);
                cmd.Parameters.AddWithValue("@UpdatedBy", string.IsNullOrWhiteSpace(branch.UpdatedBy) ? "System" : branch.UpdatedBy);
                cmd.Parameters.AddWithValue("@UpdatedAt", branch.UpdatedAt == default ? DateTime.Now : branch.UpdatedAt);

                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            catch (PostgresException pex) when (pex.SqlState == "23505")
            {
                if (pex.ConstraintName != null && pex.ConstraintName.Contains("BranchAddress", StringComparison.OrdinalIgnoreCase))
                {
                    errorMessage = "Branch Address already exists.";
                }
                else if (pex.ConstraintName != null && pex.ConstraintName.Contains("BranchPhone", StringComparison.OrdinalIgnoreCase))
                {
                    errorMessage = "Branch Phone number already exists.";
                }
                else if (pex.ConstraintName != null && pex.ConstraintName.Contains("BranchEmail", StringComparison.OrdinalIgnoreCase))
                {
                    errorMessage = "Branch Email address already exists.";
                }
                else if (pex.ConstraintName != null && pex.ConstraintName.Contains("ManagerID", StringComparison.OrdinalIgnoreCase))
                {
                    errorMessage = "Manager ID is already assigned to another branch.";
                }
                else
                {
                    errorMessage = "A record with this unique identifier already exists.";
                }
                return false;
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return false;
            }
        }

        /// <summary>
        /// Checks if a branch address already exists in the database.
        /// </summary>
        public static bool IsAddressExists(string address)
        {
            if (string.IsNullOrWhiteSpace(address)) return false;
            try
            {
                using var conn = Connection.GetConnection();
                conn.Open();
                string query = @"SELECT COUNT(*) FROM ""Branches"" WHERE LOWER(""BranchAddress"") = LOWER(@address);";
                using var cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@address", address.Trim());
                long count = Convert.ToInt64(cmd.ExecuteScalar());
                return count > 0;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Checks if a branch phone number already exists in the database.
        /// </summary>
        public static bool IsPhoneExists(string phone)
        {
            if (string.IsNullOrWhiteSpace(phone)) return false;
            try
            {
                using var conn = Connection.GetConnection();
                conn.Open();
                string query = @"SELECT COUNT(*) FROM ""Branches"" WHERE LOWER(""BranchPhone"") = LOWER(@phone);";
                using var cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@phone", phone.Trim());
                long count = Convert.ToInt64(cmd.ExecuteScalar());
                return count > 0;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Checks if a branch email address already exists in the database.
        /// </summary>
        public static bool IsEmailExists(string email)
        {
            if (string.IsNullOrWhiteSpace(email)) return false;
            try
            {
                using var conn = Connection.GetConnection();
                conn.Open();
                string query = @"SELECT COUNT(*) FROM ""Branches"" WHERE LOWER(""BranchEmail"") = LOWER(@email);";
                using var cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@email", email.Trim());
                long count = Convert.ToInt64(cmd.ExecuteScalar());
                return count > 0;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Checks if a manager ID is already assigned to a branch in the database.
        /// </summary>
        public static bool IsManagerIDExists(string managerID)
        {
            if (string.IsNullOrWhiteSpace(managerID)) return false;
            try
            {
                using var conn = Connection.GetConnection();
                conn.Open();
                string query = @"SELECT COUNT(*) FROM ""Branches"" WHERE LOWER(""ManagerID"") = LOWER(@managerID);";
                using var cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@managerID", managerID.Trim());
                long count = Convert.ToInt64(cmd.ExecuteScalar());
                return count > 0;
            }
            catch
            {
                return false;
            }
        }
    }
}
