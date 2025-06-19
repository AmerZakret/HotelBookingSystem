namespace HotelBooking.pages.Bookings
{
    partial class DeleteBookingForm
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
            lookupBookings = new DevExpress.XtraEditors.SearchLookUpEdit();
            searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            panelControl2 = new DevExpress.XtraEditors.PanelControl();
            label1 = new Label();
            deleteBtn = new DevExpress.XtraEditors.SimpleButton();
            clearBtn = new DevExpress.XtraEditors.SimpleButton();
            lblInfo = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)lookupBookings.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)searchLookUpEdit1View).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl2).BeginInit();
            panelControl2.SuspendLayout();
            SuspendLayout();
            // 
            // lookupBookings
            // 
            lookupBookings.Location = new Point(92, 126);
            lookupBookings.Name = "lookupBookings";
            lookupBookings.Properties.Appearance.Font = new Font("Tahoma", 11F);
            lookupBookings.Properties.Appearance.Options.UseFont = true;
            lookupBookings.Properties.AutoHeight = false;
            lookupBookings.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            lookupBookings.Properties.NullText = "Select Booking";
            lookupBookings.Properties.PopupView = searchLookUpEdit1View;
            lookupBookings.Size = new Size(236, 35);
            lookupBookings.TabIndex = 0;
            // 
            // searchLookUpEdit1View
            // 
            searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // panelControl2
            // 
            panelControl2.Controls.Add(label1);
            panelControl2.Controls.Add(deleteBtn);
            panelControl2.Controls.Add(clearBtn);
            panelControl2.Controls.Add(lblInfo);
            panelControl2.Controls.Add(lookupBookings);
            panelControl2.Location = new Point(349, 100);
            panelControl2.Name = "panelControl2";
            panelControl2.Size = new Size(420, 370);
            panelControl2.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F);
            label1.ForeColor = Color.CadetBlue;
            label1.Location = new Point(146, 16);
            label1.Name = "label1";
            label1.Size = new Size(115, 19);
            label1.TabIndex = 4;
            label1.Text = "Delete Booking";
            // 
            // deleteBtn
            // 
            deleteBtn.Appearance.BackColor = Color.FromArgb(220, 53, 69);
            deleteBtn.Appearance.Options.UseBackColor = true;
            deleteBtn.Location = new Point(243, 199);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(85, 35);
            deleteBtn.TabIndex = 2;
            deleteBtn.Text = "Delete";
            deleteBtn.Click += deleteBtn_Click;
            // 
            // clearBtn
            // 
            clearBtn.Appearance.BackColor = Color.DarkBlue;
            clearBtn.Appearance.Options.UseBackColor = true;
            clearBtn.Location = new Point(92, 199);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(85, 35);
            clearBtn.TabIndex = 3;
            clearBtn.Text = "Clear";
            clearBtn.Click += clearBtn_Click;
            // 
            // lblInfo
            // 
            lblInfo.Location = new Point(34, 69);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(0, 13);
            lblInfo.TabIndex = 1;
            // 
            // DeleteBookingForm
            // 
            Appearance.BackColor = Color.FromArgb(209, 248, 239);
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1118, 600);
            ControlBox = false;
            Controls.Add(panelControl2);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DeleteBookingForm";
            Text = "DeleteBookingForm";
            WindowState = FormWindowState.Maximized;
            Load += DeleteBookingForm_Load;
            ((System.ComponentModel.ISupportInitialize)lookupBookings.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)searchLookUpEdit1View).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl2).EndInit();
            panelControl2.ResumeLayout(false);
            panelControl2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.SearchLookUpEdit lookupBookings;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private Label label1;
        private DevExpress.XtraEditors.SimpleButton deleteBtn;
        private DevExpress.XtraEditors.SimpleButton clearBtn;
        private DevExpress.XtraEditors.LabelControl lblInfo;
    }
}