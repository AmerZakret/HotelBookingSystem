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
using System.Runtime.InteropServices;

namespace HotelBooking.UserPages
{
    public partial class ViewAvailableRoomsForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly RoomService roomService;

        public ViewAvailableRoomsForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.White;
            string connectionString = "Data Source=DESKTOP-SNC9H22\\MSSQLSERVER02; Initial Catalog=HotelDB; Integrated Security=True; TrustServerCertificate=True";
            roomService = new RoomService(connectionString);
            // Add back arrow button (top left)
            var btnBack = new Button();
            btnBack.Text = "←";
            btnBack.Font = new Font("Segoe UI", 18, FontStyle.Bold);
            btnBack.Size = new Size(50, 50);
            btnBack.Location = new Point(10, 10);
            btnBack.BackColor = Color.FromArgb(240, 245, 255);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.Cursor = Cursors.Hand;
            btnBack.ForeColor = Color.FromArgb(54, 116, 181);
            btnBack.Click += (s, e) => this.Close();
            btnBack.BringToFront();
            Controls.Add(btnBack);
        }

        private void ViewAvailableRoomsForm_Load(object sender, EventArgs e)
        {
            LoadRooms();
        }

        private void LoadRooms()
        {
            List<Room> rooms = roomService.GetAllRooms();

            flowLayoutPanelRooms.Controls.Clear();

            foreach (Room room in rooms)
            {
                if (!room.IsActive)
                    continue;

                var card = CreateRoomCard(room);
                flowLayoutPanelRooms.Controls.Add(card);
            }
        }

        private Control CreateRoomCard(Room room)
        {
            var panel = new Panel
            {
                Width = 380,
                Height = 340,
                Margin = new Padding(18),
                BackColor = Color.White,
                BorderStyle = BorderStyle.None,
                Padding = new Padding(0, 0, 0, 0)
            };
            // Drop shadow effect
            panel.Paint += (s, e) =>
            {
                var g = e.Graphics;
                var shadowRect = new Rectangle(8, 8, panel.Width - 16, panel.Height - 16);
                using (var shadow = new SolidBrush(Color.FromArgb(30, 0, 0, 0)))
                    g.FillRectangle(shadow, shadowRect);
                var rect = new Rectangle(0, 0, panel.Width - 1, panel.Height - 1);
                using (var brush = new System.Drawing.Drawing2D.LinearGradientBrush(rect, Color.White, Color.FromArgb(245, 249, 255), 45f))
                    g.FillRectangle(brush, rect);
                using (var pen = new Pen(Color.FromArgb(220, 220, 220), 2))
                    g.DrawRectangle(pen, rect);
            };
            panel.Region = System.Drawing.Region.FromHrgn(
                NativeMethods.CreateRoundRectRgn(0, 0, panel.Width, panel.Height, 28, 28));

            // Large square image box, no border/shadow, image fits box
            var pictureBox = new PictureBox
            {
                Width = 200,
                Height = 200,
                Location = new Point(20, 20),
                SizeMode = PictureBoxSizeMode.Zoom,
                BackColor = Color.White,
            };
            if (room.ImageData != null && room.ImageData.Length > 0)
            {
                using (var ms = new System.IO.MemoryStream(room.ImageData))
                {
                    pictureBox.Image = Image.FromStream(ms);
                }
            }
            // No circular region, no border, no shadow
            panel.Controls.Add(pictureBox);

            int infoLeft = 235;
            int infoTop = 38;
            int infoSpacing = 38;
            // Room Number
            var lblRoomNumber = new Label
            {
                Text = $"Room {room.RoomNumber}",
                Location = new Point(infoLeft, infoTop),
                AutoSize = true,
                Font = new Font("Segoe UI", 15, FontStyle.Bold),
                ForeColor = Color.FromArgb(34, 40, 49),
                BackColor = Color.Transparent
            };
            panel.Controls.Add(lblRoomNumber);
            // Room Type
            var lblType = new Label
            {
                Text = $"\uD83C\uDFE0  {room.RoomType}",
                Location = new Point(infoLeft, infoTop + infoSpacing),
                AutoSize = true,
                Font = new Font("Segoe UI", 11, FontStyle.Regular),
                ForeColor = Color.FromArgb(90, 100, 120),
                BackColor = Color.Transparent
            };
            panel.Controls.Add(lblType);
            // Price
            var lblPrice = new Label
            {
                Text = $"\uD83D\uDCB0  ${room.Price:F2}",
                Location = new Point(infoLeft, infoTop + 2 * infoSpacing),
                AutoSize = true,
                Font = new Font("Segoe UI", 11, FontStyle.Regular),
                ForeColor = Color.FromArgb(90, 100, 120),
                BackColor = Color.Transparent
            };
            panel.Controls.Add(lblPrice);
            // Capacity
            var lblCapacity = new Label
            {
                Text = $"👥  {room.Capacity}",
                Location = new Point(infoLeft, infoTop + 3 * infoSpacing),
                AutoSize = true,
                Font = new Font("Segoe UI", 11, FontStyle.Regular),
                ForeColor = Color.FromArgb(90, 100, 120),
                BackColor = Color.Transparent
            };
            panel.Controls.Add(lblCapacity);
            // Book Button
            var btnBook = new Button
            {
                Text = "Book",
                Location = new Point(infoLeft, infoTop + 4 * infoSpacing + 10),
                Width = 120,
                Height = 40,
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                BackColor = Color.FromArgb(54, 116, 181),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            btnBook.FlatAppearance.BorderSize = 0;
            btnBook.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 96, 161);
            btnBook.MouseEnter += (s, e) => btnBook.BackColor = Color.FromArgb(34, 96, 161);
            btnBook.MouseLeave += (s, e) => btnBook.BackColor = Color.FromArgb(54, 116, 181);
            btnBook.Click += (s, e) =>
            {
                BookRoomForm bookRoomForm = new BookRoomForm(room, Sessionn.UserId);
                this.Hide();
                bookRoomForm.FormClosed += (sender, args) => this.Show();
                bookRoomForm.ShowDialog();
            };
            panel.Controls.Add(btnBook);
            return panel;
        }

        private void BookRoomForm_Load(object sender, EventArgs e)
        {
            // Handle the event if needed
        }

        private void btnArrow_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Add this helper for rounded corners
        internal static class NativeMethods
        {
            [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
            public static extern IntPtr CreateRoundRectRgn(
                int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
        }
    }
}