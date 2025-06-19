using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using HotelBooking.pages.Accounts;
using HotelBooking.pages.Rooms;
using HotelBooking.pages.Bookings;
using HotelBooking.Models;
using HotelBooking.pages.Feedbacks;
using HotelBooking.pages.Main;

namespace HotelBooking
{
    public partial class Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Main()
        {
            InitializeComponent();
            this.Icon = new System.Drawing.Icon("hotelIcon.ico");
        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void CloseAllMdiChildren()
        {
            foreach (Form child in this.MdiChildren)
                child.Close();
        }

        private void viewAllUsersBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            CloseAllMdiChildren();
            AllUsersForm allUsersForm = new AllUsersForm();
            allUsersForm.MdiParent = this;
            allUsersForm.Show();
        }

        private void editUserBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            CloseAllMdiChildren();
            EditUserForm editUserForm = new EditUserForm();
            editUserForm.MdiParent = this;
            editUserForm.Show();
        }

        private void addUserBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            CloseAllMdiChildren();
            AddUserForm addUserForm = new AddUserForm();
            addUserForm.MdiParent = this;
            addUserForm.Show();
        }

        private void resetPasswordBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            CloseAllMdiChildren();
            ResetPasswordForm resetPasswordForm = new ResetPasswordForm();
            resetPasswordForm.MdiParent = this;
            resetPasswordForm.Show();
        }

        private void deleteUserBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            CloseAllMdiChildren();
            DeleteUserForm deleteUserForm = new DeleteUserForm();
            deleteUserForm.MdiParent = this;
            deleteUserForm.Show();
        }

        private void logoutBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult result = XtraMessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
                Application.Restart();
            }
        }

        private void viewRoomsBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            CloseAllMdiChildren();
            ViewAllRoom viewAllRoom = new ViewAllRoom();
            viewAllRoom.MdiParent = this;
            viewAllRoom.Show();
        }

        private void addRoomBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            CloseAllMdiChildren();
            AddRoomForm addRoomForm = new AddRoomForm();
            addRoomForm.MdiParent = this;
            addRoomForm.Show();
        }

        private void editRoomBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            CloseAllMdiChildren();
            EditRoomForm editRoomForm = new EditRoomForm();
            editRoomForm.MdiParent = this;
            editRoomForm.Show();
        }

        private void deleteRoomBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            CloseAllMdiChildren();
            DeleteRoomForm deleteRoomForm = new DeleteRoomForm();
            deleteRoomForm.MdiParent = this;
            deleteRoomForm.Show();
        }

        private void addBookingBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            CloseAllMdiChildren();
            AddBookingForm addBookingForm = new AddBookingForm();
            addBookingForm.MdiParent = this;
            addBookingForm.Show();
        }

        private void viewBookingsBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            CloseAllMdiChildren();
            ViewAllBookings viewAllBookings = new ViewAllBookings();
            viewAllBookings.MdiParent = this;
            viewAllBookings.Show();
        }

        private void deleteBookingBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            CloseAllMdiChildren();
            DeleteBookingForm deleteBookingForm = new DeleteBookingForm();
            deleteBookingForm.MdiParent = this;
            deleteBookingForm.Show();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            CloseAllMdiChildren();
            EditBookingForm editBookingForm = new EditBookingForm();
            editBookingForm.MdiParent = this;
            editBookingForm.Show();
        }

        private void viewFeedbackBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            CloseAllMdiChildren();
            ViewFeedbackForm viewFeedbackForm = new ViewFeedbackForm();
            viewFeedbackForm.MdiParent = this;
            viewFeedbackForm.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            CloseAllMdiChildren();
            HomePage homePage = new HomePage();
            homePage.MdiParent = this;
            homePage.Show();
        }
    }
}