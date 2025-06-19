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

namespace HotelBooking.pages.Accounts

{
    public partial class ResetPasswordForm : DevExpress.XtraEditors.XtraForm

    {
        private string connectionString = "Data Source=DESKTOP-SNC9H22\\MSSQLSERVER02; Initial Catalog=HotelDB; Integrated Security=True; TrustServerCertificate=True";
        public ResetPasswordForm()
        {
            InitializeComponent();
            LoadUsers();

        }
        private void LoadUsers()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT Id, username FROM login", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                lookupUsers.Properties.DataSource = dt;
                lookupUsers.Properties.DisplayMember = "username";
                lookupUsers.Properties.ValueMember = "Id";
            }
        }
        private void ClearForm()
        {
            lookupUsers.EditValue = null;
            textNewPassword.Text = "";
        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            if (lookupUsers.EditValue == null || string.IsNullOrWhiteSpace(textNewPassword.Text))
            {
                XtraMessageBox.Show("Please select a user and enter a new password.");
                return;
            }

            int userId = Convert.ToInt32(lookupUsers.EditValue);
            string newPassword = textNewPassword.Text;
            string errorMessage;
            if (!HotelBooking.Services.UserService.ValidatePassword(newPassword, out errorMessage))
            {
                XtraMessageBox.Show(errorMessage, "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();
            SqlCommand cmd = new SqlCommand("UPDATE login SET password = @password WHERE id = @id", conn);
            cmd.Parameters.AddWithValue("@password", newPassword);
            cmd.Parameters.AddWithValue("@id", userId);
            cmd.ExecuteNonQuery();

            XtraMessageBox.Show("Password reset successfully.");
            ClearForm();
        }
    }
}