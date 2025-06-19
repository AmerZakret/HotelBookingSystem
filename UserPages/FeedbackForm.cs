using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using HotelBooking.Services;

namespace HotelBooking.UserPages
{
    public partial class FeedbackForm : Form
    {
        private readonly string connectionString = "Data Source=DESKTOP-SNC9H22\\MSSQLSERVER02; Initial Catalog=HotelDB; Integrated Security=True; TrustServerCertificate=True";

        public FeedbackForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnArrow_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFeedback.Text))
            {
                MessageBox.Show("Please enter your feedback before submitting.", "Empty Feedback", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO Feedback (UserID, Message, SubmittedAt) VALUES (@userId, @message, @submittedAt)";
                    
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", Sessionn.UserId);
                        cmd.Parameters.AddWithValue("@message", txtFeedback.Text);
                        cmd.Parameters.AddWithValue("@submittedAt", DateTime.Now);
                        
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Thank you for your feedback!", "Feedback Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error submitting feedback: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
} 