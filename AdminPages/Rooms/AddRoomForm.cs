using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace HotelBooking.pages.Rooms
{
    public partial class AddRoomForm : DevExpress.XtraEditors.XtraForm
    {
        string connectionString = "Data Source=DESKTOP-SNC9H22\\MSSQLSERVER02; Initial Catalog=HotelDB; Integrated Security=True; TrustServerCertificate=True";
        Image uploadedImage = null;

        public AddRoomForm()
        {
            InitializeComponent();
        }

        private void uploadBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                uploadedImage = Image.FromFile(open.FileName);
                pictureRoom.Image = uploadedImage;
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            try
            {
                byte[] imageBytes = null;
                if (uploadedImage != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        uploadedImage.Save(ms, uploadedImage.RawFormat);
                        imageBytes = ms.ToArray();
                    }
                }

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(
                        "INSERT INTO Rooms (RoomNumber, RoomType, Price, Capacity, Description, Image, IsActive) VALUES (@RoomNumber, @RoomType, @Price, @Capacity, @Description, @Image, @IsActive)", conn);

                    cmd.Parameters.AddWithValue("@RoomNumber", textRoomNumber.Text);
                    cmd.Parameters.AddWithValue("@RoomType", cmbRoomType.Text);
                    cmd.Parameters.AddWithValue("@Price", Convert.ToDecimal(textPrice.Text));
                    cmd.Parameters.AddWithValue("@Capacity", Convert.ToInt32(textCapacity.Value));
                    cmd.Parameters.AddWithValue("@Description", textDescription.Text);
                    cmd.Parameters.AddWithValue("@Image", imageBytes ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@IsActive", chckAvailable.Checked);

                    cmd.ExecuteNonQuery();
                    XtraMessageBox.Show("Room added successfully!");
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error while saving room:\n" + ex.Message);
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

            if (string.IsNullOrWhiteSpace(textPrice.Text))
            {
                XtraMessageBox.Show("Price is required.");
                return false;
            }

            if (!decimal.TryParse(textPrice.Text, out _))
            {
                XtraMessageBox.Show("Price must be a valid number.");
                return false;
            }

            if (uploadedImage == null)
            {
                XtraMessageBox.Show("Please upload a photo.");
                return false;
            }

            return true;
        }
    }
}
