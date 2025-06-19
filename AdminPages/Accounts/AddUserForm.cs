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
    public partial class AddUserForm : DevExpress.XtraEditors.XtraForm
    {
        public AddUserForm()
        {
            InitializeComponent();

        

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textUsername.Text = "";
            textEmail.Text = "";
            textPassword.Text = "";
            cmdRole.SelectedIndex = -1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-SNC9H22\\MSSQLSERVER02; Initial Catalog=HotelDB; Integrated Security=True; TrustServerCertificate=True");
            conn.Open();

            string username = textUsername.Text.Trim();
            string email = textEmail.Text.Trim();
            string password = textPassword.Text.Trim();
            string role = cmdRole.Text;

            if (username == "" || password == "" ||  email == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            string errorMessage;
            if (!HotelBooking.Services.UserService.ValidatePassword(password, out errorMessage))
            {
                MessageBox.Show(errorMessage, "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SqlCommand checkCmd = new SqlCommand("Select Count(*) from login Where username = @username", conn);
            checkCmd.Parameters.AddWithValue("@username", username);
            int exists = (int)checkCmd.ExecuteScalar();

            if (exists > 0)
            {
                MessageBox.Show("Username already exists.");
                conn.Close();
            }
            else
            {
                SqlCommand insertCmd = new SqlCommand("INSERT INTO login (username, password, email, role) VALUES (@username, @password, @email, @role)", conn);
                insertCmd.Parameters.AddWithValue("@username", username);
                insertCmd.Parameters.AddWithValue("@password", password);
                insertCmd.Parameters.AddWithValue("@email", email);
                insertCmd.Parameters.AddWithValue("@role", role);

                insertCmd.ExecuteNonQuery();
                MessageBox.Show("User added successfully");
                conn.Close();

            }
        }
    }
}