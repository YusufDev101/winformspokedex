using Newtonsoft.Json;
using System;
using System.Threading.Tasks;
using WinformsPokedex.Models;

namespace WinformsPokedex.Controller
{
    internal class PokedexController
    {
        public PokedexController()
        {

        }

        public Pokemon ConvertPokemon(string rawData)
        {
            try
            {
                var pokemon = JsonConvert.DeserializeObject<Pokemon>(rawData);
                return pokemon;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
