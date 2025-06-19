namespace HotelBooking.pages.Accounts
{
    partial class ResetPasswordForm
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
            textNewPassword = new DevExpress.XtraEditors.TextEdit();
            btnReset = new DevExpress.XtraEditors.SimpleButton();
            btnClear = new DevExpress.XtraEditors.SimpleButton();
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            label1 = new Label();
            lblInfo = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)lookupUsers.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)searchLookUpEdit1View).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textNewPassword.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            SuspendLayout();
            // 
            // lookupUsers
            // 
            lookupUsers.Location = new Point(92, 107);
            lookupUsers.Name = "lookupUsers";
            lookupUsers.Properties.Appearance.Font = new Font("Tahoma", 12F);
            lookupUsers.Properties.Appearance.Options.UseFont = true;
            lookupUsers.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            lookupUsers.Properties.DisplayMember = "username";
            lookupUsers.Properties.NullText = "Select User";
            lookupUsers.Properties.PopupView = searchLookUpEdit1View;
            lookupUsers.Properties.ValueMember = "id";
            lookupUsers.Size = new Size(237, 26);
            lookupUsers.TabIndex = 0;
            // 
            // searchLookUpEdit1View
            // 
            searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // textNewPassword
            // 
            textNewPassword.Location = new Point(92, 158);
            textNewPassword.Name = "textNewPassword";
            textNewPassword.Properties.Appearance.Font = new Font("Tahoma", 12F);
            textNewPassword.Properties.Appearance.Options.UseFont = true;
            textNewPassword.Size = new Size(237, 26);
            textNewPassword.TabIndex = 1;
            // 
            // btnReset
            // 
            btnReset.Appearance.BackColor = Color.Green;
            btnReset.Appearance.Options.UseBackColor = true;
            btnReset.Location = new Point(244, 220);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(85, 35);
            btnReset.TabIndex = 2;
            btnReset.Text = "Reset";
            btnReset.Click += btnReset_Click;
            // 
            // btnClear
            // 
            btnClear.Appearance.BackColor = Color.FromArgb(220, 53, 69);
            btnClear.Appearance.Options.UseBackColor = true;
            btnClear.Location = new Point(92, 220);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(85, 35);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(label1);
            panelControl1.Controls.Add(btnClear);
            panelControl1.Controls.Add(lblInfo);
            panelControl1.Controls.Add(btnReset);
            panelControl1.Controls.Add(textNewPassword);
            panelControl1.Controls.Add(lookupUsers);
            panelControl1.Location = new Point(349, 100);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new Size(420, 370);
            panelControl1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F);
            label1.ForeColor = Color.CadetBlue;
            label1.Location = new Point(143, 12);
            label1.Name = "label1";
            label1.Size = new Size(119, 19);
            label1.TabIndex = 4;
            label1.Text = "Reset Password";
            // 
            // lblInfo
            // 
            lblInfo.Location = new Point(34, 69);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(0, 13);
            lblInfo.TabIndex = 1;
            // 
            // ResetPasswordForm
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
            MinimizeBox = false;
            Name = "ResetPasswordForm";
            Text = "ResetPasswordForm";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)lookupUsers.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)searchLookUpEdit1View).EndInit();
            ((System.ComponentModel.ISupportInitialize)textNewPassword.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            panelControl1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.SearchLookUpEdit lookupUsers;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.TextEdit textNewPassword;
        private DevExpress.XtraEditors.SimpleButton btnReset;
        private DevExpress.XtraEditors.SimpleButton btnClear;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private Label label1;
        private DevExpress.XtraEditors.LabelControl lblInfo;
    }
}