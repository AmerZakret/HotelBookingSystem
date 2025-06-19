namespace HotelBooking.UserPages
{
    partial class ViewAvailableRoomsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelRooms;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button btnArrow;

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
            flowLayoutPanelRooms = new FlowLayoutPanel();
            lblHeader = new Label();
            topPanel = new Panel();
            btnArrow = new Button();
            topPanel.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanelRooms
            // 
            flowLayoutPanelRooms.AutoScroll = true;
            flowLayoutPanelRooms.BackColor = Color.FromArgb(209, 248, 239);
            flowLayoutPanelRooms.Dock = DockStyle.Fill;
            flowLayoutPanelRooms.Location = new Point(0, 70);
            flowLayoutPanelRooms.Name = "flowLayoutPanelRooms";
            flowLayoutPanelRooms.Padding = new Padding(10);
            flowLayoutPanelRooms.Size = new Size(906, 515);
            flowLayoutPanelRooms.TabIndex = 0;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblHeader.ForeColor = Color.FromArgb(54, 116, 181);
            lblHeader.Location = new Point(70, 15);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(269, 45);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Available Rooms";
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.FromArgb(209, 248, 239);
            topPanel.Controls.Add(lblHeader);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(906, 70);
            topPanel.TabIndex = 2;
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
            btnArrow.TabIndex = 1;
            btnArrow.Text = "←";
            btnArrow.UseVisualStyleBackColor = false;
            btnArrow.Click += btnArrow_Click;
            // 
            // ViewAvailableRoomsForm
            // 
            ClientSize = new Size(906, 585);
            Controls.Add(btnArrow);
            Controls.Add(flowLayoutPanelRooms);
            Controls.Add(topPanel);
            Name = "ViewAvailableRoomsForm";
            Text = "Available Rooms";
            Load += ViewAvailableRoomsForm_Load;
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
    }
}