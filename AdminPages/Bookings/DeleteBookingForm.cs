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
    public partial class DeleteBookingForm : DevExpress.XtraEditors.XtraForm
    {
        private BookingService bookingService;
        string connectionString = "Data Source=DESKTOP-SNC9H22\\MSSQLSERVER02; Initial Catalog=HotelDB; Integrated Security=True; TrustServerCertificate=True";

        public DeleteBookingForm()
        {
            InitializeComponent();
            bookingService = new BookingService(connectionString);
        }
        private void DeleteBookingForm_Load(object sender, EventArgs e)
        {
            LoadBookings();
        }
        private void LoadBookings()
        {
            var bookings = bookingService.GetAllBookings();
            lookupBookings.Properties.DataSource = bookings;
            lookupBookings.Properties.DisplayMember = "GuestName";
            lookupBookings.Properties.ValueMember = "BookingID";
        }
        private void clearForm()
        {
            lookupBookings.EditValue = null;
        }
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (lookupBookings.EditValue == null)
            {
                XtraMessageBox.Show("Please select a booking to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int bookingId = Convert.ToInt32(lookupBookings.EditValue);
            bookingService.DeleteBooking(bookingId);
            XtraMessageBox.Show("Booking deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadBookings();
            clearForm();
        }
        private void clearBtn_Click(object sender, EventArgs e)
        {
            clearForm();
        }
    }
}