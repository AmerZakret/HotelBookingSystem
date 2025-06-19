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
    public partial class DeleteUserForm : DevExpress.XtraEditors.XtraForm
    {
        private string connectionString = "Data Source=DESKTOP-SNC9H22\\MSSQLSERVER02; Initial Catalog=HotelDB; Integrated Security=True; TrustServerCertificate=True";
        public DeleteUserForm()
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
        private void LookupUsers_EditValueChanged(object sender, EventArgs e)
        {
            if (lookupUsers.EditValue != null)
            {
                int userId = Convert.ToInt32(lookupUsers.EditValue);
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT username, email FROM login WHERE Id = @id", conn);
                    cmd.Parameters.AddWithValue("@id", userId);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        lblInfo.Text = $"Username: {reader["username"]}, Email: {reader["email"]}";
                    }
                }
            }
        }
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (lookupUsers.EditValue == null)
            {
                XtraMessageBox.Show("Please select a user.");
                return;
            }

            int userId = Convert.ToInt32(lookupUsers.EditValue);
            DialogResult confirm = XtraMessageBox.Show("Are you sure you want to delete this user?", "Confirm", MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    // First, delete feedback for this user
                    SqlCommand deleteFeedbackCmd = new SqlCommand("DELETE FROM Feedback WHERE UserID = @id", conn);
                    deleteFeedbackCmd.Parameters.AddWithValue("@id", userId);
                    deleteFeedbackCmd.ExecuteNonQuery();

                    // Then, delete bookings for this user
                    SqlCommand deleteBookingsCmd = new SqlCommand("DELETE FROM Booking WHERE UserID = @id", conn);
                    deleteBookingsCmd.Parameters.AddWithValue("@id", userId);
                    deleteBookingsCmd.ExecuteNonQuery();

                    // Now delete the user
                    SqlCommand cmd = new SqlCommand("DELETE FROM login WHERE Id = @id", conn);
                    cmd.Parameters.AddWithValue("@id", userId);
                    cmd.ExecuteNonQuery();
                }

                XtraMessageBox.Show("User deleted successfully.");
                ClearForm();
                LoadUsers();
            }
        }

        private void ClearForm()
        {
            lookupUsers.EditValue = null;
            lblInfo.Text = "";
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}