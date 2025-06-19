using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelBooking.Models;
using System;
using System.Data;
using System.Data.SqlClient;
namespace HotelBooking.Services
{
    class BookingService
    {
        private readonly string _connectionString;

        public BookingService(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void AddBooking(Booking booking)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"INSERT INTO Bookings (GuestName, RoomID, TotalPrice, Status, CreatedAt, UserID)
                                 VALUES (@GuestName, @RoomID, @TotalPrice, @Status, @CreatedAt, @UserID)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@GuestName", booking.GuestName);
                cmd.Parameters.AddWithValue("@RoomID", booking.RoomID);
                cmd.Parameters.AddWithValue("@TotalPrice", booking.TotalPrice);
                cmd.Parameters.AddWithValue("@Status", booking.Status);
                cmd.Parameters.AddWithValue("@CreatedAt", booking.CreatedAt);
                cmd.Parameters.AddWithValue("@UserID", booking.UserID);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateBooking(Booking booking)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"UPDATE Bookings
                                 SET GuestName = @GuestName,
                                     RoomID = @RoomID,
                                     TotalPrice = @TotalPrice,
                                     Status = @Status,
                                     CreatedAt = @CreatedAt,
                                     UserID = @UserID
                                 WHERE BookingID = @BookingID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@GuestName", booking.GuestName);
                cmd.Parameters.AddWithValue("@RoomID", booking.RoomID);
                cmd.Parameters.AddWithValue("@TotalPrice", booking.TotalPrice);
                cmd.Parameters.AddWithValue("@Status", booking.Status);
                cmd.Parameters.AddWithValue("@CreatedAt", booking.CreatedAt);
                cmd.Parameters.AddWithValue("@UserID", booking.UserID);
                cmd.Parameters.AddWithValue("@BookingID", booking.BookingID);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteBooking(int bookingId)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "DELETE FROM Bookings WHERE BookingID = @BookingID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@BookingID", bookingId);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public Booking GetBookingById(int bookingId)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM Bookings WHERE BookingID = @BookingID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@BookingID", bookingId);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return new Booking
                    {
                        BookingID = (int)reader["BookingID"],
                        GuestName = reader["GuestName"].ToString(),
                        RoomID = (int)reader["RoomID"],
                        TotalPrice = (decimal)reader["TotalPrice"],
                        Status = reader["Status"].ToString(),
                        CreatedAt = (DateTime)reader["CreatedAt"],
                        UserID = (int)reader["UserID"]
                    };
                }

                return null;
            }
        }

        public List<Booking> GetAllBookings()
        {
            List<Booking> bookings = new List<Booking>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM Bookings ORDER BY CreatedAt DESC";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    bookings.Add(new Booking
                    {
                        BookingID = (int)reader["BookingID"],
                        GuestName = reader["GuestName"].ToString(),
                        RoomID = (int)reader["RoomID"],
                        TotalPrice = (decimal)reader["TotalPrice"],
                        Status = reader["Status"].ToString(),
                        CreatedAt = (DateTime)reader["CreatedAt"],
                        UserID = (int)reader["UserID"]
                    });
                }
            }

            return bookings;
        }

        public List<Booking> GetBookingsByUserId(int userId)
        {
            List<Booking> bookings = new List<Booking>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM Bookings WHERE UserID = @UserID ORDER BY CreatedAt DESC";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserID", userId);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    bookings.Add(new Booking
                    {
                        BookingID = (int)reader["BookingID"],
                        GuestName = reader["GuestName"].ToString(),
                        RoomID = (int)reader["RoomID"],
                        TotalPrice = (decimal)reader["TotalPrice"],
                        Status = reader["Status"].ToString(),
                        CreatedAt = (DateTime)reader["CreatedAt"],
                        UserID = (int)reader["UserID"]
                    });
                }
            }

            return bookings;
        }

        public void UpdateBookingStatus(int bookingId, string newStatus)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "UPDATE Bookings SET Status = @Status WHERE BookingID = @BookingID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Status", newStatus);
                cmd.Parameters.AddWithValue("@BookingID", bookingId);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }

}
