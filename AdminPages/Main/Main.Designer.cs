namespace HotelBooking
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            addUserBtn = new DevExpress.XtraBars.BarButtonItem();
            logoutBtn = new DevExpress.XtraBars.BarButtonItem();
            resetPasswordBtn = new DevExpress.XtraBars.BarButtonItem();
            deleteUserBtn = new DevExpress.XtraBars.BarButtonItem();
            viewAllUsersBtn = new DevExpress.XtraBars.BarButtonItem();
            editUserBtn = new DevExpress.XtraBars.BarButtonItem();
            addRoomBtn = new DevExpress.XtraBars.BarButtonItem();
            editRoomBtn = new DevExpress.XtraBars.BarButtonItem();
            deleteRoomBtn = new DevExpress.XtraBars.BarButtonItem();
            viewRoomsBtn = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            addBookingBtn = new DevExpress.XtraBars.BarButtonItem();
            viewBookingsBtn = new DevExpress.XtraBars.BarButtonItem();
            deleteBookingBtn = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            name = new DevExpress.XtraBars.BarStaticItem();
            viewFeedbackBtn = new DevExpress.XtraBars.BarButtonItem();
            barButtonGroup1 = new DevExpress.XtraBars.BarButtonGroup();
            homePage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup18 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup19 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup20 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup21 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup22 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            accountsPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            roomsPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup9 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup10 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup11 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup12 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            bookingsPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup13 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup14 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup16 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup15 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            feedbackPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup17 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(components);
            ribbonPageGroup23 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)ribbon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemDateEdit1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemDateEdit1.CalendarTimeProperties).BeginInit();
            SuspendLayout();
            // 
            // ribbon
            // 
            ribbon.ExpandCollapseItem.Id = 0;
            ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbon.ExpandCollapseItem, addUserBtn, logoutBtn, resetPasswordBtn, deleteUserBtn, viewAllUsersBtn, editUserBtn, addRoomBtn, editRoomBtn, deleteRoomBtn, viewRoomsBtn, barButtonItem1, addBookingBtn, viewBookingsBtn, deleteBookingBtn, barButtonItem2, barButtonItem3, barEditItem1, name, viewFeedbackBtn, barButtonGroup1 });
            ribbon.Location = new Point(0, 0);
            ribbon.MaxItemId = 30;
            ribbon.Name = "ribbon";
            ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { homePage, accountsPage, roomsPage, bookingsPage, feedbackPage });
            ribbon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repositoryItemDateEdit1 });
            ribbon.ShowPageKeyTipsMode = DevExpress.XtraBars.Ribbon.ShowPageKeyTipsMode.Hide;
            ribbon.Size = new Size(1116, 158);
            ribbon.StatusBar = ribbonStatusBar;
            ribbon.Click += ribbon_Click;
            // 
            // addUserBtn
            // 
            addUserBtn.Caption = "Add User";
            addUserBtn.Id = 3;
            addUserBtn.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("addUserBtn.ImageOptions.SvgImage");
            addUserBtn.LargeWidth = 100;
            addUserBtn.Name = "addUserBtn";
            addUserBtn.ItemClick += addUserBtn_ItemClick;
            // 
            // logoutBtn
            // 
            logoutBtn.Caption = "Log out";
            logoutBtn.Id = 5;
            logoutBtn.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("logoutBtn.ImageOptions.SvgImage");
            logoutBtn.LargeWidth = 100;
            logoutBtn.Name = "logoutBtn";
            logoutBtn.ItemClick += logoutBtn_ItemClick;
            // 
            // resetPasswordBtn
            // 
            resetPasswordBtn.Caption = "Reset Password";
            resetPasswordBtn.Id = 6;
            resetPasswordBtn.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("resetPasswordBtn.ImageOptions.SvgImage");
            resetPasswordBtn.LargeWidth = 100;
            resetPasswordBtn.Name = "resetPasswordBtn";
            resetPasswordBtn.ItemClick += resetPasswordBtn_ItemClick;
            // 
            // deleteUserBtn
            // 
            deleteUserBtn.Caption = "Delete User";
            deleteUserBtn.Id = 7;
            deleteUserBtn.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("deleteUserBtn.ImageOptions.SvgImage");
            deleteUserBtn.LargeWidth = 100;
            deleteUserBtn.Name = "deleteUserBtn";
            deleteUserBtn.ItemClick += deleteUserBtn_ItemClick;
            // 
            // viewAllUsersBtn
            // 
            viewAllUsersBtn.Caption = "View All Users";
            viewAllUsersBtn.Id = 12;
            viewAllUsersBtn.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("viewAllUsersBtn.ImageOptions.SvgImage");
            viewAllUsersBtn.LargeWidth = 100;
            viewAllUsersBtn.Name = "viewAllUsersBtn";
            viewAllUsersBtn.ItemClick += viewAllUsersBtn_ItemClick;
            // 
            // editUserBtn
            // 
            editUserBtn.Caption = "Edit User";
            editUserBtn.Id = 13;
            editUserBtn.ImageOptions.LargeImage = (Image)resources.GetObject("editUserBtn.ImageOptions.LargeImage");
            editUserBtn.LargeWidth = 100;
            editUserBtn.Name = "editUserBtn";
            editUserBtn.ItemClick += editUserBtn_ItemClick;
            // 
            // addRoomBtn
            // 
            addRoomBtn.Caption = "Add Room";
            addRoomBtn.Id = 14;
            addRoomBtn.ImageOptions.Image = (Image)resources.GetObject("addRoomBtn.ImageOptions.Image");
            addRoomBtn.ImageOptions.LargeImage = (Image)resources.GetObject("addRoomBtn.ImageOptions.LargeImage");
            addRoomBtn.LargeWidth = 100;
            addRoomBtn.Name = "addRoomBtn";
            addRoomBtn.ItemClick += addRoomBtn_ItemClick;
            // 
            // editRoomBtn
            // 
            editRoomBtn.Caption = "Edit Room";
            editRoomBtn.Id = 15;
            editRoomBtn.ImageOptions.LargeImage = (Image)resources.GetObject("editRoomBtn.ImageOptions.LargeImage");
            editRoomBtn.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("editRoomBtn.ImageOptions.SvgImage");
            editRoomBtn.LargeWidth = 100;
            editRoomBtn.Name = "editRoomBtn";
            editRoomBtn.ItemClick += editRoomBtn_ItemClick;
            // 
            // deleteRoomBtn
            // 
            deleteRoomBtn.Caption = "Delete Room";
            deleteRoomBtn.Id = 16;
            deleteRoomBtn.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("deleteRoomBtn.ImageOptions.SvgImage");
            deleteRoomBtn.LargeWidth = 100;
            deleteRoomBtn.Name = "deleteRoomBtn";
            deleteRoomBtn.ItemClick += deleteRoomBtn_ItemClick;
            // 
            // viewRoomsBtn
            // 
            viewRoomsBtn.Caption = "View Rooms";
            viewRoomsBtn.Id = 17;
            viewRoomsBtn.ImageOptions.LargeImage = (Image)resources.GetObject("viewRoomsBtn.ImageOptions.LargeImage");
            viewRoomsBtn.LargeWidth = 100;
            viewRoomsBtn.Name = "viewRoomsBtn";
            viewRoomsBtn.ItemClick += viewRoomsBtn_ItemClick;
            // 
            // barButtonItem1
            // 
            barButtonItem1.Caption = "barButtonItem1";
            barButtonItem1.Id = 18;
            barButtonItem1.Name = "barButtonItem1";
            // 
            // addBookingBtn
            // 
            addBookingBtn.Caption = "Add Booking";
            addBookingBtn.Id = 19;
            addBookingBtn.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("addBookingBtn.ImageOptions.SvgImage");
            addBookingBtn.LargeWidth = 100;
            addBookingBtn.Name = "addBookingBtn";
            addBookingBtn.ItemClick += addBookingBtn_ItemClick;
            // 
            // viewBookingsBtn
            // 
            viewBookingsBtn.Caption = "View Bookings";
            viewBookingsBtn.Id = 20;
            viewBookingsBtn.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("viewBookingsBtn.ImageOptions.SvgImage");
            viewBookingsBtn.LargeWidth = 100;
            viewBookingsBtn.Name = "viewBookingsBtn";
            viewBookingsBtn.ItemClick += viewBookingsBtn_ItemClick;
            // 
            // deleteBookingBtn
            // 
            deleteBookingBtn.Caption = "Delete Booking";
            deleteBookingBtn.Id = 21;
            deleteBookingBtn.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("deleteBookingBtn.ImageOptions.SvgImage");
            deleteBookingBtn.LargeWidth = 100;
            deleteBookingBtn.Name = "deleteBookingBtn";
            deleteBookingBtn.ItemClick += deleteBookingBtn_ItemClick;
            // 
            // barButtonItem2
            // 
            barButtonItem2.Caption = "Edit Booking";
            barButtonItem2.Id = 22;
            barButtonItem2.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItem2.ImageOptions.SvgImage");
            barButtonItem2.LargeWidth = 100;
            barButtonItem2.Name = "barButtonItem2";
            barButtonItem2.ItemClick += barButtonItem2_ItemClick;
            // 
            // barButtonItem3
            // 
            barButtonItem3.Caption = "barButtonItem3";
            barButtonItem3.Id = 24;
            barButtonItem3.Name = "barButtonItem3";
            // 
            // barEditItem1
            // 
            barEditItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            barEditItem1.Caption = "barEditItem1";
            barEditItem1.Edit = repositoryItemDateEdit1;
            barEditItem1.Id = 25;
            barEditItem1.Name = "barEditItem1";
            // 
            // repositoryItemDateEdit1
            // 
            repositoryItemDateEdit1.AutoHeight = false;
            repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // name
            // 
            name.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            name.Caption = "Amer Zakret     230543602";
            name.Id = 26;
            name.Name = "name";
            // 
            // viewFeedbackBtn
            // 
            viewFeedbackBtn.Caption = "View Feedback";
            viewFeedbackBtn.Id = 27;
            viewFeedbackBtn.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("viewFeedbackBtn.ImageOptions.SvgImage");
            viewFeedbackBtn.LargeWidth = 150;
            viewFeedbackBtn.Name = "viewFeedbackBtn";
            viewFeedbackBtn.ItemClick += viewFeedbackBtn_ItemClick;
            // 
            // barButtonGroup1
            // 
            barButtonGroup1.Caption = "barButtonGroup1";
            barButtonGroup1.CategoryGuid = new Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            barButtonGroup1.Id = 28;
            barButtonGroup1.Name = "barButtonGroup1";
            // 
            // homePage
            // 
            homePage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup18, ribbonPageGroup19, ribbonPageGroup20, ribbonPageGroup21, ribbonPageGroup22 });
            homePage.Name = "homePage";
            homePage.Text = "Home";
            // 
            // ribbonPageGroup18
            // 
            ribbonPageGroup18.ItemLinks.Add(viewAllUsersBtn);
            ribbonPageGroup18.ItemLinks.Add(editUserBtn);
            ribbonPageGroup18.ItemLinks.Add(addUserBtn);
            ribbonPageGroup18.ItemLinks.Add(deleteUserBtn);
            ribbonPageGroup18.ItemLinks.Add(resetPasswordBtn);
            ribbonPageGroup18.ItemsLayout = DevExpress.XtraBars.Ribbon.RibbonPageGroupItemsLayout.ThreeRows;
            ribbonPageGroup18.Name = "ribbonPageGroup18";
            ribbonPageGroup18.Text = "User";
            // 
            // ribbonPageGroup19
            // 
            ribbonPageGroup19.ItemLinks.Add(viewRoomsBtn);
            ribbonPageGroup19.ItemLinks.Add(deleteRoomBtn);
            ribbonPageGroup19.ItemLinks.Add(editRoomBtn);
            ribbonPageGroup19.ItemLinks.Add(addRoomBtn);
            ribbonPageGroup19.Name = "ribbonPageGroup19";
            ribbonPageGroup19.Text = "Room";
            // 
            // ribbonPageGroup20
            // 
            ribbonPageGroup20.ItemLinks.Add(viewFeedbackBtn);
            ribbonPageGroup20.Name = "ribbonPageGroup20";
            ribbonPageGroup20.State = DevExpress.XtraBars.Ribbon.RibbonPageGroupState.Expanded;
            ribbonPageGroup20.Text = "Feedback";
            // 
            // ribbonPageGroup21
            // 
            ribbonPageGroup21.ItemLinks.Add(addBookingBtn);
            ribbonPageGroup21.ItemLinks.Add(viewBookingsBtn);
            ribbonPageGroup21.ItemLinks.Add(barButtonItem2);
            ribbonPageGroup21.ItemLinks.Add(deleteBookingBtn);
            ribbonPageGroup21.Name = "ribbonPageGroup21";
            ribbonPageGroup21.Text = "Booking";
            // 
            // ribbonPageGroup22
            // 
            ribbonPageGroup22.Alignment = DevExpress.XtraBars.Ribbon.RibbonPageGroupAlignment.Far;
            ribbonPageGroup22.ItemLinks.Add(logoutBtn);
            ribbonPageGroup22.ItemsLayout = DevExpress.XtraBars.Ribbon.RibbonPageGroupItemsLayout.OneRow;
            ribbonPageGroup22.Name = "ribbonPageGroup22";
            ribbonPageGroup22.State = DevExpress.XtraBars.Ribbon.RibbonPageGroupState.Expanded;
            // 
            // accountsPage
            // 
            accountsPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup2, ribbonPageGroup4, ribbonPageGroup5, ribbonPageGroup7, ribbonPageGroup6, ribbonPageGroup8 });
            accountsPage.Name = "accountsPage";
            accountsPage.Text = "Accounts";
            // 
            // ribbonPageGroup2
            // 
            ribbonPageGroup2.ItemLinks.Add(viewAllUsersBtn);
            ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageGroup4
            // 
            ribbonPageGroup4.ItemLinks.Add(editUserBtn);
            ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // ribbonPageGroup5
            // 
            ribbonPageGroup5.ItemLinks.Add(addUserBtn);
            ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // ribbonPageGroup7
            // 
            ribbonPageGroup7.ItemLinks.Add(resetPasswordBtn);
            ribbonPageGroup7.Name = "ribbonPageGroup7";
            // 
            // ribbonPageGroup6
            // 
            ribbonPageGroup6.Alignment = DevExpress.XtraBars.Ribbon.RibbonPageGroupAlignment.Far;
            ribbonPageGroup6.ItemLinks.Add(logoutBtn, true);
            ribbonPageGroup6.Name = "ribbonPageGroup6";
            // 
            // ribbonPageGroup8
            // 
            ribbonPageGroup8.ItemLinks.Add(deleteUserBtn);
            ribbonPageGroup8.Name = "ribbonPageGroup8";
            // 
            // roomsPage
            // 
            roomsPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup3, ribbonPageGroup9, ribbonPageGroup10, ribbonPageGroup11, ribbonPageGroup12 });
            roomsPage.Name = "roomsPage";
            roomsPage.Text = "Rooms";
            // 
            // ribbonPageGroup3
            // 
            ribbonPageGroup3.ItemLinks.Add(viewRoomsBtn);
            ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPageGroup9
            // 
            ribbonPageGroup9.ItemLinks.Add(editRoomBtn);
            ribbonPageGroup9.Name = "ribbonPageGroup9";
            // 
            // ribbonPageGroup10
            // 
            ribbonPageGroup10.ItemLinks.Add(addRoomBtn);
            ribbonPageGroup10.Name = "ribbonPageGroup10";
            // 
            // ribbonPageGroup11
            // 
            ribbonPageGroup11.ItemLinks.Add(deleteRoomBtn);
            ribbonPageGroup11.Name = "ribbonPageGroup11";
            // 
            // ribbonPageGroup12
            // 
            ribbonPageGroup12.Alignment = DevExpress.XtraBars.Ribbon.RibbonPageGroupAlignment.Far;
            ribbonPageGroup12.ItemLinks.Add(logoutBtn);
            ribbonPageGroup12.Name = "ribbonPageGroup12";
            // 
            // bookingsPage
            // 
            bookingsPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup13, ribbonPageGroup14, ribbonPageGroup16, ribbonPageGroup15, ribbonPageGroup1 });
            bookingsPage.Name = "bookingsPage";
            bookingsPage.Text = "Bookings";
            // 
            // ribbonPageGroup13
            // 
            ribbonPageGroup13.ItemLinks.Add(viewBookingsBtn);
            ribbonPageGroup13.Name = "ribbonPageGroup13";
            // 
            // ribbonPageGroup14
            // 
            ribbonPageGroup14.Alignment = DevExpress.XtraBars.Ribbon.RibbonPageGroupAlignment.Far;
            ribbonPageGroup14.ItemLinks.Add(logoutBtn);
            ribbonPageGroup14.Name = "ribbonPageGroup14";
            // 
            // ribbonPageGroup16
            // 
            ribbonPageGroup16.ItemLinks.Add(barButtonItem2);
            ribbonPageGroup16.Name = "ribbonPageGroup16";
            // 
            // ribbonPageGroup15
            // 
            ribbonPageGroup15.ItemLinks.Add(addBookingBtn);
            ribbonPageGroup15.Name = "ribbonPageGroup15";
            // 
            // ribbonPageGroup1
            // 
            ribbonPageGroup1.ItemLinks.Add(deleteBookingBtn);
            ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // feedbackPage
            // 
            feedbackPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup17, ribbonPageGroup23 });
            feedbackPage.Name = "feedbackPage";
            feedbackPage.Text = "Feedback";
            // 
            // ribbonPageGroup17
            // 
            ribbonPageGroup17.ItemLinks.Add(viewFeedbackBtn);
            ribbonPageGroup17.Name = "ribbonPageGroup17";
            // 
            // ribbonStatusBar
            // 
            ribbonStatusBar.ItemLinks.Add(name);
            ribbonStatusBar.Location = new Point(0, 735);
            ribbonStatusBar.Name = "ribbonStatusBar";
            ribbonStatusBar.Ribbon = ribbon;
            ribbonStatusBar.Size = new Size(1116, 22);
            // 
            // defaultLookAndFeel1
            // 
            defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2019 Colorful";
            // 
            // ribbonPageGroup23
            // 
            ribbonPageGroup23.Alignment = DevExpress.XtraBars.Ribbon.RibbonPageGroupAlignment.Far;
            ribbonPageGroup23.ItemLinks.Add(logoutBtn);
            ribbonPageGroup23.Name = "ribbonPageGroup23";
            ribbonPageGroup23.Text = "ribbonPageGroup23";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1116, 757);
            Controls.Add(ribbonStatusBar);
            Controls.Add(ribbon);
            IsMdiContainer = true;
            MaximumSize = new Size(1118, 758);
            MinimumSize = new Size(1118, 758);
            Name = "Main";
            Ribbon = ribbon;
            StatusBar = ribbonStatusBar;
            Text = "Main";
            Load += Main_Load;
            ((System.ComponentModel.ISupportInitialize)ribbon).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemDateEdit1.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemDateEdit1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage homePage;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.Ribbon.RibbonPage accountsPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage roomsPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem addUserBtn;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.BarButtonItem logoutBtn;
        private DevExpress.XtraBars.BarButtonItem resetPasswordBtn;
        private DevExpress.XtraBars.BarButtonItem deleteUserBtn;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraBars.BarButtonItem viewAllUsersBtn;
        private DevExpress.XtraBars.BarButtonItem editUserBtn;
        private DevExpress.XtraBars.BarButtonItem addRoomBtn;
        private DevExpress.XtraBars.BarButtonItem editRoomBtn;
        private DevExpress.XtraBars.BarButtonItem deleteRoomBtn;
        private DevExpress.XtraBars.BarButtonItem viewRoomsBtn;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup9;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup10;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup11;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup12;
        private DevExpress.XtraBars.BarButtonItem addBookingBtn;
        private DevExpress.XtraBars.Ribbon.RibbonPage bookingsPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup13;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup14;
        private DevExpress.XtraBars.BarButtonItem viewBookingsBtn;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup15;
        private DevExpress.XtraBars.BarButtonItem deleteBookingBtn;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup16;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPage feedbackPage;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraBars.BarStaticItem name;
        private DevExpress.XtraBars.BarButtonItem viewFeedbackBtn;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup17;
        private DevExpress.XtraBars.BarButtonGroup barButtonGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup18;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup19;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup20;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup21;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup22;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup23;
    }
}