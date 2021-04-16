using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformsPokedex.WebRequests;

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
