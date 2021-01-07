using System;
using System.Windows.Forms;
using System.IO;

namespace Ares
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (File.Exists(@"C:\Windows\Fonts\msyhl.ttc") == true && File.Exists(@"C:\Windows\Fonts\msyhbd.ttc") == true)
                Application.Run(new LoginForm());
            else
                Application.Run(new FontForm());
        }
    }
}
