namespace HotelBooking.pages.Bookings
{
    partial class AddBookingForm
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
            totalPrice = new DevExpress.XtraEditors.TextEdit();
            statusCombo = new DevExpress.XtraEditors.ComboBoxEdit();
            addBtn = new DevExpress.XtraEditors.SimpleButton();
            guestName = new DevExpress.XtraEditors.TextEdit();
            userLookUpEdit = new DevExpress.XtraEditors.SearchLookUpEdit();
            searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            roomLookUpEdit = new DevExpress.XtraEditors.SearchLookUpEdit();
            searchLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)totalPrice.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)statusCombo.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)guestName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userLookUpEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)searchLookUpEdit1View).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roomLookUpEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)searchLookUpEdit2View).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            SuspendLayout();
            // 
            // totalPrice
            // 
            totalPrice.Location = new Point(89, 203);
            totalPrice.Name = "totalPrice";
            totalPrice.Properties.Appearance.Font = new Font("Tahoma", 12F);
            totalPrice.Properties.Appearance.Options.UseFont = true;
            totalPrice.Size = new Size(239, 26);
            totalPrice.TabIndex = 3;
            // 
            // statusCombo
            // 
            statusCombo.Location = new Point(89, 258);
            statusCombo.Name = "statusCombo";
            statusCombo.Properties.Appearance.Font = new Font("Tahoma", 12F);
            statusCombo.Properties.Appearance.Options.UseFont = true;
            statusCombo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            statusCombo.Size = new Size(237, 26);
            statusCombo.TabIndex = 4;
            // 
            // addBtn
            // 
            addBtn.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            addBtn.Appearance.Options.UseBackColor = true;
            addBtn.Location = new Point(169, 303);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(85, 35);
            addBtn.TabIndex = 5;
            addBtn.Text = "Add";
            addBtn.Click += addBtn_Click;
            // 
            // guestName
            // 
            guestName.Location = new Point(91, 147);
            guestName.Name = "guestName";
            guestName.Properties.Appearance.Font = new Font("Tahoma", 12F);
            guestName.Properties.Appearance.Options.UseFont = true;
            guestName.Size = new Size(237, 26);
            guestName.TabIndex = 0;
            // 
            // userLookUpEdit
            // 
            userLookUpEdit.Location = new Point(91, 44);
            userLookUpEdit.Name = "userLookUpEdit";
            userLookUpEdit.Properties.Appearance.Font = new Font("Tahoma", 11F);
            userLookUpEdit.Properties.Appearance.Options.UseFont = true;
            userLookUpEdit.Properties.AutoHeight = false;
            userLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            userLookUpEdit.Properties.NullText = "Select User";
            userLookUpEdit.Properties.PopupView = searchLookUpEdit1View;
            userLookUpEdit.Size = new Size(237, 26);
            userLookUpEdit.TabIndex = 6;
            // 
            // searchLookUpEdit1View
            // 
            searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // roomLookUpEdit
            // 
            roomLookUpEdit.Location = new Point(91, 89);
            roomLookUpEdit.Name = "roomLookUpEdit";
            roomLookUpEdit.Properties.Appearance.Font = new Font("Tahoma", 11F);
            roomLookUpEdit.Properties.Appearance.Options.UseFont = true;
            roomLookUpEdit.Properties.AutoHeight = false;
            roomLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            roomLookUpEdit.Properties.NullText = "Select Room";
            roomLookUpEdit.Properties.PopupView = searchLookUpEdit2View;
            roomLookUpEdit.Size = new Size(237, 26);
            roomLookUpEdit.TabIndex = 7;
            roomLookUpEdit.EditValueChanged += roomLookUpEdit_EditValueChanged;
            // 
            // searchLookUpEdit2View
            // 
            searchLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            searchLookUpEdit2View.Name = "searchLookUpEdit2View";
            searchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            searchLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(label5);
            panelControl1.Controls.Add(addBtn);
            panelControl1.Controls.Add(roomLookUpEdit);
            panelControl1.Controls.Add(userLookUpEdit);
            panelControl1.Controls.Add(guestName);
            panelControl1.Controls.Add(statusCombo);
            panelControl1.Controls.Add(totalPrice);
            panelControl1.Controls.Add(label3);
            panelControl1.Controls.Add(label2);
            panelControl1.Controls.Add(label1);
            panelControl1.Location = new Point(349, 100);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new Size(420, 370);
            panelControl1.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 10F);
            label5.ForeColor = Color.CadetBlue;
            label5.Location = new Point(169, 2);
            label5.Name = "label5";
            label5.Size = new Size(85, 17);
            label5.TabIndex = 8;
            label5.Text = "Add Booking";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10F);
            label3.Location = new Point(89, 238);
            label3.Name = "label3";
            label3.Size = new Size(47, 17);
            label3.TabIndex = 6;
            label3.Text = "Status";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10F);
            label2.Location = new Point(89, 183);
            label2.Name = "label2";
            label2.Size = new Size(71, 17);
            label2.TabIndex = 5;
            label2.Text = "Total Price";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10F);
            label1.Location = new Point(91, 127);
            label1.Name = "label1";
            label1.Size = new Size(82, 17);
            label1.TabIndex = 4;
            label1.Text = "Guest Name";
            // 
            // AddBookingForm
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
            Name = "AddBookingForm";
            Text = "AddBookingForm";
            WindowState = FormWindowState.Maximized;
            Load += AddBookingForm_Load;
            ((System.ComponentModel.ISupportInitialize)totalPrice.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)statusCombo.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)guestName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)userLookUpEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)searchLookUpEdit1View).EndInit();
            ((System.ComponentModel.ISupportInitialize)roomLookUpEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)searchLookUpEdit2View).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            panelControl1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DevExpress.XtraEditors.TextEdit totalPrice;
        private DevExpress.XtraEditors.ComboBoxEdit statusCombo;
        private DevExpress.XtraEditors.SimpleButton addBtn;
        private DevExpress.XtraEditors.TextEdit guestName;
        private DevExpress.XtraEditors.SearchLookUpEdit userLookUpEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.SearchLookUpEdit roomLookUpEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit2View;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}