namespace HotelBooking.pages.Rooms
{
    partial class DeleteRoomForm
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
            roomLookup = new DevExpress.XtraEditors.SearchLookUpEdit();
            searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            deleteBtn = new DevExpress.XtraEditors.SimpleButton();
            clearBtn = new DevExpress.XtraEditors.SimpleButton();
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            label1 = new Label();
            lblInfo = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)roomLookup.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)searchLookUpEdit1View).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            SuspendLayout();
            // 
            // roomLookup
            // 
            roomLookup.Location = new Point(92, 133);
            roomLookup.Name = "roomLookup";
            roomLookup.Properties.Appearance.Font = new Font("Tahoma", 12F);
            roomLookup.Properties.Appearance.Options.UseFont = true;
            roomLookup.Properties.AutoHeight = false;
            roomLookup.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            roomLookup.Properties.NullText = "Select Room";
            roomLookup.Properties.PopupView = searchLookUpEdit1View;
            roomLookup.Size = new Size(236, 35);
            roomLookup.TabIndex = 0;
            // 
            // searchLookUpEdit1View
            // 
            searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // deleteBtn
            // 
            deleteBtn.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            deleteBtn.Appearance.Options.UseBackColor = true;
            deleteBtn.Location = new Point(243, 199);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(85, 35);
            deleteBtn.TabIndex = 1;
            deleteBtn.Text = "Delete";
            deleteBtn.Click += deleteBtn_Click;
            // 
            // clearBtn
            // 
            clearBtn.Appearance.BackColor = Color.RoyalBlue;
            clearBtn.Appearance.Options.UseBackColor = true;
            clearBtn.Location = new Point(92, 199);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(85, 35);
            clearBtn.TabIndex = 2;
            clearBtn.Text = "Clear";
            clearBtn.Click += clearBtn_Click;
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(label1);
            panelControl1.Controls.Add(clearBtn);
            panelControl1.Controls.Add(deleteBtn);
            panelControl1.Controls.Add(roomLookup);
            panelControl1.Controls.Add(lblInfo);
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
            label1.Location = new Point(158, 17);
            label1.Name = "label1";
            label1.Size = new Size(100, 19);
            label1.TabIndex = 4;
            label1.Text = "Delete Room";
            // 
            // lblInfo
            // 
            lblInfo.Location = new Point(34, 69);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(0, 13);
            lblInfo.TabIndex = 1;
            // 
            // DeleteRoomForm
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
            Name = "DeleteRoomForm";
            WindowState = FormWindowState.Maximized;
            Load += DeleteRoomForm_Load;
            ((System.ComponentModel.ISupportInitialize)roomLookup.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)searchLookUpEdit1View).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            panelControl1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.SearchLookUpEdit roomLookup;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.SimpleButton deleteBtn;
        private DevExpress.XtraEditors.SimpleButton clearBtn;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private Label label1;
        private DevExpress.XtraEditors.LabelControl lblInfo;
    }
}