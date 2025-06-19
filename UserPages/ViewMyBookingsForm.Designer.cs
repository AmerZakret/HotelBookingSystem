namespace HotelBooking.UserPages
{
    partial class ViewMyBookingsForm
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
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            lblTitle = new Label();
            btnArrow = new Button();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            SuspendLayout();
            // 
            // gridControl1
            // 
            gridControl1.Location = new Point(30, 70);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new Size(740, 350);
            gridControl1.TabIndex = 0;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.Appearance.Row.Options.UseTextOptions = true;
            gridView1.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            gridView1.OptionsBehavior.Editable = false;
            gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.FromArgb(209, 248, 239);
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(800, 60);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "My Bookings";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnArrow
            // 
            btnArrow.BackColor = Color.FromArgb(209, 248, 239);
            btnArrow.Cursor = Cursors.Hand;
            btnArrow.FlatAppearance.BorderSize = 0;
            btnArrow.FlatStyle = FlatStyle.Flat;
            btnArrow.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnArrow.Location = new Point(10, 10);
            btnArrow.Name = "btnArrow";
            btnArrow.Size = new Size(45, 40);
            btnArrow.TabIndex = 0;
            btnArrow.Text = "←";
            btnArrow.UseVisualStyleBackColor = false;
            btnArrow.Click += btnArrow_Click;
            // 
            // ViewMyBookingsForm
            // 
            Appearance.BackColor = Color.FromArgb(209, 248, 239);
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 500);
            Controls.Add(btnArrow);
            Controls.Add(lblTitle);
            Controls.Add(gridControl1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "ViewMyBookingsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "My Bookings";
            Load += ViewMyBookingsForm_Load;
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnArrow;
    }
} 