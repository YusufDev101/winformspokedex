using Flurl.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinformsPokedex.Models;

namespace WinformsPokedex.WebRequests
{
    public class HttpCall
    {
        public HttpCall()
        {

        }

        public async Task<Pokemon> GetPokemonCounts(int number)
        {
            try
            {
                var url = HttpHelper.Pokemon + number.ToString();

                var dataObj = await url.GetStringAsync();

                var pokemon = JsonConvert.DeserializeObject<Pokemon>(dataObj.ToString());

                //var PokemonObject = JsonConvert.DeserializeObject<PokemonCounts>(dataObj)();

                return pokemon;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        } 
    }
}
