using System;
using System.Windows.Forms;
using HotelBooking.Services;
using System.Data.SqlClient;

namespace HotelBooking.UserPages
{
    public partial class MyAccountForm : Form
    {
        public MyAccountForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            LoadUserInfo();
        }

        private void LoadUserInfo()
        {
            // Load user info from Sessionn
            txtUsername.Text = Sessionn.Username;
            txtEmail.Text = GetUserEmail(Sessionn.UserId);
            txtPassword.Text = GetUserPassword(Sessionn.UserId);
            txtRole.Text = Sessionn.Role;
        }

        private string GetUserEmail(int userId)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-SNC9H22\\MSSQLSERVER02; Initial Catalog=HotelDB; Integrated Security=True; TrustServerCertificate=True"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT email FROM login WHERE ID = @id", conn);
                cmd.Parameters.AddWithValue("@id", userId);
                var result = cmd.ExecuteScalar();
                return result?.ToString() ?? "";
            }
        }

        private string GetUserPassword(int userId)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-SNC9H22\\MSSQLSERVER02; Initial Catalog=HotelDB; Integrated Security=True; TrustServerCertificate=True"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT password FROM login WHERE ID = @id", conn);
                cmd.Parameters.AddWithValue("@id", userId);
                var result = cmd.ExecuteScalar();
                return result?.ToString() ?? "";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-SNC9H22\\MSSQLSERVER02; Initial Catalog=HotelDB; Integrated Security=True; TrustServerCertificate=True"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE login SET username=@username, email=@email, password=@password WHERE ID=@id", conn);
                cmd.Parameters.AddWithValue("@username", txtUsername.Text.Trim());
                cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                cmd.Parameters.AddWithValue("@password", txtPassword.Text.Trim());
                cmd.Parameters.AddWithValue("@id", Sessionn.UserId);
                string password = txtPassword.Text.Trim();
                string errorMessage;
                if (!HotelBooking.Services.UserService.ValidatePassword(password, out errorMessage))
                {
                    MessageBox.Show(errorMessage, "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Account information updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnArrow_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
} 