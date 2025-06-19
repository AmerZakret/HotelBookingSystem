using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using HotelBooking.Models;

namespace HotelBooking.Services
    
{
    class UserService
    {
        private readonly string connectionString;

        public UserService(string conn)
        {
            connectionString = conn;
        }
        public List<User> GetAllUsers()
        {
            List<User> users = new List<User>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM login", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    users.Add(new User
                    {
                        Id = (int)reader["ID"],
                        Username = reader["username"].ToString(),
                        Email = reader["email"].ToString(),
                        Role = reader["role"].ToString(),
                    });

                }
            }

            return users;
        }

        // Password validation method
        public static bool ValidatePassword(string password, out string errorMessage)
        {
            errorMessage = string.Empty;
            if (string.IsNullOrEmpty(password) || password.Length < 8)
            {
                errorMessage = "Password must be at least 8 characters long.";
                return false;
            }
            if (!password.Any(char.IsDigit))
            {
                errorMessage = "Password must contain at least one number.";
                return false;
            }
            return true;
        }
    }
}
