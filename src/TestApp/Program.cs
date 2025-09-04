using AutoUpdaterDotNET;

namespace TestApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            AutoUpdater.Start("https://raw.githubusercontent.com/atkhssn/TestApp/main/update/updates.xml");
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}