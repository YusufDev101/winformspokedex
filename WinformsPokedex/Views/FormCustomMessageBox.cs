using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WinformsPokedex.Properties;

namespace WinformsPokedex.Views
{
    public partial class FormCustomMessageBox : Form
    {
        public FormCustomMessageBox(string title, string message, bool isError)
        {
            InitializeComponent();

            LabelTitle.Text = title;
            LabelMessage.Text = message;

            //pictureBox1.BackColor = isError ? ColorTranslator.FromHtml("#E34C5E") : ColorTranslator.FromHtml("#2DD784");
           // PictureIcon.BackColor = isError ? ColorTranslator.FromHtml("#E34C5E") : ColorTranslator.FromHtml("#2DD784");
            PictureIcon.Image = isError ? Resources.undraw_warning_cyit : Resources.undraw_well_done_i2wr;

            BackColor = Color.LightGray;
            TransparencyKey = Color.LightGray;
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
