using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WinformsPokedex.Controls
{
    public partial class PokemonStats : UserControl
    {
        public PokemonStats()
        {
            InitializeComponent();
        }

        private string _type;

        [Category("Custom Props")]
        public string Type
        {
            get { return _type; }
            set
            {
                _type = value;
                LabelType.Text = value;
            }
        }

        private string _stat;

        [Category("Custom Props")]
        public string Stat
        {
            get { return _stat; }
            set
            {
                _stat = value;
                LabelStat.Text = value;
            }
        }

        private string _color;

        [Category("Custom Props")]
        public string ColorGet
        {
            get { return _color; }
            set
            {
                _color = value;
                PanelBackground.BackColor = ColorTranslator.FromHtml(value);
            }
        }

        private void materialCard1_Click(object sender, System.EventArgs e)
        {

        }
    }
}
