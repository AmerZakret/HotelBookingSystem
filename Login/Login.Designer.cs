namespace HotelBooking
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            label3 = new Label();
            exitBtn = new Button();
            label1 = new Label();
            usernameBox = new TextBox();
            loginBtn = new Button();
            panel2 = new Panel();
            linkLabel1 = new LinkLabel();
            createAccoutLink = new LinkLabel();
            passwordBox = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
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
            panel1.TabIndex = 0;
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
            label3.Click += label3_Click_3;
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
            exitBtn.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 58);
            label1.Name = "label1";
            label1.Size = new Size(67, 17);
            label1.TabIndex = 1;
            label1.Text = "Username";
            label1.Click += label1_Click;
            // 
            // usernameBox
            // 
            usernameBox.Location = new Point(65, 78);
            usernameBox.Name = "usernameBox";
            usernameBox.Size = new Size(257, 25);
            usernameBox.TabIndex = 0;
            usernameBox.TextChanged += usernameBox_TextChanged;
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.FromArgb(54, 116, 181);
            loginBtn.Cursor = Cursors.Hand;
            loginBtn.FlatAppearance.BorderSize = 0;
            loginBtn.FlatStyle = FlatStyle.Flat;
            loginBtn.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginBtn.ForeColor = SystemColors.Control;
            loginBtn.Location = new Point(120, 205);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(134, 32);
            loginBtn.TabIndex = 3;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += button2_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(linkLabel1);
            panel2.Controls.Add(createAccoutLink);
            panel2.Controls.Add(loginBtn);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(passwordBox);
            panel2.Controls.Add(usernameBox);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(135, 144);
            panel2.Name = "panel2";
            panel2.Size = new Size(400, 330);
            panel2.TabIndex = 4;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabel1.LinkColor = Color.FromArgb(161, 117, 209);
            linkLabel1.Location = new Point(134, 185);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(108, 17);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Forgot password\r\n";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // createAccoutLink
            // 
            createAccoutLink.AutoSize = true;
            createAccoutLink.LinkColor = Color.FromArgb(161, 117, 209);
            createAccoutLink.Location = new Point(134, 253);
            createAccoutLink.Name = "createAccoutLink";
            createAccoutLink.Size = new Size(95, 17);
            createAccoutLink.TabIndex = 5;
            createAccoutLink.TabStop = true;
            createAccoutLink.Text = "Create account";
            createAccoutLink.LinkClicked += linkLabel2_LinkClicked;
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(65, 131);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(257, 25);
            passwordBox.TabIndex = 1;
            passwordBox.UseSystemPasswordChar = true;
            passwordBox.TextChanged += passwordBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 111);
            label2.Name = "label2";
            label2.Size = new Size(64, 17);
            label2.TabIndex = 1;
            label2.Text = "Password";
            label2.Click += label1_Click;
            // 
            // Login
            // 
            AcceptButton = loginBtn;
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(209, 248, 239);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            CancelButton = exitBtn;
            ClientSize = new Size(700, 600);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button exitBtn;
        private Label label1;
        private TextBox usernameBox;
        private Button loginBtn;
        private Panel panel2;
        private TextBox passwordBox;
        private Label label2;
        private LinkLabel createAccoutLink;
        private LinkLabel linkLabel1;
        private Label label3;
    }
}
