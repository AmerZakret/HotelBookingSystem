namespace HotelBooking.pages.Accounts
{
    partial class AddUserForm
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
            textUsername = new DevExpress.XtraEditors.TextEdit();
            textEmail = new DevExpress.XtraEditors.TextEdit();
            textPassword = new DevExpress.XtraEditors.TextEdit();
            cmdRole = new DevExpress.XtraEditors.ComboBoxEdit();
            btnAdd = new DevExpress.XtraEditors.SimpleButton();
            btnClear = new DevExpress.XtraEditors.SimpleButton();
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)textUsername.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEmail.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textPassword.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmdRole.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            SuspendLayout();
            // 
            // textUsername
            // 
            textUsername.Location = new Point(92, 60);
            textUsername.Name = "textUsername";
            textUsername.Properties.Appearance.Font = new Font("Tahoma", 12F);
            textUsername.Properties.Appearance.Options.UseFont = true;
            textUsername.Size = new Size(237, 26);
            textUsername.TabIndex = 0;
            // 
            // textEmail
            // 
            textEmail.Location = new Point(92, 120);
            textEmail.Name = "textEmail";
            textEmail.Properties.Appearance.Font = new Font("Tahoma", 12F);
            textEmail.Properties.Appearance.Options.UseFont = true;
            textEmail.Size = new Size(237, 26);
            textEmail.TabIndex = 0;
            // 
            // textPassword
            // 
            textPassword.Location = new Point(92, 180);
            textPassword.Name = "textPassword";
            textPassword.Properties.Appearance.Font = new Font("Tahoma", 12F);
            textPassword.Properties.Appearance.Options.UseFont = true;
            textPassword.Properties.UseSystemPasswordChar = true;
            textPassword.Size = new Size(237, 26);
            textPassword.TabIndex = 0;
            // 
            // cmdRole
            // 
            cmdRole.Location = new Point(92, 240);
            cmdRole.Name = "cmdRole";
            cmdRole.Properties.Appearance.Font = new Font("Tahoma", 12F);
            cmdRole.Properties.Appearance.Options.UseFont = true;
            cmdRole.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cmdRole.Properties.Items.AddRange(new object[] { "Client", "Admin" });
            cmdRole.Size = new Size(237, 26);
            cmdRole.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Appearance.BackColor = Color.Green;
            btnAdd.Appearance.Options.UseBackColor = true;
            btnAdd.Location = new Point(243, 303);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(85, 35);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClear
            // 
            btnClear.Appearance.BackColor = Color.FromArgb(220, 53, 69);
            btnClear.Appearance.Options.UseBackColor = true;
            btnClear.Location = new Point(92, 303);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(85, 35);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.Click += btnClear_Click;
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(label5);
            panelControl1.Controls.Add(label4);
            panelControl1.Controls.Add(label3);
            panelControl1.Controls.Add(label2);
            panelControl1.Controls.Add(label1);
            panelControl1.Controls.Add(cmdRole);
            panelControl1.Controls.Add(btnClear);
            panelControl1.Controls.Add(textUsername);
            panelControl1.Controls.Add(btnAdd);
            panelControl1.Controls.Add(textEmail);
            panelControl1.Controls.Add(textPassword);
            panelControl1.Location = new Point(349, 100);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new Size(420, 370);
            panelControl1.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 10F);
            label5.ForeColor = Color.CadetBlue;
            label5.Location = new Point(179, 2);
            label5.Name = "label5";
            label5.Size = new Size(63, 17);
            label5.TabIndex = 8;
            label5.Text = "Add User";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 10F);
            label4.Location = new Point(92, 220);
            label4.Name = "label4";
            label4.Size = new Size(34, 17);
            label4.TabIndex = 7;
            label4.Text = "Role";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10F);
            label3.Location = new Point(92, 160);
            label3.Name = "label3";
            label3.Size = new Size(66, 17);
            label3.TabIndex = 6;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10F);
            label2.Location = new Point(92, 100);
            label2.Name = "label2";
            label2.Size = new Size(39, 17);
            label2.TabIndex = 5;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10F);
            label1.Location = new Point(92, 40);
            label1.Name = "label1";
            label1.Size = new Size(69, 17);
            label1.TabIndex = 4;
            label1.Text = "Username";
            // 
            // AddUserForm
            // 
            Appearance.BackColor = Color.FromArgb(209, 248, 239);
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1118, 600);
            ControlBox = false;
            Controls.Add(panelControl1);
            FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "AddUserForm";
            Text = "AddUserForm";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)textUsername.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEmail.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textPassword.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmdRole.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            panelControl1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.TextEdit textUsername;
        private DevExpress.XtraEditors.TextEdit textEmail;
        private DevExpress.XtraEditors.TextEdit textPassword;
        private DevExpress.XtraEditors.ComboBoxEdit cmdRole;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnClear;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label5;
    }
}