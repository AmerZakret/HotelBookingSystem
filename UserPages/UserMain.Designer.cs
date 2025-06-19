namespace HotelBooking.UserPages
{
    partial class UserMain
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
            components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.TileItemElement tileItemElement9 = new DevExpress.XtraEditors.TileItemElement();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserMain));
            DevExpress.XtraEditors.TileItemElement tileItemElement10 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement11 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement12 = new DevExpress.XtraEditors.TileItemElement();
            welcomeLabel = new DevExpress.XtraEditors.LabelControl();
            contentPanel = new DevExpress.XtraEditors.PanelControl();
            welcomeTxt = new DevExpress.XtraEditors.LabelControl();
            tileControl = new DevExpress.XtraEditors.TileControl();
            tileGroup = new DevExpress.XtraEditors.TileGroup();
            tileViewRooms = new DevExpress.XtraEditors.TileItem();
            tileMyBookings = new DevExpress.XtraEditors.TileItem();
            tileBookRoom = new DevExpress.XtraEditors.TileItem();
            tileFeedback = new DevExpress.XtraEditors.TileItem();
            btnLogout = new Button();
            defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(components);
            ((System.ComponentModel.ISupportInitialize)contentPanel).BeginInit();
            contentPanel.SuspendLayout();
            SuspendLayout();
            // 
            // welcomeLabel
            // 
            welcomeLabel.Appearance.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            welcomeLabel.Appearance.Options.UseFont = true;
            welcomeLabel.Location = new Point(30, 15);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(216, 30);
            welcomeLabel.TabIndex = 1;
            welcomeLabel.Text = "Welcome, [Username]";
            // 
            // contentPanel
            // 
            contentPanel.Appearance.BackColor = Color.WhiteSmoke;
            contentPanel.Appearance.Options.UseBackColor = true;
            contentPanel.Controls.Add(welcomeTxt);
            contentPanel.Controls.Add(tileControl);
            contentPanel.Controls.Add(btnLogout);
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(0, 0);
            contentPanel.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            contentPanel.LookAndFeel.UseDefaultLookAndFeel = false;
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(810, 711);
            contentPanel.TabIndex = 0;
            // 
            // welcomeTxt
            // 
            welcomeTxt.Appearance.BackColor = Color.FromArgb(209, 248, 239);
            welcomeTxt.Appearance.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            welcomeTxt.Appearance.Options.UseBackColor = true;
            welcomeTxt.Appearance.Options.UseFont = true;
            welcomeTxt.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            welcomeTxt.Location = new Point(241, 15);
            welcomeTxt.Name = "welcomeTxt";
            welcomeTxt.Size = new Size(331, 51);
            welcomeTxt.TabIndex = 1;
            welcomeTxt.Text = "Welcome (Username)";
            // 
            // tileControl
            // 
            tileControl.AppearanceItem.Normal.BackColor = Color.FromArgb(54, 116, 181);
            tileControl.AppearanceItem.Normal.Options.UseBackColor = true;
            tileControl.BackColor = Color.FromArgb(209, 248, 239);
            tileControl.BackgroundImageLayout = ImageLayout.None;
            tileControl.Dock = DockStyle.Fill;
            tileControl.Groups.Add(tileGroup);
            tileControl.Location = new Point(3, 3);
            tileControl.MaxId = 2;
            tileControl.Name = "tileControl";
            tileControl.Padding = new Padding(100);
            tileControl.Size = new Size(804, 705);
            tileControl.TabIndex = 0;
            // 
            // tileGroup
            // 
            tileGroup.Items.Add(tileViewRooms);
            tileGroup.Items.Add(tileMyBookings);
            tileGroup.Items.Add(tileBookRoom);
            tileGroup.Items.Add(tileFeedback);
            tileGroup.Name = "tileGroup";
            // 
            // tileViewRooms
            // 
            tileViewRooms.AppearanceItem.Normal.Font = new Font("Segoe UI", 12F);
            tileViewRooms.AppearanceItem.Normal.Options.UseFont = true;
            tileItemElement9.Appearance.Normal.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tileItemElement9.Appearance.Normal.Options.UseFont = true;
            tileItemElement9.ImageOptions.Image = (Image)resources.GetObject("resource.Image");
            tileItemElement9.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileItemElement9.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left;
            tileItemElement9.ImageOptions.ImageToTextIndent = 32;
            tileItemElement9.Text = "View Rooms";
            tileViewRooms.Elements.Add(tileItemElement9);
            tileViewRooms.Id = 0;
            tileViewRooms.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            tileViewRooms.Name = "tileViewRooms";
            tileViewRooms.ItemClick += tileViewRooms_ItemClick;
            // 
            // tileMyBookings
            // 
            tileItemElement10.Appearance.Normal.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tileItemElement10.Appearance.Normal.Options.UseFont = true;
            tileItemElement10.ImageOptions.Image = (Image)resources.GetObject("resource.Image1");
            tileItemElement10.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileItemElement10.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left;
            tileItemElement10.ImageOptions.ImageToTextIndent = 27;
            tileItemElement10.Text = "My Bookings";
            tileMyBookings.Elements.Add(tileItemElement10);
            tileMyBookings.Id = 2;
            tileMyBookings.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            tileMyBookings.Name = "tileMyBookings";
            tileMyBookings.ItemClick += tileMyBookings_ItemClick;
            // 
            // tileBookRoom
            // 
            tileItemElement11.Appearance.Normal.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tileItemElement11.Appearance.Normal.Options.UseFont = true;
            tileItemElement11.ImageOptions.Image = (Image)resources.GetObject("resource.Image2");
            tileItemElement11.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left;
            tileItemElement11.ImageOptions.ImageToTextIndent = 5;
            tileItemElement11.Text = "My Account";
            tileBookRoom.Elements.Add(tileItemElement11);
            tileBookRoom.Id = 1;
            tileBookRoom.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            tileBookRoom.Name = "tileBookRoom";
            tileBookRoom.ItemClick += tileBookRoom_ItemClick;
            // 
            // tileFeedback
            // 
            tileItemElement12.Appearance.Normal.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tileItemElement12.Appearance.Normal.Options.UseFont = true;
            tileItemElement12.ImageOptions.Image = (Image)resources.GetObject("resource.Image3");
            tileItemElement12.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left;
            tileItemElement12.ImageOptions.ImageToTextIndent = 17;
            tileItemElement12.Text = "Feedback";
            tileFeedback.Elements.Add(tileItemElement12);
            tileFeedback.Id = 3;
            tileFeedback.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            tileFeedback.Name = "tileFeedback";
            tileFeedback.ItemClick += tileFeedback_ItemClick;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnLogout.BackColor = Color.FromArgb(220, 53, 69);
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(670, 660);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(120, 40);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // UserMain
            // 
            Appearance.BackColor = Color.FromArgb(209, 248, 239);
            Appearance.BorderColor = Color.FromArgb(54, 116, 181);
            Appearance.Options.UseBackColor = true;
            Appearance.Options.UseBorderColor = true;
            ClientSize = new Size(810, 711);
            Controls.Add(contentPanel);
            Controls.Add(welcomeLabel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "UserMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User Dashboard";
            ((System.ComponentModel.ISupportInitialize)contentPanel).EndInit();
            contentPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion
        private DevExpress.XtraEditors.LabelControl welcomeLabel;
        private DevExpress.XtraEditors.PanelControl contentPanel;
        private DevExpress.XtraEditors.TileControl tileControl;
        private DevExpress.XtraEditors.TileGroup tileGroup;
        private DevExpress.XtraEditors.TileItem tileViewRooms;
        private DevExpress.XtraEditors.TileItem tileBookRoom;
        private DevExpress.XtraEditors.TileItem tileMyBookings;
        private DevExpress.XtraEditors.TileItem tileFeedback;
        private DevExpress.XtraEditors.LabelControl welcomeTxt;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private System.Windows.Forms.Button btnLogout;
    }
}