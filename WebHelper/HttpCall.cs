using Flurl.Http;
using System;
using System.Threading.Tasks;

namespace WebHelper
{
    public class HttpCall
    {
        public HttpCall()
        {

        }

        public async Task<string> GetPokemonCounts(int number)
        {
            try
            {
                var url = HttpHelper.Pokemon + number.ToString();

                var dataObj = await url.GetStringAsync();

                return dataObj;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
