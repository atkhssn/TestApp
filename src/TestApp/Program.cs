using AutoUpdaterDotNET;

namespace TestApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AutoUpdater.Start("https://raw.githubusercontent.com/atkhssn/TestApp/main/updates.xml");
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}