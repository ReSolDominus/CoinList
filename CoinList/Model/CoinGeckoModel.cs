using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace CoinList.Model
{
    public class CoinGeckoModel
    {
        private static readonly HttpClient client = new HttpClient();
        public CoinGeckoModel()
        {
            client.BaseAddress = new Uri("https://api.coingecko.com");

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("X-Cg-Demo-Api-Key", "CG-bYQBma73zDroTq2xVsonwvYD");
        }

        public async Task Ping()
        {
            HttpResponseMessage response = await client.GetAsync("/api/v3/ping");

            if (response.IsSuccessStatusCode)
            {
                string responseData = await response.Content.ReadAsStringAsync();
            }
            else
            {

            }
        }

        public async Task TrendingSearchList()
        {
            HttpResponseMessage response = await client.GetAsync("/api/v3/search/trending");
            if (response.IsSuccessStatusCode)
            {
                string responseData = await response.Content.ReadAsStringAsync();
                CoinsModel deserializeData = JsonConvert.DeserializeObject<CoinsModel>(responseData);
            }
            else
            {

            }
        }

    }
}
