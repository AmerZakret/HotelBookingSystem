using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelBooking.Models;
using Microsoft.Data.SqlClient;

namespace HotelBooking
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            this.Icon = new System.Drawing.Icon("hotelIcon.ico");
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signinBtn_Click(object sender, EventArgs e)
        {
            string username = usernameBox.Text;
            string password = passwordBox.Text;
            string confirmPassword = confirmPasswordBox.Text;
            string email = emailBox.Text;

            if (username == "" || password == "" || confirmPassword == "" || email == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-SNC9H22\\MSSQLSERVER02; Initial Catalog=HotelDB; Integrated Security=True; TrustServerCertificate=True");
            conn.Open();

            SqlCommand checkCmd = new SqlCommand("Select Count(*) from login Where username = @username", conn);
            checkCmd.Parameters.AddWithValue("@username", username);
            int exists = (int)checkCmd.ExecuteScalar();

            if (exists > 0)
            {
                MessageBox.Show("Username already exists.");
                conn.Close();
            }
            else if (password != confirmPassword)
            {
                MessageBox.Show("Your password don't match!");
                return;
            }
            else if (!HotelBooking.Services.UserService.ValidatePassword(password, out string errorMessage))
            {
                MessageBox.Show(errorMessage, "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                SqlCommand insertCmd = new SqlCommand("INSERT INTO login (username, password, email, role) VALUES (@username, @password, @email, @role)", conn);
                insertCmd.Parameters.AddWithValue("@username", username);
                insertCmd.Parameters.AddWithValue("@password", password);
                insertCmd.Parameters.AddWithValue("@email", email);
                insertCmd.Parameters.AddWithValue("@role", "client");

                insertCmd.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("Account created successfully!");
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
