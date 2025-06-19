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
    public partial class EditBookingForm : DevExpress.XtraEditors.XtraForm
    {
        private RoomService roomService;
        private BookingService bookingService;
        private UserService userService;
        public EditBookingForm()
        {
            InitializeComponent();
            string connectionString = "Data Source=DESKTOP-SNC9H22\\MSSQLSERVER02; Initial Catalog=HotelDB; Integrated Security=True; TrustServerCertificate=True";

            bookingService = new BookingService(connectionString);
            roomService = new RoomService(connectionString);
            userService = new UserService(connectionString);
        }
        private void EditBookingForm_Load(object sender, EventArgs e)
        {
            LoadBookings();
            LoadRooms();
            LoadUsers();
            LoadStatuses();
        }
        private void LoadBookings()
        {
            var bookings = bookingService.GetAllBookings();
            bookingLookUpEdit.Properties.DataSource = bookings;
            bookingLookUpEdit.Properties.DisplayMember = "GuestName";
            bookingLookUpEdit.Properties.ValueMember = "BookingID";
        }

        private void LoadRooms()
        {
            var rooms = roomService.GetAllRooms();
            roomLookUpEdit.Properties.DataSource = rooms;
            roomLookUpEdit.Properties.DisplayMember = "RoomNumber";
            roomLookUpEdit.Properties.ValueMember = "RoomID";
        }

        private void LoadUsers()
        {
            var users = userService.GetAllUsers();
            userLookUpEdit.Properties.DataSource = users;
            userLookUpEdit.Properties.DisplayMember = "Username";
            userLookUpEdit.Properties.ValueMember = "Id"; // Your User.cs has Id
        }

        private void LoadStatuses()
        {
            statusCombo.Properties.Items.Clear();
            statusCombo.Properties.Items.AddRange(new[] { "Pending", "Confirmed", "Canceled" });
        }

        private void BookingLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (bookingLookUpEdit.EditValue != null &&
                int.TryParse(bookingLookUpEdit.EditValue.ToString(), out int bookingId))
            {
                var booking = bookingService.GetBookingById(bookingId);
                if (booking != null)
                {
                    guestName.Text = booking.GuestName;
                    roomLookUpEdit.EditValue = booking.RoomID;
                    userLookUpEdit.EditValue = booking.UserID;
                    totalPrice.Text = booking.TotalPrice.ToString("0.00");
                    statusCombo.Text = booking.Status;
                }
            }
        }

        private void RoomLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (roomLookUpEdit.EditValue != null &&
                int.TryParse(roomLookUpEdit.EditValue.ToString(), out int roomId))
            {
                var room = roomService.GetRoomById(roomId);
                if (room != null)
                {
                    totalPrice.Text = room.Price.ToString("0.00");
                }
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (bookingLookUpEdit.EditValue == null)
            {
                XtraMessageBox.Show("Please select a booking to update.");
                return;
            }

            if (!ValidateForm())
                return;

            var updatedBooking = new Booking
            {
                BookingID = Convert.ToInt32(bookingLookUpEdit.EditValue),
                GuestName = guestName.Text.Trim(),
                RoomID = Convert.ToInt32(roomLookUpEdit.EditValue),
                UserID = Convert.ToInt32(userLookUpEdit.EditValue),
                TotalPrice = Convert.ToDecimal(totalPrice.Text),
                Status = statusCombo.Text,
                CreatedAt = DateTime.Now 
            };

            try
            {
                bookingService.UpdateBooking(updatedBooking);
                XtraMessageBox.Show("Booking updated successfully!", "Success");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error updating booking:\n" + ex.Message, "Error");
            }
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(guestName.Text))
            {
                XtraMessageBox.Show("Guest name is required.");
                return false;
            }

            if (roomLookUpEdit.EditValue == null)
            {
                XtraMessageBox.Show("Please select a room.");
                return false;
            }

            if (userLookUpEdit.EditValue == null)
            {
                XtraMessageBox.Show("Please select a user.");
                return false;
            }

            if (!decimal.TryParse(totalPrice.Text, out _))
            {
                XtraMessageBox.Show("Invalid price.");
                return false;
            }

            return true;
        }
        
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            guestName.Text = "";
            totalPrice.Text = "";
            roomLookUpEdit.EditValue = null;
            userLookUpEdit.EditValue = null;
            bookingLookUpEdit.EditValue = null;
            statusCombo.SelectedIndex = -1;
        }
    }
}