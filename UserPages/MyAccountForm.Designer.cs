namespace HotelBooking.UserPages
{
    partial class MyAccountForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblUsername = new Label();
            lblEmail = new Label();
            lblPassword = new Label();
            lblRole = new Label();
            txtUsername = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            txtRole = new TextBox();
            btnSave = new Button();
            btnArrow = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(700, 78);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "My Account";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUsername
            // 
            lblUsername.Font = new Font("Segoe UI", 14F);
            lblUsername.Location = new Point(93, 118);
            lblUsername.Margin = new Padding(4, 0, 4, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(140, 39);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Username:";
            // 
            // lblEmail
            // 
            lblEmail.Font = new Font("Segoe UI", 14F);
            lblEmail.Location = new Point(93, 183);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(140, 39);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email:";
            // 
            // lblPassword
            // 
            lblPassword.Font = new Font("Segoe UI", 14F);
            lblPassword.Location = new Point(93, 248);
            lblPassword.Margin = new Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(140, 39);
            lblPassword.TabIndex = 6;
            lblPassword.Text = "Password:";
            // 
            // lblRole
            // 
            lblRole.Font = new Font("Segoe UI", 14F);
            lblRole.Location = new Point(93, 314);
            lblRole.Margin = new Padding(4, 0, 4, 0);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(140, 39);
            lblRole.TabIndex = 8;
            lblRole.Text = "Role:";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 14F);
            txtUsername.Location = new Point(257, 118);
            txtUsername.Margin = new Padding(4, 4, 4, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(349, 32);
            txtUsername.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 14F);
            txtEmail.Location = new Point(257, 183);
            txtEmail.Margin = new Padding(4, 4, 4, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(349, 32);
            txtEmail.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 14F);
            txtPassword.Location = new Point(257, 248);
            txtPassword.Margin = new Padding(4, 4, 4, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(349, 32);
            txtPassword.TabIndex = 7;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtRole
            // 
            txtRole.Font = new Font("Segoe UI", 14F);
            txtRole.Location = new Point(257, 314);
            txtRole.Margin = new Padding(4, 4, 4, 4);
            txtRole.Name = "txtRole";
            txtRole.ReadOnly = true;
            txtRole.Size = new Size(349, 32);
            txtRole.TabIndex = 9;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(0, 122, 204);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(257, 392);
            btnSave.Margin = new Padding(4, 4, 4, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(175, 59);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnArrow
            // 
            btnArrow.BackColor = Color.FromArgb(209, 248, 239);
            btnArrow.Cursor = Cursors.Hand;
            btnArrow.FlatAppearance.BorderSize = 0;
            btnArrow.FlatStyle = FlatStyle.Flat;
            btnArrow.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnArrow.Location = new Point(12, 13);
            btnArrow.Margin = new Padding(4, 4, 4, 4);
            btnArrow.Name = "btnArrow";
            btnArrow.Size = new Size(52, 52);
            btnArrow.TabIndex = 0;
            btnArrow.Text = "←";
            btnArrow.UseVisualStyleBackColor = false;
            btnArrow.Click += btnArrow_Click;
            // 
            // MyAccountForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(209, 248, 239);
            ClientSize = new Size(700, 523);
            Controls.Add(btnArrow);
            Controls.Add(lblTitle);
            Controls.Add(lblUsername);
            Controls.Add(txtUsername);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(lblRole);
            Controls.Add(txtRole);
            Controls.Add(btnSave);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 4, 4, 4);
            MaximizeBox = false;
            Name = "MyAccountForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "My Account";
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnArrow;
    }
} 