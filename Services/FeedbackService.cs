using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using HotelBooking.Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBooking.Services
{
    public class FeedbackService
    {
        private readonly string connectionString;

        public FeedbackService(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<Feedback> GetAllFeedback()
        {
            var feedbackList = new List<Feedback>();

            using (var connection = new SqlConnection(connectionString))
            {
                string query = @"SELECT f.FeedbackID, f.UserID, f.Message, f.SubmittedAt, u.username
                 FROM Feedback f
                 INNER JOIN login u ON f.UserID = u.ID
                 ORDER BY f.SubmittedAt DESC";


                using (var command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            feedbackList.Add(new Feedback
                            {
                                FeedbackID = (int)reader["FeedbackID"],
                                UserID = (int)reader["UserID"],
                                Message = reader["Message"].ToString(),
                                SubmittedAt = (DateTime)reader["SubmittedAt"],
                                Username = reader["username"].ToString()
                            });
                        }
                    }
                }
            }

            return feedbackList;
        }
    }
}
