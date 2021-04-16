using System;
using System.Drawing;
using System.Windows.Forms;
using WinformsPokedex.Controls;

namespace WinformsPokedex.Views
{
    public partial class FormPokedex : Form
    {
        private HomeUserControl homeUserControl;
        private PokedexUserControl pokedexUserControl;

        public FormPokedex()
        {
            InitializeComponent();

            homeUserControl = new HomeUserControl();
            pokedexUserControl = new PokedexUserControl();
        }

        private void ListPokemon_Load(object sender, EventArgs e)
        {

        }

        private void FormPokedex_Load(object sender, EventArgs e)
        {
            try
            {
                LoadUserControl();

            }
            catch (Exception ex)
            {
                CallErrorMessage(ex.Message);
            }
        }

        private void LoadUserControl()
        {
            try
            {
                PanelContainer.Controls.Add(homeUserControl);
            }
            catch (Exception ex)
            {
                CallErrorMessage(ex.Message);
            }
        }

        private void PanelDrawerHome_MouseEnter(object sender, EventArgs e)
        {
            PanelDrawerHome.BackColor = Color.LightGray;
        }

        private void PanelDrawerHome_MouseLeave(object sender, EventArgs e)
        {
            PanelDrawerHome.BackColor = Color.Transparent;
        }

        private void PanelDrawerDex_MouseEnter(object sender, EventArgs e)
        {
            PanelDrawerDex.BackColor = Color.LightGray;
        }

        private void PanelDrawerDex_MouseLeave(object sender, EventArgs e)
        {
            PanelDrawerDex.BackColor = Color.Transparent;
        }

        private void PanelDrawerHome_Click(object sender, EventArgs e)
        {
            try
            {
                PanelContainer.Controls.Clear();
                PanelContainer.Controls.Add(homeUserControl);
            }
            catch (Exception ex)
            {
                CallErrorMessage(ex.Message);
            }
        }

        private void PanelDrawerDex_Click(object sender, EventArgs e)
        {
            try
            {
                PanelContainer.Controls.Clear();
                PanelContainer.Controls.Add(pokedexUserControl);
            }
            catch (Exception ex)
            {
                CallErrorMessage(ex.Message);
            }
        }

        private void PictureBoxSearch_Click(object sender, EventArgs e)
        {
            try
            {
                // Search.
                if (string.IsNullOrEmpty(TextBoxSearch.Text))
                {
                    CallErrorMessage("Please provide a Pokemon name or number in the Search box provided");
                    return;
                }
                else
                {
                    using (var formPokeDetails = new FormPokemonDetails())
                    {
                        formPokeDetails.ShowDialog(this);
                    }
                }
            }
            catch (Exception ex)
            {
                CallErrorMessage(ex.Message);
            }
        }

        private void CallErrorMessage(string message)
        {
            using (var formPokeDetails = new FormCustomMessageBox("Error Message", message, true))
            {
                formPokeDetails.ShowDialog(this);
            }
        }
    }
}
