namespace HotelBooking
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            panel2 = new Panel();
            backBtn = new Button();
            linkLabel2 = new LinkLabel();
            signinBtn = new Button();
            label3 = new Label();
            label1 = new Label();
            confirmPasswordBox = new TextBox();
            passwordBox = new TextBox();
            emailBox = new TextBox();
            label5 = new Label();
            usernameBox = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            label4 = new Label();
            exitBtn = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(209, 248, 239);
            panel2.Controls.Add(backBtn);
            panel2.Controls.Add(linkLabel2);
            panel2.Controls.Add(signinBtn);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(confirmPasswordBox);
            panel2.Controls.Add(passwordBox);
            panel2.Controls.Add(emailBox);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(usernameBox);
            panel2.Controls.Add(label2);
            panel2.Cursor = Cursors.IBeam;
            panel2.Location = new Point(135, 124);
            panel2.Name = "panel2";
            panel2.Size = new Size(400, 380);
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
            backBtn.TabIndex = 6;
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.LinkColor = Color.FromArgb(161, 117, 209);
            linkLabel2.Location = new Point(142, 276);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(0, 17);
            linkLabel2.TabIndex = 5;
            // 
            // signinBtn
            // 
            signinBtn.BackColor = Color.FromArgb(54, 116, 181);
            signinBtn.Cursor = Cursors.Hand;
            signinBtn.FlatAppearance.BorderSize = 0;
            signinBtn.FlatStyle = FlatStyle.Flat;
            signinBtn.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signinBtn.ForeColor = SystemColors.Control;
            signinBtn.Location = new Point(116, 287);
            signinBtn.Name = "signinBtn";
            signinBtn.Size = new Size(134, 32);
            signinBtn.TabIndex = 3;
            signinBtn.Text = "Sign in";
            signinBtn.UseVisualStyleBackColor = false;
            signinBtn.Click += signinBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(67, 62);
            label3.Name = "label3";
            label3.Size = new Size(39, 17);
            label3.TabIndex = 1;
            label3.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 110);
            label1.Name = "label1";
            label1.Size = new Size(67, 17);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // confirmPasswordBox
            // 
            confirmPasswordBox.Location = new Point(67, 236);
            confirmPasswordBox.Name = "confirmPasswordBox";
            confirmPasswordBox.Size = new Size(257, 25);
            confirmPasswordBox.TabIndex = 2;
            confirmPasswordBox.UseSystemPasswordChar = true;
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(67, 183);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(257, 25);
            passwordBox.TabIndex = 2;
            passwordBox.UseSystemPasswordChar = true;
            // 
            // emailBox
            // 
            emailBox.Location = new Point(67, 82);
            emailBox.Name = "emailBox";
            emailBox.Size = new Size(257, 25);
            emailBox.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(67, 216);
            label5.Name = "label5";
            label5.Size = new Size(114, 17);
            label5.TabIndex = 1;
            label5.Text = "Confirm Password";
            // 
            // usernameBox
            // 
            usernameBox.Location = new Point(67, 130);
            usernameBox.Name = "usernameBox";
            usernameBox.Size = new Size(257, 25);
            usernameBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 163);
            label2.Name = "label2";
            label2.Size = new Size(64, 17);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(54, 116, 181);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(exitBtn);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(700, 40);
            panel1.TabIndex = 6;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Left;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(161, 227, 249);
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(206, 40);
            label4.TabIndex = 1;
            label4.Text = "Hotel Management";
            label4.TextAlign = ContentAlignment.MiddleLeft;
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
            // Register
            // 
            AcceptButton = signinBtn;
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            CancelButton = exitBtn;
            ClientSize = new Size(700, 600);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(panel2);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sign in";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private LinkLabel linkLabel2;
        private Button signinBtn;
        private Label label1;
        private TextBox passwordBox;
        private TextBox usernameBox;
        private Label label2;
        private Label label3;
        private TextBox emailBox;
        private Panel panel1;
        private Label label4;
        private Button exitBtn;
        private TextBox confirmPasswordBox;
        private Label label5;
        private Button backBtn;
    }
}