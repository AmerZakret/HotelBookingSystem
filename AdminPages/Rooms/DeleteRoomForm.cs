using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using HotelBooking.Models;
using HotelBooking.Services;

namespace HotelBooking.pages.Rooms
{
    public partial class DeleteRoomForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly RoomService roomService;
        string connectionString = "Data Source=DESKTOP-SNC9H22\\MSSQLSERVER02; Initial Catalog=HotelDB; Integrated Security=True; TrustServerCertificate=True";


        public DeleteRoomForm()
        {
            InitializeComponent();
            roomService = new RoomService(connectionString);
        }

        private void DeleteRoomForm_Load(object sender, EventArgs e)
        {
            LoadRoomsIntoLookup();
        }

        private void LoadRoomsIntoLookup()
        {
            List<Room> rooms = roomService.GetAllRooms();
            roomLookup.Properties.DataSource = rooms;
            roomLookup.Properties.DisplayMember = "RoomNumber";
            roomLookup.Properties.ValueMember = "RoomID";
            roomLookup.EditValue = null;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (roomLookup.EditValue == null)
            {
                XtraMessageBox.Show("Please select a room to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int roomId = (int)roomLookup.EditValue;
            Room selectedRoom = roomService.GetRoomById(roomId);

            if (selectedRoom == null)
            {
                XtraMessageBox.Show("Selected room not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult confirm = XtraMessageBox.Show(
                $"Are you sure you want to delete Room {selectedRoom.RoomNumber}?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                bool deleted = roomService.DeleteRoom(roomId);

                if (deleted)
                {
                    XtraMessageBox.Show("Room deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadRoomsIntoLookup(); // Refresh the list
                }
                else
                {
                    XtraMessageBox.Show("Failed to delete the room. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            roomLookup.Clear();
        }
    }
}
