using System;
using System.Windows.Forms;
using HotelBooking.Services;
using DevExpress.XtraEditors;

namespace HotelBooking.UserPages
{
    public partial class ViewMyBookingsForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly BookingService bookingService;
        public ViewMyBookingsForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            string connectionString = "Data Source=DESKTOP-SNC9H22\\MSSQLSERVER02; Initial Catalog=HotelDB; Integrated Security=True; TrustServerCertificate=True";
            bookingService = new BookingService(connectionString);
        }

        private void ViewMyBookingsForm_Load(object sender, EventArgs e)
        {
            var bookings = bookingService.GetBookingsByUserId(Sessionn.UserId);
            gridControl1.DataSource = bookings;
            
            // Hide the UserID column
            gridView1.Columns["UserID"].Visible = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnArrow_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
} 