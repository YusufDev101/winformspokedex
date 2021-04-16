using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using WinformsPokedex.Views;

namespace WinformsPokedex.Controls
{
    public partial class PokemonListItem : UserControl
    {
        public PokemonListItem()
        {
            InitializeComponent();
        }

        #region Properties

        private string _number;
        private string _imageSrc;
        private string _name;
        private string _type1;
        private string _type2;
        private string _color;

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

        [Category("Custom Props")]
        public string ImageSrc
        {
            get { return _imageSrc; }
            set
            {
                _imageSrc = value;
                ImagePokemon.ImageLocation = value;
            }
        }

        [Category("Custom Props")]
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                LabelName.Text = value;
            }
        }

        [Category("Custom Props")]
        public string Type1
        {
            get { return _type1; }
            set
            {
                _type1 = value;
                LabelTypes1.Text = value;
            }
        }     

        [Category("Custom Props")]
        public string Type2
        {
            get { return _type2; }
            set
            {
                _type2 = value;
                LabelTypes2.Text = value;
            }
        }

        [Category("Custom Props")]
        public string ColorType
        {
            get { return _color; }
            set
            {
                _color = value;
                PanelColor.BackColor = ColorTranslator.FromHtml(SetColor(value));
            }
        }

        #endregion

        private string SetColor(string name) {

            switch (name)
            {
                case "Bug":
                    return "#92bc2c";
                case "Dark":
                    return "#595761";
                case "Dragon":
                    return "#0c69c8";
                case "Electric":
                    return "#f2d94e";
                case "Fairy":
                    return "#ee90e6";
                case "Fighting":
                    return "#d3425f";
                case "Fire":
                    return "#fba54c";
                case "Flying":
                    return "#a1bbec";
                case "Ghost":
                    return "#5f6dbc";
                case "Grass":
                    return "#5fbd58";
                case "Ground":
                    return "#da7c4d";
                case "Ice":
                    return "#75d0c1";
                case "Normal":
                    return "#a0a29f";
                case "Poison":
                    return "#b763cf";
                case "Psychic":
                    return "#fa8581";
                case "Rock":
                    return "#c9bb8a";
                case "Steel":
                    return "#5695a3";
                case "Water":
                    return "#539ddf";
                default:
                    return "";
            }
        }

        private void materialCard1_Click(object sender, EventArgs e)
        {
            Console.WriteLine();
        }

        private void ImagePokemon_Click(object sender, EventArgs e)
        {
            Console.WriteLine();
        }

        private void PictureMenu_Click(object sender, EventArgs e)
        {
            try
            {
                using (var formPokemonDetails = new FormPokemonDetails())
                {
                    formPokemonDetails.ShowDialog(this);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
