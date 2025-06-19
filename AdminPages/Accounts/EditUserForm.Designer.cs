namespace HotelBooking.pages.Accounts
{
    partial class EditUserForm
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
            lookupUsers = new DevExpress.XtraEditors.SearchLookUpEdit();
            searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            txtUsername = new DevExpress.XtraEditors.TextEdit();
            txtEmail = new DevExpress.XtraEditors.TextEdit();
            txtPassword = new DevExpress.XtraEditors.TextEdit();
            cmbRole = new DevExpress.XtraEditors.ComboBoxEdit();
            lblUserId = new DevExpress.XtraEditors.LabelControl();
            btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            btnClear = new DevExpress.XtraEditors.SimpleButton();
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)lookupUsers.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)searchLookUpEdit1View).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtUsername.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtEmail.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPassword.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbRole.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            SuspendLayout();
            // 
            // lookupUsers
            // 
            lookupUsers.Location = new Point(91, 32);
            lookupUsers.Name = "lookupUsers";
            lookupUsers.Properties.Appearance.Font = new Font("Tahoma", 12F);
            lookupUsers.Properties.Appearance.Options.UseFont = true;
            lookupUsers.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            lookupUsers.Properties.NullText = "Select User";
            lookupUsers.Properties.PopupView = searchLookUpEdit1View;
            lookupUsers.Size = new Size(237, 26);
            lookupUsers.TabIndex = 0;
            lookupUsers.EditValueChanged += LookupUsers_EditValueChanged;
            // 
            // searchLookUpEdit1View
            // 
            searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(91, 91);
            txtUsername.Name = "txtUsername";
            txtUsername.Properties.Appearance.Font = new Font("Tahoma", 12F);
            txtUsername.Properties.Appearance.Options.UseFont = true;
            txtUsername.Size = new Size(237, 26);
            txtUsername.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(91, 150);
            txtEmail.Name = "txtEmail";
            txtEmail.Properties.Appearance.Font = new Font("Tahoma", 12F);
            txtEmail.Properties.Appearance.Options.UseFont = true;
            txtEmail.Size = new Size(237, 26);
            txtEmail.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(91, 211);
            txtPassword.Name = "txtPassword";
            txtPassword.Properties.Appearance.Font = new Font("Tahoma", 12F);
            txtPassword.Properties.Appearance.Options.UseFont = true;
            txtPassword.Properties.UseSystemPasswordChar = true;
            txtPassword.Size = new Size(237, 26);
            txtPassword.TabIndex = 3;
            // 
            // cmbRole
            // 
            cmbRole.Location = new Point(91, 271);
            cmbRole.Name = "cmbRole";
            cmbRole.Properties.Appearance.Font = new Font("Tahoma", 12F);
            cmbRole.Properties.Appearance.Options.UseFont = true;
            cmbRole.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cmbRole.Properties.Items.AddRange(new object[] { "Client", "Admin" });
            cmbRole.Size = new Size(237, 26);
            cmbRole.TabIndex = 4;
            // 
            // lblUserId
            // 
            lblUserId.Location = new Point(5, 4);
            lblUserId.Name = "lblUserId";
            lblUserId.Size = new Size(40, 13);
            lblUserId.TabIndex = 5;
            lblUserId.Text = "User ID:";
            // 
            // btnUpdate
            // 
            btnUpdate.Appearance.BackColor = Color.MediumBlue;
            btnUpdate.Appearance.Options.UseBackColor = true;
            btnUpdate.Location = new Point(244, 321);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(85, 35);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.Click += BtnUpdate_Click;
            // 
            // btnClear
            // 
            btnClear.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            btnClear.Appearance.Options.UseBackColor = true;
            btnClear.Location = new Point(91, 321);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(85, 35);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.Click += btnClear_Click;
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(label5);
            panelControl1.Controls.Add(lblUserId);
            panelControl1.Controls.Add(btnUpdate);
            panelControl1.Controls.Add(btnClear);
            panelControl1.Controls.Add(lookupUsers);
            panelControl1.Controls.Add(label4);
            panelControl1.Controls.Add(cmbRole);
            panelControl1.Controls.Add(label3);
            panelControl1.Controls.Add(txtPassword);
            panelControl1.Controls.Add(label2);
            panelControl1.Controls.Add(label1);
            panelControl1.Controls.Add(txtEmail);
            panelControl1.Controls.Add(txtUsername);
            panelControl1.Location = new Point(349, 100);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new Size(420, 370);
            panelControl1.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 10F);
            label5.ForeColor = Color.CadetBlue;
            label5.Location = new Point(179, 2);
            label5.Name = "label5";
            label5.Size = new Size(62, 17);
            label5.TabIndex = 8;
            label5.Text = "Edit User";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 10F);
            label4.Location = new Point(91, 251);
            label4.Name = "label4";
            label4.Size = new Size(34, 17);
            label4.TabIndex = 7;
            label4.Text = "Role";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10F);
            label3.Location = new Point(91, 191);
            label3.Name = "label3";
            label3.Size = new Size(66, 17);
            label3.TabIndex = 6;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10F);
            label2.Location = new Point(91, 130);
            label2.Name = "label2";
            label2.Size = new Size(39, 17);
            label2.TabIndex = 5;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10F);
            label1.Location = new Point(91, 71);
            label1.Name = "label1";
            label1.Size = new Size(69, 17);
            label1.TabIndex = 4;
            label1.Text = "Username";
            // 
            // EditUserForm
            // 
            Appearance.BackColor = Color.FromArgb(209, 248, 239);
            Appearance.Options.UseBackColor = true;
            Appearance.Options.UseFont = true;
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1118, 600);
            ControlBox = false;
            Controls.Add(panelControl1);
            Font = new Font("Segoe UI", 15F);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditUserForm";
            Text = "Edit User";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)lookupUsers.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)searchLookUpEdit1View).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtUsername.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtEmail.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPassword.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbRole.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            panelControl1.PerformLayout();
            ResumeLayout(false);



        }

        #endregion

        private DevExpress.XtraEditors.SearchLookUpEdit lookupUsers;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.TextEdit txtUsername;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.LabelControl lblUserId;
        private DevExpress.XtraEditors.SimpleButton btnClear;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}