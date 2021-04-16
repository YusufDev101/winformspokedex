using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformsPokedex.Views;

namespace WinformsPokedex
{
    public partial class FormSplash : Form
    {
        private Timer _timer;
        private int count = 0;
        public FormSplash()
        {
            InitializeComponent();

            _timer = new Timer();
            _timer.Interval = 1000;
            _timer.Enabled = true;
            _timer.Tick += _timer_Tick;
        }

        private void _timer_Tick(object sender, EventArgs e)
        {
            try
            {
                if (LabelLoading.Text == "Loading.")
                {
                    LabelLoading.Text = "Loading..";
                }
                else if (LabelLoading.Text == "Loading..")
                {
                    LabelLoading.Text = "Loading...";
                }
                else if (LabelLoading.Text == "Loading...")
                {
                    LabelLoading.Text = "Loading";
                }
                else if (LabelLoading.Text == "Loading")
                {
                    LabelLoading.Text = "Loading.";
                }

                count++;

                if (count == 5)
                {
                    var formPokdex = new FormPokedex();
                    Hide();
                    formPokdex.Show();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
