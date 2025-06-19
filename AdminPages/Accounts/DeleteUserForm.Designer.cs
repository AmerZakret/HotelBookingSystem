namespace HotelBooking.pages.Accounts
{
    partial class DeleteUserForm
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
            lblInfo = new DevExpress.XtraEditors.LabelControl();
            deleteBtn = new DevExpress.XtraEditors.SimpleButton();
            clearBtn = new DevExpress.XtraEditors.SimpleButton();
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)lookupUsers.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)searchLookUpEdit1View).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            SuspendLayout();
            // 
            // lookupUsers
            // 
            lookupUsers.Location = new Point(92, 137);
            lookupUsers.Name = "lookupUsers";
            lookupUsers.Properties.Appearance.Font = new Font("Tahoma", 12F);
            lookupUsers.Properties.Appearance.Options.UseFont = true;
            lookupUsers.Properties.AutoHeight = false;
            lookupUsers.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            lookupUsers.Properties.NullText = "Select User";
            lookupUsers.Properties.PopupView = searchLookUpEdit1View;
            lookupUsers.Size = new Size(236, 35);
            lookupUsers.TabIndex = 0;
            lookupUsers.EditValueChanged += LookupUsers_EditValueChanged;
            // 
            // searchLookUpEdit1View
            // 
            searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // lblInfo
            // 
            lblInfo.Location = new Point(34, 69);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(0, 13);
            lblInfo.TabIndex = 1;
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
            // panelControl1
            // 
            panelControl1.Controls.Add(label1);
            panelControl1.Controls.Add(deleteBtn);
            panelControl1.Controls.Add(clearBtn);
            panelControl1.Controls.Add(lookupUsers);
            panelControl1.Controls.Add(lblInfo);
            panelControl1.Location = new Point(349, 100);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new Size(420, 370);
            panelControl1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F);
            label1.ForeColor = Color.CadetBlue;
            label1.Location = new Point(158, 17);
            label1.Name = "label1";
            label1.Size = new Size(90, 19);
            label1.TabIndex = 4;
            label1.Text = "Delete User";
            // 
            // DeleteUserForm
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
            Name = "DeleteUserForm";
            Text = "DeleteUserForm";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)lookupUsers.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)searchLookUpEdit1View).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            panelControl1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SearchLookUpEdit lookupUsers;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl lblInfo;
        private DevExpress.XtraEditors.SimpleButton deleteBtn;
        private DevExpress.XtraEditors.SimpleButton clearBtn;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private Label label1;
    }
}