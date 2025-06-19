using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelBooking.Models;
using System.Data;
using System.Data.SqlClient;
using DevExpress.Map.Kml.Model;

namespace HotelBooking.Services
{
    public class RoomService
    {
        private readonly string connectionString;

        public RoomService(string conn)
        {
            connectionString = conn;
        }

        public List<Room> GetAllRooms()
        {
            List<Room> rooms = new List<Room>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Rooms", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    rooms.Add(new Room
                    {
                        RoomID = Convert.ToInt32(reader["RoomID"]),
                        RoomNumber = reader["RoomNumber"].ToString(),
                        RoomType = reader["RoomType"].ToString(),
                        Price = Convert.ToDecimal(reader["Price"]),
                        Capacity = Convert.ToInt32(reader["Capacity"]),
                        Description = reader["Description"].ToString(),
                        ImageData = reader["Image"] == DBNull.Value ? null : (byte[])reader["Image"],
                        IsActive = Convert.ToBoolean(reader["IsActive"]),


                    });
                }
            }

            return rooms;
        }
        public Room GetRoomById(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Rooms WHERE RoomID = @id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new Room
                    {
                        RoomID = (int)reader["RoomID"],
                        RoomNumber = reader["RoomNumber"].ToString(),
                        RoomType = reader["RoomType"].ToString(),
                        Price = Convert.ToDecimal(reader["Price"]),
                        Capacity = Convert.ToInt32(reader["Capacity"]),
                        Description = reader["Description"].ToString(),
                        IsActive = Convert.ToBoolean(reader["IsActive"]),
                        ImageData = reader["Image"] == DBNull.Value ? null : (byte[])reader["Image"]

                    };
                }
            }
            return null;
        }

        public void UpdateRoom(Room room)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"
            UPDATE Rooms SET
                RoomNumber = @RoomNumber,
                RoomType = @RoomType,
                Price = @Price,
                Capacity = @Capacity,
                Description = @Description,
                IsActive = @IsActive,
                Image = @ImageData
            WHERE RoomID = @RoomID", conn);

                cmd.Parameters.AddWithValue("@RoomNumber", room.RoomNumber);
                cmd.Parameters.AddWithValue("@RoomType", room.RoomType);
                cmd.Parameters.AddWithValue("@Price", room.Price);
                cmd.Parameters.AddWithValue("@Capacity", room.Capacity);
                cmd.Parameters.AddWithValue("@Description", room.Description);
                cmd.Parameters.AddWithValue("@IsActive", room.IsActive);
                cmd.Parameters.AddWithValue("@RoomID", room.RoomID);
                cmd.Parameters.Add("@ImageData", SqlDbType.VarBinary).Value = (object)room.ImageData ?? DBNull.Value;

                cmd.ExecuteNonQuery();
            }
        }
        public bool DeleteRoom(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Rooms WHERE RoomID = @id", conn);
                cmd.Parameters.AddWithValue("@id", id);

                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }




        // You can later add methods like AddRoom, DeleteRoom, etc.
    }
}