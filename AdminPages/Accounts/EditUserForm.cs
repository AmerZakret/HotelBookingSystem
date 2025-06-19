using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace HotelBooking.pages.Accounts
{
    public partial class EditUserForm : XtraForm

    {
        private string connectionString = "Data Source=DESKTOP-SNC9H22\\MSSQLSERVER02; Initial Catalog=HotelDB; Integrated Security=True; TrustServerCertificate=True";


        private ComboBoxEdit cmbRole = new ComboBoxEdit();
        private SimpleButton btnUpdate = new SimpleButton();


        public EditUserForm()
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
                int selectedId = Convert.ToInt32(lookupUsers.EditValue);
                LoadUserDetails(selectedId);
            }
        }

        private void LoadUserDetails(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM login WHERE Id = @Id", conn);
                cmd.Parameters.AddWithValue("@Id", id);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    txtUsername.Text = dr["username"].ToString();
                    txtEmail.Text = dr["email"].ToString();
                    txtPassword.Text = dr["password"].ToString();
                    cmbRole.Text = dr["role"].ToString();
                    lblUserId.Text = $"User ID: {id}";
                }
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (lookupUsers.EditValue == null)
            {
                XtraMessageBox.Show("Please select a user.");
                return;
            }

            int id = Convert.ToInt32(lookupUsers.EditValue);
            string username = txtUsername.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();
            string role = cmbRole.Text;

            string errorMessage;
            if (!HotelBooking.Services.UserService.ValidatePassword(password, out errorMessage))
            {
                XtraMessageBox.Show(errorMessage, "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "UPDATE login SET username = @username, email = @Email, password = @password, role = @role WHERE Id = @Id", conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@role", role);
                cmd.Parameters.AddWithValue("@Id", id);

                cmd.ExecuteNonQuery();
                XtraMessageBox.Show("User updated successfully!");
            }
        }

        private void ClearForm()
        {
            lookupUsers.EditValue = null;
            txtUsername.Text = "";
            txtEmail.Text = "";
            txtPassword.Text = "";
            cmbRole.SelectedIndex = -1;
            lblUserId.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}
