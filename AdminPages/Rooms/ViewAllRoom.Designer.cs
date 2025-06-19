namespace HotelBooking.pages.Rooms
{
    partial class ViewAllRoom
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
            gridRooms = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)gridRooms).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            SuspendLayout();
            // 
            // gridRooms
            // 
            gridRooms.Dock = DockStyle.Fill;
            gridRooms.EmbeddedNavigator.Text = "All Rooms";
            gridRooms.Location = new Point(0, 0);
            gridRooms.MainView = gridView1;
            gridRooms.Name = "gridRooms";
            gridRooms.Size = new Size(931, 639);
            gridRooms.TabIndex = 0;
            gridRooms.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.Appearance.Empty.Options.UseTextOptions = true;
            gridView1.Appearance.Empty.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            gridView1.Appearance.EvenRow.Options.UseTextOptions = true;
            gridView1.Appearance.EvenRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            gridView1.Appearance.FilterPanel.Options.UseTextOptions = true;
            gridView1.Appearance.FilterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            gridView1.Appearance.FixedLine.Options.UseTextOptions = true;
            gridView1.Appearance.FixedLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            gridView1.Appearance.GroupPanel.Font = new Font("Tahoma", 13F);
            gridView1.Appearance.GroupPanel.Options.UseFont = true;
            gridView1.Appearance.HorzLine.Options.UseTextOptions = true;
            gridView1.Appearance.HorzLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            gridView1.Appearance.OddRow.Options.UseTextOptions = true;
            gridView1.Appearance.OddRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            gridView1.Appearance.Row.Font = new Font("Tahoma", 13F);
            gridView1.Appearance.Row.Options.UseFont = true;
            gridView1.Appearance.Row.Options.UseTextOptions = true;
            gridView1.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            gridView1.Appearance.RowSeparator.Options.UseTextOptions = true;
            gridView1.Appearance.RowSeparator.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            gridView1.Appearance.VertLine.Options.UseTextOptions = true;
            gridView1.Appearance.VertLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            gridView1.AppearancePrint.Lines.Font = new Font("Tahoma", 13F);
            gridView1.AppearancePrint.Lines.Options.UseFont = true;
            gridView1.GridControl = gridRooms;
            gridView1.GroupPanelText = "Rooms";
            gridView1.Name = "gridView1";
            gridView1.OptionsBehavior.ReadOnly = true;
            // 
            // ViewAllRoom
            // 
            Appearance.BackColor = Color.FromArgb(209, 248, 239);
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 639);
            ControlBox = false;
            Controls.Add(gridRooms);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ViewAllRoom";
            Text = "ViewAllRoom";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)gridRooms).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridRooms;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}