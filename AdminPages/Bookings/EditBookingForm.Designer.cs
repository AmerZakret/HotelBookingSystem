namespace HotelBooking.pages.Bookings
{
    partial class EditBookingForm
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
            bookingLookUpEdit = new DevExpress.XtraEditors.SearchLookUpEdit();
            searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            userLookUpEdit = new DevExpress.XtraEditors.SearchLookUpEdit();
            searchLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            roomLookUpEdit = new DevExpress.XtraEditors.SearchLookUpEdit();
            searchLookUpEdit3View = new DevExpress.XtraGrid.Views.Grid.GridView();
            guestName = new DevExpress.XtraEditors.TextEdit();
            totalPrice = new DevExpress.XtraEditors.TextEdit();
            statusCombo = new DevExpress.XtraEditors.ComboBoxEdit();
            cancelBtn = new DevExpress.XtraEditors.SimpleButton();
            updateBtn = new DevExpress.XtraEditors.SimpleButton();
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)bookingLookUpEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)searchLookUpEdit1View).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userLookUpEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)searchLookUpEdit2View).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roomLookUpEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)searchLookUpEdit3View).BeginInit();
            ((System.ComponentModel.ISupportInitialize)guestName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)totalPrice.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)statusCombo.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            SuspendLayout();
            // 
            // bookingLookUpEdit
            // 
            bookingLookUpEdit.Location = new Point(91, 35);
            bookingLookUpEdit.Name = "bookingLookUpEdit";
            bookingLookUpEdit.Properties.Appearance.Font = new Font("Tahoma", 10F);
            bookingLookUpEdit.Properties.Appearance.Options.UseFont = true;
            bookingLookUpEdit.Properties.AutoHeight = false;
            bookingLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            bookingLookUpEdit.Properties.NullText = "Select Booking";
            bookingLookUpEdit.Properties.PopupView = searchLookUpEdit1View;
            bookingLookUpEdit.Size = new Size(237, 26);
            bookingLookUpEdit.TabIndex = 0;
            bookingLookUpEdit.EditValueChanged += BookingLookUpEdit_EditValueChanged;
            // 
            // searchLookUpEdit1View
            // 
            searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // userLookUpEdit
            // 
            userLookUpEdit.Location = new Point(91, 72);
            userLookUpEdit.Name = "userLookUpEdit";
            userLookUpEdit.Properties.Appearance.Font = new Font("Tahoma", 10F);
            userLookUpEdit.Properties.Appearance.Options.UseFont = true;
            userLookUpEdit.Properties.AutoHeight = false;
            userLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            userLookUpEdit.Properties.NullText = "Select User";
            userLookUpEdit.Properties.PopupView = searchLookUpEdit2View;
            userLookUpEdit.Size = new Size(237, 26);
            userLookUpEdit.TabIndex = 1;
            // 
            // searchLookUpEdit2View
            // 
            searchLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            searchLookUpEdit2View.Name = "searchLookUpEdit2View";
            searchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            searchLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // roomLookUpEdit
            // 
            roomLookUpEdit.Location = new Point(91, 110);
            roomLookUpEdit.Name = "roomLookUpEdit";
            roomLookUpEdit.Properties.Appearance.Font = new Font("Tahoma", 10F);
            roomLookUpEdit.Properties.Appearance.Options.UseFont = true;
            roomLookUpEdit.Properties.AutoHeight = false;
            roomLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            roomLookUpEdit.Properties.NullText = "Select Room";
            roomLookUpEdit.Properties.PopupView = searchLookUpEdit3View;
            roomLookUpEdit.Size = new Size(237, 26);
            roomLookUpEdit.TabIndex = 2;
            roomLookUpEdit.EditValueChanged += RoomLookUpEdit_EditValueChanged;
            // 
            // searchLookUpEdit3View
            // 
            searchLookUpEdit3View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            searchLookUpEdit3View.Name = "searchLookUpEdit3View";
            searchLookUpEdit3View.OptionsSelection.EnableAppearanceFocusedCell = false;
            searchLookUpEdit3View.OptionsView.ShowGroupPanel = false;
            // 
            // guestName
            // 
            guestName.Location = new Point(91, 168);
            guestName.Name = "guestName";
            guestName.Properties.Appearance.Font = new Font("Tahoma", 12F);
            guestName.Properties.Appearance.Options.UseFont = true;
            guestName.Size = new Size(237, 26);
            guestName.TabIndex = 3;
            // 
            // totalPrice
            // 
            totalPrice.Location = new Point(91, 217);
            totalPrice.Name = "totalPrice";
            totalPrice.Properties.Appearance.Font = new Font("Tahoma", 12F);
            totalPrice.Properties.Appearance.Options.UseFont = true;
            totalPrice.Size = new Size(237, 26);
            totalPrice.TabIndex = 4;
            // 
            // statusCombo
            // 
            statusCombo.Location = new Point(91, 266);
            statusCombo.Name = "statusCombo";
            statusCombo.Properties.Appearance.Font = new Font("Tahoma", 12F);
            statusCombo.Properties.Appearance.Options.UseFont = true;
            statusCombo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            statusCombo.Size = new Size(237, 26);
            statusCombo.TabIndex = 5;
            // 
            // cancelBtn
            // 
            cancelBtn.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            cancelBtn.Appearance.Options.UseBackColor = true;
            cancelBtn.Location = new Point(91, 303);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(85, 35);
            cancelBtn.TabIndex = 6;
            cancelBtn.Text = "Clear";
            cancelBtn.Click += cancelBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.Appearance.BackColor = Color.MediumBlue;
            updateBtn.Appearance.Options.UseBackColor = true;
            updateBtn.Location = new Point(243, 303);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(85, 35);
            updateBtn.TabIndex = 7;
            updateBtn.Text = "Update";
            updateBtn.Click += UpdateBtn_Click;
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(label5);
            panelControl1.Controls.Add(cancelBtn);
            panelControl1.Controls.Add(updateBtn);
            panelControl1.Controls.Add(label3);
            panelControl1.Controls.Add(roomLookUpEdit);
            panelControl1.Controls.Add(label2);
            panelControl1.Controls.Add(bookingLookUpEdit);
            panelControl1.Controls.Add(statusCombo);
            panelControl1.Controls.Add(userLookUpEdit);
            panelControl1.Controls.Add(label1);
            panelControl1.Controls.Add(guestName);
            panelControl1.Controls.Add(totalPrice);
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
            label5.Size = new Size(84, 17);
            label5.TabIndex = 8;
            label5.Text = "Edit Booking";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10F);
            label3.Location = new Point(91, 246);
            label3.Name = "label3";
            label3.Size = new Size(47, 17);
            label3.TabIndex = 6;
            label3.Text = "Status";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10F);
            label2.Location = new Point(91, 197);
            label2.Name = "label2";
            label2.Size = new Size(71, 17);
            label2.TabIndex = 5;
            label2.Text = "Total Price";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10F);
            label1.Location = new Point(91, 148);
            label1.Name = "label1";
            label1.Size = new Size(82, 17);
            label1.TabIndex = 4;
            label1.Text = "Guest Name";
            // 
            // EditBookingForm
            // 
            Appearance.BackColor = Color.FromArgb(209, 248, 239);
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1118, 600);
            ControlBox = false;
            Controls.Add(panelControl1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditBookingForm";
            Text = "EditBookingForm";
            WindowState = FormWindowState.Maximized;
            Load += EditBookingForm_Load;
            ((System.ComponentModel.ISupportInitialize)bookingLookUpEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)searchLookUpEdit1View).EndInit();
            ((System.ComponentModel.ISupportInitialize)userLookUpEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)searchLookUpEdit2View).EndInit();
            ((System.ComponentModel.ISupportInitialize)roomLookUpEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)searchLookUpEdit3View).EndInit();
            ((System.ComponentModel.ISupportInitialize)guestName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)totalPrice.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)statusCombo.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            panelControl1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.SearchLookUpEdit bookingLookUpEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.SearchLookUpEdit userLookUpEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit2View;
        private DevExpress.XtraEditors.SearchLookUpEdit roomLookUpEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit3View;
        private DevExpress.XtraEditors.TextEdit guestName;
        private DevExpress.XtraEditors.TextEdit totalPrice;
        private DevExpress.XtraEditors.ComboBoxEdit statusCombo;
        private DevExpress.XtraEditors.SimpleButton cancelBtn;
        private DevExpress.XtraEditors.SimpleButton updateBtn;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}