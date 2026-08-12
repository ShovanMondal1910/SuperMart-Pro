using Npgsql;
using System;
using System.Data;

namespace SuperMart_Pro.Database
{
    public static class Connection
    {
        private static string _connectionString = 
            "Host=localhost;Port=5432;Username=postgres;Password=1910;Database=SuperMartPro;";

        public static string ConnectionString
        {
            get => _connectionString;
            set => _connectionString = value;
        }

        public static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(_connectionString);
        }

        public static bool TestConnection(out string errorMessage)
        {
            errorMessage = string.Empty;
            try
            {
                using var conn = GetConnection();
                conn.Open();
                return true;
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return false;
            }
        }
    }
}
