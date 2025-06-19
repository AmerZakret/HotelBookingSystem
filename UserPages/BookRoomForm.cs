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
using System.IO;

namespace HotelBooking.UserPages
{
	public partial class BookRoomForm: DevExpress.XtraEditors.XtraForm
	{
        private  Room room;
        private  BookingService bookingService;
        private int userId;
        public BookRoomForm(Room room, int userId)
		{
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.room = room;
            this.userId = userId;
            string connectionString = "Data Source=DESKTOP-SNC9H22\\MSSQLSERVER02; Initial Catalog=HotelDB; Integrated Security=True; TrustServerCertificate=True";
            bookingService = new BookingService(connectionString);
            this.Load += BookRoomForm_Load;
        }   
        private void BookRoomForm_Load(object sender, EventArgs e)
        {

            lblRoomNumber.Text = "Room: " + room.RoomNumber;
            lblRoomType.Text = "Type: " + room.RoomType;
            lblPrice.Text = "Price: $" + room.Price.ToString("F2");

            if (room.ImageData != null)
            {
                using (var ms = new MemoryStream(room.ImageData))
                {
                    pictureBoxRoom.Image = Image.FromStream(ms);
                }
            }
        }
        private void btnConfirmBooking_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textGuestName.Text))
            {
                MessageBox.Show("Please enter guest name.");
                return;
            }
            try
            {
            var booking = new Booking
            {
                GuestName = textGuestName.Text.Trim(),
                RoomID = room.RoomID,
                TotalPrice = room.Price,
                    Status = "Pending",
                CreatedAt = DateTime.Now,
                UserID = userId
            };

            bookingService.AddBooking(booking);
            MessageBox.Show("Booking successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while booking:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnArrow_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tileViewRooms_ItemClick(object sender, TileItemEventArgs e)
        {
            var form = new ViewAvailableRoomsForm();
            this.Hide();
            form.FormClosed += (s, args) => this.Show();
            form.ShowDialog();
        }
    }
}
