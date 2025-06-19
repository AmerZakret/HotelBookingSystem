using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBooking.Models
{
    public class Feedback
    {
            public int FeedbackID { get; set; }
            public int UserID { get; set; }
            public string Message { get; set; }
            public DateTime SubmittedAt { get; set; }

            public string Username { get; set; }
        }
    }
