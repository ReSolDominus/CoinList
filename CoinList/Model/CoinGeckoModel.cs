using CoinList.ViewModels;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace CoinList.Model
{
    public class CoinGeckoModel
    {
        private static readonly HttpClient _client = new HttpClient();  // Статичний екземпляр HttpClient для запитів до API
        private MainWindowViewModel _viewModelMain;                     // Посилання на ViewModel для головного вікна
        private CoinWindowViewModel _viewModelCoin;                     // Посилання на ViewModel для вікна монети

        // Конструктор, що приймає MainWindowViewModel
        public CoinGeckoModel(MainWindowViewModel viewModel)
        {
            _client.BaseAddress = new Uri("https://api.coingecko.com"); // Базова адреса для запитів до API
            _viewModelMain = viewModel;
        }

        // Конструктор, що приймає CoinWindowViewModel
        public CoinGeckoModel(CoinWindowViewModel viewModel)
        {
            _viewModelCoin = viewModel;
        }

        // Метод для перевірки доступності API
        public async Task Ping()
        {
            try
            {
                HttpResponseMessage response = await _client.GetAsync("/api/v3/ping");

                if (response.IsSuccessStatusCode)
                {
                    string responseData = await response.Content.ReadAsStringAsync();
                }
                else
                {
                    MessageBox.Show($"Ping failed with status code: {response.StatusCode}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ping failed: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        // Метод для отримання списку трендових пошукових запитів
        public async Task GetTrendingSearchList()
        {
            try
            {
                HttpResponseMessage response = await _client.GetAsync("/api/v3/search/trending");
                if (response.IsSuccessStatusCode)
                {
                    string responseData = await response.Content.ReadAsStringAsync();
                    CoinsModelMainWindow deserializeData = JsonConvert.DeserializeObject<CoinsModelMainWindow>(responseData);
                    for (int i = 0; i < deserializeData.Coins.Count; i++)
                    {
                        deserializeData.Coins[i].Item.Score++;
                    }
                    _viewModelMain.Update(deserializeData);
                }
                else
                {
                    MessageBox.Show($"Trending search list request failed with status code: {response.StatusCode}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Trending search list request failed: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        // Метод для отримання детальної інформації про монету
        public async Task GetCoinData(string id)
        {
            try
            {
                HttpResponseMessage response = await _client.GetAsync("/api/v3/coins/" + id);
                if (response.IsSuccessStatusCode)
                {
                    string responseData = await response.Content.ReadAsStringAsync();
                    CoinsModelCoinWindow deserializeData = JsonConvert.DeserializeObject<CoinsModelCoinWindow>(responseData);
                    _viewModelCoin.Update(deserializeData);
                }
                else
                {
                    MessageBox.Show($"Coin data request failed with status code: {response.StatusCode}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Coin data request failed: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
