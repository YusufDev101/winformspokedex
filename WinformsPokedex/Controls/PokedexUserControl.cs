using Svg;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformsPokedex.CustomViews;
using WinformsPokedex.Models;

namespace WinformsPokedex.Controls
{
    public partial class PokedexUserControl : UserControl
    {
        private BackgroundWorker backgroundWorker1;

        private List<Pokemon> pokemons;

        private LoadingForm loadingForm;


        public PokedexUserControl()
        {
            InitializeComponent();
            pokemons = new List<Pokemon>();
            loadingForm = new LoadingForm();
            backgroundWorker1 = new BackgroundWorker();
        }

        private void HomeUserControl_Load(object sender, EventArgs e)
        {
            try
            {
                LoadPokemonCount();
                LoadAllDataAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private async void LoadPokemonCount()
        {
            try
            {
                PokemonListItemCounter[] pokemonCount = new PokemonListItemCounter[8];

                pokemonCount[1] = new PokemonListItemCounter();
                pokemonCount[1].Number = 151.ToString();
                pokemonCount[1].Generation = "Generation 1";
                flowLayoutPanel2.Controls.Add(pokemonCount[1]);

                pokemonCount[2] = new PokemonListItemCounter();
                pokemonCount[2].Number = 100.ToString();
                pokemonCount[2].Generation = "Generation 2";
                flowLayoutPanel2.Controls.Add(pokemonCount[2]);

                pokemonCount[3] = new PokemonListItemCounter();
                pokemonCount[3].Number = 135.ToString();
                pokemonCount[3].Generation = "Generation 3";
                flowLayoutPanel2.Controls.Add(pokemonCount[3]);

                pokemonCount[4] = new PokemonListItemCounter();
                pokemonCount[4].Number = 107.ToString();
                pokemonCount[4].Generation = "Generation 4";
                flowLayoutPanel2.Controls.Add(pokemonCount[4]);

                pokemonCount[5] = new PokemonListItemCounter();
                pokemonCount[5].Number = 156.ToString();
                pokemonCount[5].Generation = "Generation 5";
                flowLayoutPanel2.Controls.Add(pokemonCount[5]);

                pokemonCount[6] = new PokemonListItemCounter();
                pokemonCount[6].Number = 72.ToString();
                pokemonCount[6].Generation = "Generation 6";
                flowLayoutPanel2.Controls.Add(pokemonCount[6]);

                pokemonCount[7] = new PokemonListItemCounter();
                pokemonCount[7].Number = 86.ToString();
                pokemonCount[7].Generation = "Generation 7";
                flowLayoutPanel2.Controls.Add(pokemonCount[7]);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private async Task LoadPokemon()
        {
            try
            {
                for (int i = 1; i < 50; i++)
                {
                    pokemons.Add(await Program.HttpCall.GetPokemonCounts(i));
                }

                PokemonListItem[] pokemonListItem = new PokemonListItem[pokemons.Count];


                for (int i = 0; i < pokemons.Count; i++)
                {
                    pokemonListItem[i] = new PokemonListItem();
                    pokemonListItem[i].Number = pokemons[i].id.ToString();
                    pokemonListItem[i].Name = UppercaseFirst(pokemons[i].name);
                    pokemonListItem[i].ImageSrc = pokemons[i].sprites.front_default;

                    pokemonListItem[i].Type1 = UppercaseFirst(pokemons[i].types[0].type.name);
                    pokemonListItem[i].ColorType = UppercaseFirst(pokemons[i].types[0].type.name);

                    var SecondType = pokemons[i].types.Length < 2 ? "" : pokemons[i].types[1].type.name;

                    pokemonListItem[i].Type2 = UppercaseFirst(SecondType);

                    flowLayoutPanel1.Controls.Add(pokemonListItem[i]);

                }

                loadingForm.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public Image ConvertSvgToImage(string svgFile, int width, int height)
        {
            Image imgResult = null;
            if (System.IO.File.Exists(svgFile))
            {
                SvgDocument sdoc = SvgDocument.Open(svgFile);

                #region  Parse the viewBox value in the Svg file

                string xml = sdoc.ToString();
                string beginStr = "viewBox=";
                string endStr = "\" ";
                int begin = xml.IndexOf(beginStr);
                if (begin > 0)
                {
                    begin = begin + beginStr.Length;
                    int end = xml.IndexOf(endStr, begin);
                    string viewBox = xml.Substring(begin, end - begin);
                    viewBox = viewBox.Replace("\"", String.Empty).Replace("'", String.Empty);
                    if (!String.IsNullOrEmpty(viewBox))
                    {
                        string[] vbs = viewBox.Split(new char[] { ' ' });
                        if (vbs.Length == 4)
                        {
                            float vbx = 0.0f;
                            float vby = 0.0f;
                            float vbw = 0.0f;
                            float vbh = 0.0f;
                            float.TryParse(vbs[0], out vbx);
                            float.TryParse(vbs[1], out vby);
                            float.TryParse(vbs[2], out vbw);
                            float.TryParse(vbs[3], out vbh);
                            sdoc.ViewBox = new SvgViewBox(vbx, vby, vbw, vbh);
                        }
                    }
                }

                #endregion

                sdoc.Width = width;
                sdoc.Height = height;
                Bitmap bitmap = sdoc.Draw();
                using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
                {
                    bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Png);                    //Turn the svg into png according to the specified width and height and put it into the memory stream
                    imgResult = Image.FromStream(ms);
                    //bitmap.Save("e:\\test.png", System.Drawing.Imaging.ImageFormat.Png); //Save the png image to disk
                }
            }
            return imgResult;
        }

        private async void LoadAllDataAsync()
        {
            try
            {
                loadingForm.Show(this);
                // now ask the UI thread to update itself

                this.Invoke((MethodInvoker)async delegate
                {
                    // this code runs on the UI thread!
                    await LoadPokemon();

                });
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
               
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // lblCounter.Text = "Complete";
            loadingForm.Close();
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // lblCounter.Text = (e.ProgressPercentage.ToString());
        }

        private string UppercaseFirst(string s)
        {
            // Check for empty string.
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }

            // Return char and concat substring.
            return char.ToUpper(s[0]) + s.Substring(1);
        }
    }
}
