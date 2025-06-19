using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Net;
using System.Net.Mail;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace HotelBooking
{
    public partial class ForgetPassword : Form
    {
        string code = new Random().Next(1000, 9999).ToString();
        public ForgetPassword()
        {
            InitializeComponent();
            this.Icon = new System.Drawing.Icon("hotelIcon.ico");
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-SNC9H22\\MSSQLSERVER02; Initial Catalog=HotelDB; Integrated Security=True; TrustServerCertificate=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM login WHERE email = @email", conn);
            cmd.Parameters.AddWithValue("@email", emailBox.Text);
            int count = (int)cmd.ExecuteScalar();
            conn.Close();
            if (count == 0)
            {
                MessageBox.Show("Email not found.");
            }

            else
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("amrzkrt@gmail.com");
                mail.To.Add(emailBox.Text);
                mail.Subject = "Your verification code";
                mail.Body = "Your code is: " + code;

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential("amrzkrt@gmail.com", "wywy dwsx inif hvvs");
                smtp.EnableSsl = true;
                smtp.Send(mail);
                MessageBox.Show("Verification code sent!");
            }
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-SNC9H22\\MSSQLSERVER02; Initial Catalog=HotelDB; Integrated Security=True; TrustServerCertificate=True");
            conn.Open();

            if (vCodeBox.Text == code)
            {
                MessageBox.Show("correct code.");
                conn.Close();
                newPasswordBox.Visible = true;
                newPassword.Visible = true;
                confirmNewPasswordBox.Visible = true;
                confirmNewPassword.Visible = true;
                resetBtn.Visible = true;
            }
            else
            {
                MessageBox.Show("Incorrect code.");
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            string newPassword = newPasswordBox.Text;
            string confirmPassword = confirmNewPasswordBox.Text;
            string email = emailBox.Text;

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Your password don't match!");
            }
            else if (!HotelBooking.Services.UserService.ValidatePassword(newPassword, out string errorMessage))
            {
                MessageBox.Show(errorMessage, "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-SNC9H22\\MSSQLSERVER02; Initial Catalog=HotelDB; Integrated Security=True; TrustServerCertificate=True");
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE login SET password = @password WHERE email = @email", conn);
                cmd.Parameters.AddWithValue("@password", newPassword);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Password updated successfully.");
                this.Hide();
                using (var login = new Login())
                {
                    login.ShowDialog();
                }
                this.Close();
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var login = new Login())
            {
                login.ShowDialog();
            }
            this.Close();
        }
    }
}
