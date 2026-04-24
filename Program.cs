using SuperMart_Pro.View.Auth;
using SuperMart_Pro.View.Admin;
using SuperMart_Pro.View.Manager;
using SuperMart_Pro.View.Cashier;
using SuperMart_Pro.View.Branch;
using SuperMart_Pro.View.Customer;

namespace SuperMart_Pro
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
            Application.Run(new ViewAllAdminGUI());
        }
    }
}