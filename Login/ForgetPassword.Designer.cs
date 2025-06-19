namespace HotelBooking
{
    partial class ForgetPassword
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgetPassword));
            panel2 = new Panel();
            backBtn = new Button();
            resetBtn = new Button();
            confirmBtn = new Button();
            sendBtn = new Button();
            confirmNewPassword = new Label();
            newPassword = new Label();
            vCode = new Label();
            email = new Label();
            confirmNewPasswordBox = new TextBox();
            newPasswordBox = new TextBox();
            vCodeBox = new TextBox();
            emailBox = new TextBox();
            panel1 = new Panel();
            label3 = new Label();
            exitBtn = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(209, 248, 239);
            panel2.Controls.Add(backBtn);
            panel2.Controls.Add(resetBtn);
            panel2.Controls.Add(confirmBtn);
            panel2.Controls.Add(sendBtn);
            panel2.Controls.Add(confirmNewPassword);
            panel2.Controls.Add(newPassword);
            panel2.Controls.Add(vCode);
            panel2.Controls.Add(email);
            panel2.Controls.Add(confirmNewPasswordBox);
            panel2.Controls.Add(newPasswordBox);
            panel2.Controls.Add(vCodeBox);
            panel2.Controls.Add(emailBox);
            panel2.Location = new Point(135, 90);
            panel2.Name = "panel2";
            panel2.Size = new Size(400, 443);
            panel2.TabIndex = 5;
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.FromArgb(209, 248, 239);
            backBtn.BackgroundImage = Properties.Resources.pngtree_vector_back_icon_png_image_931209_Photoroom;
            backBtn.BackgroundImageLayout = ImageLayout.Stretch;
            backBtn.Cursor = Cursors.Hand;
            backBtn.FlatAppearance.BorderSize = 0;
            backBtn.FlatStyle = FlatStyle.Flat;
            backBtn.Location = new Point(3, 3);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(41, 41);
            backBtn.TabIndex = 4;
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // resetBtn
            // 
            resetBtn.BackColor = Color.FromArgb(54, 116, 181);
            resetBtn.Cursor = Cursors.Hand;
            resetBtn.FlatAppearance.BorderSize = 0;
            resetBtn.FlatStyle = FlatStyle.Flat;
            resetBtn.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            resetBtn.ForeColor = SystemColors.Control;
            resetBtn.Location = new Point(141, 376);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(134, 32);
            resetBtn.TabIndex = 3;
            resetBtn.Text = "Reset";
            resetBtn.UseVisualStyleBackColor = false;
            resetBtn.Visible = false;
            resetBtn.Click += resetBtn_Click;
            // 
            // confirmBtn
            // 
            confirmBtn.BackColor = Color.FromArgb(54, 116, 181);
            confirmBtn.Cursor = Cursors.Hand;
            confirmBtn.FlatAppearance.BorderSize = 0;
            confirmBtn.FlatStyle = FlatStyle.Flat;
            confirmBtn.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            confirmBtn.ForeColor = SystemColors.Control;
            confirmBtn.Location = new Point(141, 215);
            confirmBtn.Name = "confirmBtn";
            confirmBtn.Size = new Size(134, 32);
            confirmBtn.TabIndex = 3;
            confirmBtn.Text = "Confirm";
            confirmBtn.UseVisualStyleBackColor = false;
            confirmBtn.Click += confirmBtn_Click;
            // 
            // sendBtn
            // 
            sendBtn.BackColor = Color.FromArgb(54, 116, 181);
            sendBtn.Cursor = Cursors.Hand;
            sendBtn.FlatAppearance.BorderSize = 0;
            sendBtn.FlatStyle = FlatStyle.Flat;
            sendBtn.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sendBtn.ForeColor = SystemColors.Control;
            sendBtn.Location = new Point(141, 114);
            sendBtn.Name = "sendBtn";
            sendBtn.Size = new Size(134, 32);
            sendBtn.TabIndex = 3;
            sendBtn.Text = "Send";
            sendBtn.UseVisualStyleBackColor = false;
            sendBtn.Click += sendBtn_Click;
            // 
            // confirmNewPassword
            // 
            confirmNewPassword.AutoSize = true;
            confirmNewPassword.Location = new Point(87, 315);
            confirmNewPassword.Name = "confirmNewPassword";
            confirmNewPassword.Size = new Size(114, 17);
            confirmNewPassword.TabIndex = 1;
            confirmNewPassword.Text = "Confirm Password";
            confirmNewPassword.Visible = false;
            // 
            // newPassword
            // 
            newPassword.AutoSize = true;
            newPassword.Location = new Point(87, 263);
            newPassword.Name = "newPassword";
            newPassword.Size = new Size(94, 17);
            newPassword.TabIndex = 1;
            newPassword.Text = "New Password";
            newPassword.Visible = false;
            // 
            // vCode
            // 
            vCode.AutoSize = true;
            vCode.Location = new Point(87, 155);
            vCode.Name = "vCode";
            vCode.Size = new Size(69, 17);
            vCode.TabIndex = 1;
            vCode.Text = "Your Code";
            // 
            // email
            // 
            email.AutoSize = true;
            email.Location = new Point(87, 53);
            email.Name = "email";
            email.Size = new Size(39, 17);
            email.TabIndex = 1;
            email.Text = "Email";
            // 
            // confirmNewPasswordBox
            // 
            confirmNewPasswordBox.Cursor = Cursors.IBeam;
            confirmNewPasswordBox.Location = new Point(87, 335);
            confirmNewPasswordBox.Name = "confirmNewPasswordBox";
            confirmNewPasswordBox.Size = new Size(257, 25);
            confirmNewPasswordBox.TabIndex = 2;
            confirmNewPasswordBox.Visible = false;
            // 
            // newPasswordBox
            // 
            newPasswordBox.Cursor = Cursors.IBeam;
            newPasswordBox.Location = new Point(87, 283);
            newPasswordBox.Name = "newPasswordBox";
            newPasswordBox.Size = new Size(257, 25);
            newPasswordBox.TabIndex = 2;
            newPasswordBox.Visible = false;
            // 
            // vCodeBox
            // 
            vCodeBox.Cursor = Cursors.IBeam;
            vCodeBox.Location = new Point(87, 175);
            vCodeBox.Name = "vCodeBox";
            vCodeBox.Size = new Size(257, 25);
            vCodeBox.TabIndex = 2;
            // 
            // emailBox
            // 
            emailBox.Cursor = Cursors.IBeam;
            emailBox.Location = new Point(87, 73);
            emailBox.Name = "emailBox";
            emailBox.Size = new Size(257, 25);
            emailBox.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(54, 116, 181);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(exitBtn);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(700, 40);
            panel1.TabIndex = 6;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Left;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(161, 227, 249);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(206, 40);
            label3.TabIndex = 1;
            label3.Text = "Hotel Management";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // exitBtn
            // 
            exitBtn.BackColor = Color.FromArgb(54, 116, 181);
            exitBtn.BackgroundImage = (Image)resources.GetObject("exitBtn.BackgroundImage");
            exitBtn.BackgroundImageLayout = ImageLayout.Center;
            exitBtn.Dock = DockStyle.Right;
            exitBtn.FlatAppearance.BorderSize = 0;
            exitBtn.FlatStyle = FlatStyle.Flat;
            exitBtn.Location = new Point(663, 0);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(37, 40);
            exitBtn.TabIndex = 0;
            exitBtn.UseVisualStyleBackColor = false;
            exitBtn.Click += exitBtn_Click;
            // 
            // ForgetPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            CancelButton = exitBtn;
            ClientSize = new Size(700, 600);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ForgetPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Forget Password";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button sendBtn;
        private Panel panel1;
        private Label label3;
        private Button exitBtn;
        private Button confirmBtn;
        private Label vCode;
        private Label email;
        private TextBox vCodeBox;
        private TextBox emailBox;
        private Button resetBtn;
        private Label confirmNewPassword;
        private Label newPassword;
        private TextBox confirmNewPasswordBox;
        private TextBox newPasswordBox;
        private Button backBtn;
    }
}