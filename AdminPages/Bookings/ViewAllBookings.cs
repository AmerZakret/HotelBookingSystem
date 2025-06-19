using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using HotelBooking.Models;
using HotelBooking.Services;

namespace HotelBooking.pages.Bookings
{
	public partial class ViewAllBookings: DevExpress.XtraEditors.XtraForm
	{
        private BookingService bookingService;
        public ViewAllBookings()
		{
            InitializeComponent();
            string connectionString = "Data Source=DESKTOP-SNC9H22\\MSSQLSERVER02; Initial Catalog=HotelDB; Integrated Security=True; TrustServerCertificate=True";
            bookingService = new BookingService(connectionString);
            
        }
        private void ViewAllBookings_Load(object sender, EventArgs e)
        {
            
            var bookings = bookingService.GetAllBookings();
            gridControl1.DataSource = bookings;
        }
    }
}