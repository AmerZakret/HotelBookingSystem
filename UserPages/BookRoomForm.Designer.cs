namespace HotelBooking.UserPages
{
    partial class BookRoomForm
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
            lblRoomNumber = new Label();
            lblRoomType = new Label();
            lblPrice = new Label();
            textGuestName = new TextBox();
            lblGuestName = new Label();
            btnConfirmBooking = new Button();
            pictureBoxRoom = new PictureBox();
            btnArrow = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRoom).BeginInit();
            SuspendLayout();
            // 
            // lblRoomNumber
            // 
            lblRoomNumber.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblRoomNumber.Location = new Point(50, 50);
            lblRoomNumber.Name = "lblRoomNumber";
            lblRoomNumber.Size = new Size(400, 35);
            lblRoomNumber.TabIndex = 0;
            // 
            // lblRoomType
            // 
            lblRoomType.Font = new Font("Segoe UI", 14F);
            lblRoomType.Location = new Point(50, 100);
            lblRoomType.Name = "lblRoomType";
            lblRoomType.Size = new Size(400, 30);
            lblRoomType.TabIndex = 1;
            // 
            // lblPrice
            // 
            lblPrice.Font = new Font("Segoe UI", 14F);
            lblPrice.Location = new Point(50, 150);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(400, 30);
            lblPrice.TabIndex = 2;
            // 
            // textGuestName
            // 
            textGuestName.Font = new Font("Segoe UI", 12F);
            textGuestName.Location = new Point(50, 250);
            textGuestName.Name = "textGuestName";
            textGuestName.Size = new Size(300, 29);
            textGuestName.TabIndex = 5;
            // 
            // lblGuestName
            // 
            lblGuestName.Font = new Font("Segoe UI", 14F);
            lblGuestName.Location = new Point(50, 220);
            lblGuestName.Name = "lblGuestName";
            lblGuestName.Size = new Size(200, 30);
            lblGuestName.TabIndex = 4;
            lblGuestName.Text = "Guest Name:";
            // 
            // btnConfirmBooking
            // 
            btnConfirmBooking.BackColor = Color.FromArgb(0, 122, 204);
            btnConfirmBooking.FlatStyle = FlatStyle.Flat;
            btnConfirmBooking.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnConfirmBooking.ForeColor = Color.White;
            btnConfirmBooking.Location = new Point(50, 320);
            btnConfirmBooking.Name = "btnConfirmBooking";
            btnConfirmBooking.Size = new Size(200, 45);
            btnConfirmBooking.TabIndex = 6;
            btnConfirmBooking.Text = "Confirm Booking";
            btnConfirmBooking.UseVisualStyleBackColor = false;
            btnConfirmBooking.Click += btnConfirmBooking_Click;
            // 
            // pictureBoxRoom
            // 
            pictureBoxRoom.Location = new Point(500, 50);
            pictureBoxRoom.Name = "pictureBoxRoom";
            pictureBoxRoom.Size = new Size(350, 350);
            pictureBoxRoom.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxRoom.TabIndex = 3;
            pictureBoxRoom.TabStop = false;
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
            // BookRoomForm
            // 
            Appearance.BackColor = Color.FromArgb(209, 248, 239);
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 450);
            Controls.Add(btnArrow);
            Controls.Add(lblRoomNumber);
            Controls.Add(lblRoomType);
            Controls.Add(lblPrice);
            Controls.Add(pictureBoxRoom);
            Controls.Add(lblGuestName);
            Controls.Add(textGuestName);
            Controls.Add(btnConfirmBooking);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "BookRoomForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Book Room";
            ((System.ComponentModel.ISupportInitialize)pictureBoxRoom).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label lblRoomNumber;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox textGuestName;
        private System.Windows.Forms.Label lblGuestName;
        private System.Windows.Forms.Button btnConfirmBooking;
        private System.Windows.Forms.PictureBox pictureBoxRoom;
        private System.Windows.Forms.Button btnArrow;
    }
}