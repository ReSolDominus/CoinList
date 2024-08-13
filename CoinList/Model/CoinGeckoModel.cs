using CoinList.ViewModel;
using Newtonsoft.Json;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace CoinList.Model
{
    public class CoinGeckoModel
    {
        private static readonly HttpClient client = new HttpClient();
        public MainWindowViewModel _viewModel;
        private DispatcherTimer _timer;

        public CoinGeckoModel(MainWindowViewModel viewModel)
        {
            client.BaseAddress = new Uri("https://api.coingecko.com");

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("X-Cg-Demo-Api-Key", "CG-bYQBma73zDroTq2xVsonwvYD");

            _viewModel = viewModel;

            TrendingSearchList();
            /*_timer = new DispatcherTimer();
            _timer.Interval = TimeSpan.FromSeconds(100);
            _timer.Tick += async (sender, e) => await TrendingSearchList();
            _timer.Start();*/
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
                for (int i = 0; i < deserializeData.Coins.Count; i++)
                {
                    deserializeData.Coins[i].Item.Score++;
                }
                _viewModel.Update(deserializeData);
                Debug.WriteLine("Coins count: " + _viewModel.CurrentCoins.Count);
            }
            else
            {

            }
        }

    }
}
