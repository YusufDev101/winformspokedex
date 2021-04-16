using System.ComponentModel;
using System.Windows.Forms;

namespace WinformsPokedex.Controls
{
    public partial class PokemonListItemCounter : UserControl
    {
        public PokemonListItemCounter()
        {
            InitializeComponent();
        }

        private string _number;

        [Category("Custom Props")]
        public string Number
        {
            get { return _number; }
            set
            {
                _number = value;
                LabelNumber.Text = value;
            }
        }

        private string _generation;

        [Category("Custom Props")]
        public string Generation
        {
            get { return _generation; }
            set
            {
                _generation = value;
                LabelGeneration.Text = value;
            }
        }

        private void materialCard1_Click(object sender, System.EventArgs e)
        {

        }
    }
}
