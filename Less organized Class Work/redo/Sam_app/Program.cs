using SamsMusicPlayer;
using System;
using System.Windows.Forms;

namespace Sam_app
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Sams_MusicPlayer());
        }
    }
}
