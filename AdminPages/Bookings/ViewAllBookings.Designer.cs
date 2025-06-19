namespace HotelBooking.pages.Bookings
{
    partial class ViewAllBookings
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
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            bookingsGrid = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookingsGrid).BeginInit();
            SuspendLayout();
            // 
            // gridControl1
            // 
            gridControl1.Dock = DockStyle.Fill;
            gridControl1.Location = new Point(0, 0);
            gridControl1.MainView = bookingsGrid;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new Size(1005, 598);
            gridControl1.TabIndex = 0;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { bookingsGrid });
            // 
            // bookingsGrid
            // 
            bookingsGrid.Appearance.GroupPanel.Font = new Font("Tahoma", 12F);
            bookingsGrid.Appearance.GroupPanel.Options.UseFont = true;
            bookingsGrid.Appearance.Row.Font = new Font("Tahoma", 12F);
            bookingsGrid.Appearance.Row.Options.UseFont = true;
            bookingsGrid.Appearance.Row.Options.UseTextOptions = true;
            bookingsGrid.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            bookingsGrid.GridControl = gridControl1;
            bookingsGrid.GroupPanelText = "Bookings";
            bookingsGrid.Name = "bookingsGrid";
            bookingsGrid.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            bookingsGrid.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            bookingsGrid.OptionsBehavior.Editable = false;
            bookingsGrid.OptionsBehavior.ReadOnly = true;
            // 
            // ViewAllBookings
            // 
            Appearance.BackColor = Color.FromArgb(209, 248, 239);
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1005, 598);
            ControlBox = false;
            Controls.Add(gridControl1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ViewAllBookings";
            Text = "ViewAllBookings";
            WindowState = FormWindowState.Maximized;
            Load += ViewAllBookings_Load;
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookingsGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView bookingsGrid;
    }
}