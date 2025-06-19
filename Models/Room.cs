using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBooking.Models
{
    public class Room
    {
        public int RoomID { get; set; }
        public string RoomNumber { get; set; }
        public string RoomType { get; set; }
        public decimal Price { get; set; }
        public int Capacity { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public byte[] ImageData { get; set; } // Stores the room image as byte array

        // Optional: Constructor
        public Room() { }

        public Room(int roomId, string roomNumber, string roomType, decimal price, int capacity, string description, bool isActive, byte[] imageData)
        {
            RoomID = roomId;
            RoomNumber = roomNumber;
            RoomType = roomType;
            Price = price;
            Capacity = capacity;
            Description = description;
            IsActive = isActive;
            ImageData = imageData;
        }
    }
}
