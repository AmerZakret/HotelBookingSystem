using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using HotelBooking.Services;

namespace HotelBooking.pages.Feedbacks
{
	public partial class ViewFeedbackForm: DevExpress.XtraEditors.XtraForm
	{
        private readonly FeedbackService feedbackService;
        public ViewFeedbackForm()
		{
            InitializeComponent();
            string connectionString = "Data Source=DESKTOP-SNC9H22\\MSSQLSERVER02; Initial Catalog=HotelDB; Integrated Security=True; TrustServerCertificate=True";
            feedbackService = new FeedbackService(connectionString);
        }
        private void ViewFeedbackForm_Load(object sender, EventArgs e)
        {
            LoadFeedback();
        }

        private void LoadFeedback()
        {
            var feedbacks = feedbackService.GetAllFeedback();
            feedbackGrid.DataSource = feedbacks;
        }
    }
}