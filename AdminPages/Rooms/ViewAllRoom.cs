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
using HotelBooking.Services;
using HotelBooking.Models;

namespace HotelBooking.pages.Rooms
{
	public partial class ViewAllRoom: DevExpress.XtraEditors.XtraForm
	{
        RoomService roomService;
        public ViewAllRoom()
		{
            InitializeComponent();
            string conn = "Data Source=DESKTOP-SNC9H22\\MSSQLSERVER02; Initial Catalog=HotelDB; Integrated Security=True; TrustServerCertificate=True";
            roomService = new RoomService(conn);
            LoadRooms();
        }

        private void LoadRooms()
        {
            try
            {
                List<Room> rooms = roomService.GetAllRooms();
                gridRooms.DataSource = rooms;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}