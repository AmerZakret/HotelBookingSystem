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

namespace HotelBooking.UserPages
{
    public partial class UserMain : DevExpress.XtraEditors.XtraForm
    {
        public UserMain()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Icon = new System.Drawing.Icon("hotelIcon.ico");
            welcomeTxt.Text = $"Welcome {Sessionn.Username}";
            welcomeTxt.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            welcomeTxt.Width = this.ClientSize.Width;
            welcomeTxt.Left = (this.ClientSize.Width - welcomeTxt.Width) / 2;

            // Place the logout button on the form, not the panel
            btnLogout.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnLogout.Location = new Point(this.ClientSize.Width - btnLogout.Width - 20, this.ClientSize.Height - btnLogout.Height - 20);
            this.Controls.Add(btnLogout);
            btnLogout.BringToFront();
            this.Resize += (s, e) => {
                btnLogout.Location = new Point(this.ClientSize.Width - btnLogout.Width - 20, this.ClientSize.Height - btnLogout.Height - 20);
            };
        }

        private void tileViewRooms_ItemClick(object sender, TileItemEventArgs e)
        {
            var form = new ViewAvailableRoomsForm();
            this.Hide();
            form.FormClosed += (s, args) => this.Show();
            form.ShowDialog();
        }

        private void tileBookRoom_ItemClick(object sender, TileItemEventArgs e)
        {
            var form = new MyAccountForm();
            this.Hide();
            form.FormClosed += (s, args) => this.Show();
            form.ShowDialog();
        }

        private void tileMyBookings_ItemClick(object sender, TileItemEventArgs e)
        {
            var form = new ViewMyBookingsForm();
            this.Hide();
            form.FormClosed += (s, args) => this.Show();
            form.ShowDialog();
        }

        private void tileFeedback_ItemClick(object sender, TileItemEventArgs e)
        {
            var form = new FeedbackForm();
            this.Hide();
            form.FormClosed += (s, args) => this.Show();
            form.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Restart();
        }
    }
}