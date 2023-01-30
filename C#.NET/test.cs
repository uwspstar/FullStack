
using System;
using System.Data.SqlClient;
namespace LoginPage
{
    public class DatabaseHelper
    {
        private readonly string connectionString; public DatabaseHelper(string connectionString) { this.connectionString = connectionString; }
        public void SavePassword(string username, string hashedPassword)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open(); using (SqlCommand command = new SqlCommand("SavePassword", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure; command.Parameters.AddWithValue("@Username", username); command.Parameters.AddWithValue("@Password", hashedPassword); command.ExecuteNonQuery();
                }
            }
        }
    }
}
