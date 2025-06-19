using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using HotelBooking.Services;
using DevExpress.XtraExport.Xls;
using HotelBooking.Models;
using System.IO;
using static DevExpress.Skins.SolidColorHelper;


namespace HotelBooking.pages.Rooms
{
    public partial class EditRoomForm : DevExpress.XtraEditors.XtraForm
    {
        public int SelectedRoomId { get; set; }
        private bool isLoadingRoomData = false;
        private static string connectionString = "Data Source=DESKTOP-SNC9H22\\MSSQLSERVER02; Initial Catalog=HotelDB; Integrated Security=True; TrustServerCertificate=True";
        private RoomService roomService = new RoomService(connectionString);
        private byte[] currentImageData = null;

        private int selectedRoomId;

        public EditRoomForm()
        {
            InitializeComponent();
        }


        private void EditRoomForm_Load(object sender, EventArgs e)
        {
            LoadRoomLookup();
        }

       
        private void LoadRoomLookup()
        {
            var rooms = roomService.GetAllRooms();
            lookupRooms.Properties.DataSource = rooms;
            lookupRooms.Properties.DisplayMember = "RoomNumber";
            lookupRooms.Properties.ValueMember = "RoomID";
        }


        private void lookupRooms_EditValueChanged(object sender, EventArgs e)
        {
            if (isLoadingRoomData) return;

            try
            {
                isLoadingRoomData = true;

                selectedRoomId = Convert.ToInt32(lookupRooms.EditValue);
                Room selectedRoom = roomService.GetRoomById(selectedRoomId);
                if (selectedRoom == null)
                {
                    MessageBox.Show("Room not found with ID: " + selectedRoomId);
                    return;
                }

                if (selectedRoom != null)
                {
                    textRoomNumber.Text = selectedRoom.RoomNumber;
                    cmbRoomType.Text = selectedRoom.RoomType;
                    textPrice.Text = selectedRoom.Price.ToString();
                    textCapacity.Value = selectedRoom.Capacity;
                    textDescription.Text = selectedRoom.Description;
                    chckAvailable.Checked = selectedRoom.IsActive;

                    currentImageData = selectedRoom.ImageData;
                    if (currentImageData != null)
                    {
                        using (var ms = new MemoryStream(currentImageData))
                        {
                            pictureRoom.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        pictureRoom.Image = null;
                    }
                }
            }
            finally
            {
                isLoadingRoomData = false;
            }
        }


        private void uploadBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;"
            };
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureRoom.Image = Image.FromFile(open.FileName);
                currentImageData = File.ReadAllBytes(open.FileName);
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            Room updatedRoom = new Room
            {
                RoomID = selectedRoomId,
                RoomNumber = textRoomNumber.Text,
                RoomType = cmbRoomType.Text,
                Price = Convert.ToDecimal(textPrice.Text),
                Capacity = Convert.ToInt32(textCapacity.Value),
                Description = textDescription.Text,
                IsActive = chckAvailable.Checked,
                ImageData = currentImageData
            };

            try
            {
                roomService.UpdateRoom(updatedRoom);
                XtraMessageBox.Show("Room updated successfully!");
                LoadRoomLookup();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error updating room:\n" + ex.Message);
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(textRoomNumber.Text))
            {
                XtraMessageBox.Show("Room number is required.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(cmbRoomType.Text))
            {
                XtraMessageBox.Show("Room type is required.");
                return false;
            }

            if (!decimal.TryParse(textPrice.Text, out _))
            {
                XtraMessageBox.Show("Enter a valid price.");
                return false;
            }

            return true;
        }
    }
}
