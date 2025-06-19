using HotelBooking.pages.Accounts;
using HotelBooking.pages.Rooms;
using HotelBooking.UserPages;
using HotelBooking.Services;

namespace HotelBooking
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            
            // Set the application icon
            System.Drawing.Icon appIcon = new System.Drawing.Icon("hotelIcon.ico");
            Application.OpenForms.Cast<Form>().ToList().ForEach(form => form.Icon = appIcon);
            
            var loginForm = new Login();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                if (loginForm.UserRole != null && loginForm.UserRole.Equals("admin", StringComparison.OrdinalIgnoreCase))
                {
                    Application.Run(new Main());
                }
                else
                {
                    Application.Run(new UserMain());
                }
            }
        }
    }
}