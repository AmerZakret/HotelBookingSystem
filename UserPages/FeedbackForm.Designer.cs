namespace HotelBooking.UserPages
{
    partial class FeedbackForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            lblTitle = new Label();
            txtFeedback = new TextBox();
            btnSubmit = new Button();
            btnArrow = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(630, 78);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Feedback";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtFeedback
            // 
            txtFeedback.Font = new Font("Segoe UI", 14F);
            txtFeedback.Location = new Point(70, 118);
            txtFeedback.Margin = new Padding(4, 4, 4, 4);
            txtFeedback.Multiline = true;
            txtFeedback.Name = "txtFeedback";
            txtFeedback.Size = new Size(466, 195);
            txtFeedback.TabIndex = 2;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.FromArgb(0, 122, 204);
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(70, 340);
            btnSubmit.Margin = new Padding(4, 4, 4, 4);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(175, 59);
            btnSubmit.TabIndex = 3;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnArrow
            // 
            btnArrow.BackColor = Color.FromArgb(209, 248, 239);
            btnArrow.Cursor = Cursors.Hand;
            btnArrow.FlatAppearance.BorderSize = 0;
            btnArrow.FlatStyle = FlatStyle.Flat;
            btnArrow.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnArrow.Location = new Point(12, 13);
            btnArrow.Margin = new Padding(4, 4, 4, 4);
            btnArrow.Name = "btnArrow";
            btnArrow.Size = new Size(52, 52);
            btnArrow.TabIndex = 0;
            btnArrow.Text = "←";
            btnArrow.UseVisualStyleBackColor = false;
            btnArrow.Click += btnArrow_Click;
            // 
            // FeedbackForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(209, 248, 239);
            ClientSize = new Size(630, 458);
            Controls.Add(btnArrow);
            Controls.Add(lblTitle);
            Controls.Add(txtFeedback);
            Controls.Add(btnSubmit);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 4, 4, 4);
            MaximizeBox = false;
            Name = "FeedbackForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Feedback";
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtFeedback;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnArrow;
    }
} 