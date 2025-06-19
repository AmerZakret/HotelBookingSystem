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
using DevExpress.XtraReports.Design;



namespace HotelBooking.pages.Accounts
{

    public partial class AllUsersForm : DevExpress.XtraEditors.XtraForm
    {
        private UserService userService;
        public AllUsersForm()
        {
            InitializeComponent();

            string conn = "Data Source=DESKTOP-SNC9H22\\MSSQLSERVER02; Initial Catalog=HotelDB; Integrated Security=True; TrustServerCertificate=True";
            userService = new UserService(conn);
        }

        private void AllUsersForm_Load(object sender, EventArgs e)
        {
            var users = userService.GetAllUsers();
            gridControl1.DataSource = users;

        }
    }
}