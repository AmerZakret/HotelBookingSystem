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
    public partial class AddBookingForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly RoomService roomService;
        private readonly UserService userService;
        private readonly BookingService bookingService;

        public AddBookingForm()
        {
            InitializeComponent();
            string connectionString = "Data Source=DESKTOP-SNC9H22\\MSSQLSERVER02; Initial Catalog=HotelDB; Integrated Security=True; TrustServerCertificate=True";

            roomService = new RoomService(connectionString);
            userService = new UserService(connectionString);
            bookingService = new BookingService(connectionString);
        }

        private void AddBookingForm_Load(object sender, EventArgs e)
        {
            LoadRooms();
            LoadUsers();
            LoadStatuses();
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
            userLookUpEdit.Properties.ValueMember = "Id";
        }


        private void LoadStatuses()
        {
            statusCombo.Properties.Items.Clear();
            statusCombo.Properties.Items.AddRange(new[] { "Pending", "Confirmed", "Canceled" });
            statusCombo.SelectedIndex = 0;
        }

        private void roomLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (roomLookUpEdit.EditValue != null)
            {
                int roomId = Convert.ToInt32(roomLookUpEdit.EditValue);
                var room = roomService.GetRoomById(roomId);
                if (room != null)
                {
                    totalPrice.Text = room.Price.ToString("0.00");
                }
            }
        }


        private void addBtn_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
                return;

            var booking = new Booking
            {
                GuestName = guestName.Text.Trim(),
                RoomID = Convert.ToInt32(roomLookUpEdit.EditValue),
                TotalPrice = Convert.ToDecimal(totalPrice.Text),
                Status = statusCombo.Text,
                CreatedAt = DateTime.Now,
                UserID = Convert.ToInt32(userLookUpEdit.EditValue)
            };

            try
            {
                bookingService.AddBooking(booking);
                XtraMessageBox.Show("Booking added successfully!", "Success");
                ClearForm();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error adding booking:\n" + ex.Message, "Error");
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
                XtraMessageBox.Show("Enter a valid total price.");
                return false;
            }

            return true;
        }

        private void ClearForm()
        {
            guestName.Text = "";
            roomLookUpEdit.EditValue = null;
            userLookUpEdit.EditValue = null;
            totalPrice.Text = "";
            statusCombo.SelectedIndex = 0;
        }
    }
}
