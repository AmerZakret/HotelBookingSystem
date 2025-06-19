using DevExpress.Xpo;
using Microsoft.Data.SqlClient;
using HotelBooking.Services;
using HotelBooking.UserPages;
using HotelBooking.Models;

namespace HotelBooking
{
    public partial class Login : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-SNC9H22\\MSSQLSERVER02; Initial catalog=HotelDB; Integrated Security=TRUE;TrustServerCertificate=True");

        public Login()
        {
            InitializeComponent();
            this.Icon = new System.Drawing.Icon("hotelIcon.ico");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = usernameBox.Text;
            string password = passwordBox.Text;


            bool registerd = false;


            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from login", conn);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                if (username == dr["username"].ToString() && password == dr["password"].ToString())
                {
                    Sessionn.UserId = Convert.ToInt32(dr["ID"]);
                    Sessionn.Username = dr["username"].ToString();
                    Sessionn.Role = dr["role"].ToString();
                    registerd = true;
                    break;
                }
            }
            conn.Close();

            if (registerd == true) { 
                
                
                MessageBox.Show("Successful");
                UserRole = Sessionn.Role;
                this.DialogResult = DialogResult.OK;
                this.Close();

            }

            else MessageBox.Show("Failed");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            using (var register = new Register())
            {
                register.ShowDialog();
            }
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click_2(object sender, EventArgs e)
        {

        }

        private void label3_Click_3(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void usernameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            using (var forgetPassword = new ForgetPassword())
            {
                forgetPassword.ShowDialog();
            }
            this.Close();
        }

        public string UserRole { get; private set; }
    }
}
