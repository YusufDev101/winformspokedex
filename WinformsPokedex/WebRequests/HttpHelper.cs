using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformsPokedex.WebRequests
{
    public static class HttpHelper
    {
        public static string Pokemon = "https://pokeapi.co/api/v2/pokemon/";
        public static string PokemonMega = "https://pokeapi.co/api/v2/pokemon?offset=930&limit=964#";
        public static string PokemonCounts = "https://pokeapi.glitch.me/v1/pokemon/counts";
    }
}
