using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBooking.Models
{
    public class Booking
    {
        public int BookingID { get; set; }
        public string GuestName { get; set; }
        public int RoomID { get; set; }
        public decimal TotalPrice { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UserID { get; set; }
        

    }
}
