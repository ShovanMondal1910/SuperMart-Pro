using Npgsql;
using SuperMart_Pro.Database;
using System;

namespace SuperMart_Pro.IDGenarator
{
    public static class BranchIDGenarator
    {
        private static readonly Random _random = new Random();
        private const string AlphanumericChars = "123456789";

        
        public static string GenerateBranchID()
        {
            string candidateID;
            int maxAttempts = 100;
            int attempts = 0;

            do
            {
                candidateID = GenerateRandomID();
                attempts++;
            }
            while (IsIDInDatabase(candidateID) && attempts < maxAttempts);

            return candidateID;
        }

        private static string GenerateRandomID()
        {
            char[] buffer = new char[4];
            for (int i = 0; i < buffer.Length; i++)
            {
                buffer[i] = AlphanumericChars[_random.Next(AlphanumericChars.Length)];
            }
            return $"B-{new string(buffer)}";
        }

        /// <summary>
        /// Checks if the given BranchID exists in the PostgreSQL "Branches" table.
        /// </summary>
        public static bool IsIDInDatabase(string branchID)
        {
            try
            {
                using var conn = Connection.GetConnection();
                conn.Open();
                string query = "SELECT COUNT(*) FROM \"Branches\" WHERE \"BranchID\" = @branchID;";
                using var cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@branchID", branchID);
                long count = Convert.ToInt64(cmd.ExecuteScalar());
                return count > 0;
            }
            catch
            {
                // Return false on connection failure to allow offline/fallback ID usage
                return false;
            }
        }
    }
}
