using AutoUpdaterDotNET;

namespace TestApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            AutoUpdater.Start("https://raw.githubusercontent.com/atkhssn/TestApp/refs/heads/main/update/updates.xml?token=GHSAT0AAAAAADF3GAGYKPQIBL3HJUM6PCBO2FZXKSQ");
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}