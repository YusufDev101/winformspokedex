using System;
using System.Windows.Forms;
using WebHelper;

namespace WinformsPokedex
{
    static class Program
    {
        public static HttpCall HttpCall;

        [STAThread]
        static void Main()
        {
            HttpCall = new HttpCall();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormSplash());
        }
    }
}
