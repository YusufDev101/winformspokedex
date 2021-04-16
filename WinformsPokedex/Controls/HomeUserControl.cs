using LiveCharts;
using LiveCharts.Wpf;
using System.Windows.Forms;
using System;

namespace WinformsPokedex.Controls
{
    public partial class HomeUserControl : UserControl
    {
        public HomeUserControl()
        {
            InitializeComponent();

            cartesianChart1.Series = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "Total",
                    Values = new ChartValues<double> { 151, 100, 135, 107, 156, 72, 88, 89 }
                }
            };

            cartesianChart1.AxisX.Add(new Axis
            {
                Title = "Generation - (898)",
                Labels = new[] { "1", "2", "3", "4", "5", "6", "7", "8" }
            });

            cartesianChart1.AxisY.Add(new Axis
            {
                LabelFormatter = value => value.ToString()
            });
        }

        private void CartesianChart1OnDataClick(object sender, ChartPoint chartPoint)
        {
            MessageBox.Show("You clicked (" + chartPoint.X + "," + chartPoint.Y + ")");
        }

        private void HomeUserControl_Load(object sender, EventArgs e)
        {
            try
            {
                LoadPokemonCount();
                LoadPokemon();
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
                PokemonStats[] stats = new PokemonStats[1];

                stats[0] = new PokemonStats();
                stats[0].Type = "Pokemon";
                stats[0].Stat = 898.ToString();
                stats[0].ColorGet = "#FF9AA2";
                flowLayoutPanel1.Controls.Add(stats[0]);

                stats[0] = new PokemonStats();
                stats[0].Type = "Mega Evolves";
                stats[0].Stat = 49.ToString();
                stats[0].ColorGet = "#FFDAC1";
                flowLayoutPanel2.Controls.Add(stats[0]);

                stats[0] = new PokemonStats();
                stats[0].Type = "Pokemon Seasons";
                stats[0].Stat = 23.ToString();
                stats[0].ColorGet = "#B5EAD7";
                flowLayoutPanel3.Controls.Add(stats[0]);

                stats[0] = new PokemonStats();
                stats[0].Type = "Pokemon Movies";
                stats[0].Stat = 23.ToString();
                stats[0].ColorGet = "#C7CEEA";
                flowLayoutPanel4.Controls.Add(stats[0]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void LoadPokemon()
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
