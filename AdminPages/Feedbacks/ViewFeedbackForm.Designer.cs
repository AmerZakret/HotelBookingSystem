namespace HotelBooking.pages.Feedbacks
{
    partial class ViewFeedbackForm
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
            feedbackGrid = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)feedbackGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            SuspendLayout();
            // 
            // feedbackGrid
            // 
            feedbackGrid.Dock = DockStyle.Fill;
            feedbackGrid.Font = new Font("Tahoma", 12F);
            feedbackGrid.Location = new Point(0, 0);
            feedbackGrid.MainView = gridView1;
            feedbackGrid.Name = "feedbackGrid";
            feedbackGrid.Size = new Size(957, 576);
            feedbackGrid.TabIndex = 0;
            feedbackGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.Appearance.GroupPanel.Font = new Font("Tahoma", 12F);
            gridView1.Appearance.GroupPanel.Options.UseFont = true;
            gridView1.Appearance.Row.Font = new Font("Tahoma", 12F);
            gridView1.Appearance.Row.Options.UseFont = true;
            gridView1.AppearancePrint.FilterPanel.Font = new Font("Tahoma", 12F);
            gridView1.AppearancePrint.FilterPanel.Options.UseFont = true;
            gridView1.AppearancePrint.GroupFooter.Font = new Font("Tahoma", 12F);
            gridView1.AppearancePrint.GroupFooter.Options.UseFont = true;
            gridView1.AppearancePrint.GroupRow.Font = new Font("Tahoma", 12F);
            gridView1.AppearancePrint.GroupRow.Options.UseFont = true;
            gridView1.AppearancePrint.HeaderPanel.Font = new Font("Tahoma", 12F);
            gridView1.AppearancePrint.HeaderPanel.Options.UseFont = true;
            gridView1.AppearancePrint.Row.Font = new Font("Tahoma", 12F);
            gridView1.AppearancePrint.Row.Options.UseFont = true;
            gridView1.GridControl = feedbackGrid;
            gridView1.GroupPanelText = "Feedbacks";
            gridView1.Name = "gridView1";
            gridView1.OptionsBehavior.Editable = false;
            // 
            // ViewFeedbackForm
            // 
            Appearance.BackColor = Color.FromArgb(209, 248, 239);
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 576);
            ControlBox = false;
            Controls.Add(feedbackGrid);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ViewFeedbackForm";
            Text = "ViewFeedbackForm";
            WindowState = FormWindowState.Maximized;
            Load += ViewFeedbackForm_Load;
            ((System.ComponentModel.ISupportInitialize)feedbackGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraGrid.GridControl feedbackGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}