using CoinList.Model;
using System;
using System.Windows.Threading;

namespace CoinList.ViewModel
{
    public class CoinWindowViewModel : BaseViewModel
    {
        private string coinId;                      // ID криптовалюти, для якої буде відображатися інформація
        private CoinGeckoModel сoinGeckoService;    // Екземпляр для отримання даних про криптовалюту
        private DispatcherTimer _timer;             // Таймер для періодичного оновлення даних
        private CoinsModelCoinWindow coinData;      // Модель даних для криптовалюти

        // Конструктор, який приймає ID криптовалюти, для якої буде відображатися інформація
        public CoinWindowViewModel(string coinId) 
        {
            сoinGeckoService = new CoinGeckoModel(this);
            this.coinId = coinId;
            GetData(); // Запуск методу для періодичного оновлення даних
        }

        // Метод для запуску періодичного оновлення даних
        private async void GetData()
        {
            await сoinGeckoService.GetCoinData(coinId); // Отримання початкових даних
            _timer = new DispatcherTimer();
            _timer.Interval = TimeSpan.FromSeconds(10);
            _timer.Tick += async (sender, e) => await сoinGeckoService.GetCoinData(coinId);
            _timer.Start();
        }

        // Метод для оновлення відображуваних даних криптовалюти
        public void Update(CoinsModelCoinWindow coinData)
        {
            this.coinData = coinData;

            if (coinData != null)
            {
                Name = coinData.Name;
                CurrentPrice = "Current price: " + coinData.MarketData.CurrentPrice["usd"].ToString() + "$";
                MarketCapitalization = "MarketCapitalization: " + coinData.MarketData.MarketCap["usd"].ToString() + "$";
                TotalVolume = "MarketCapitalization: " + coinData.MarketData.TotalVolume["usd"].ToString() + "$";

                PriceChangePercentage24h = "24h: " + coinData.MarketData.PriceChangePercentage24h.ToString() + "%";
                PriceChangePercentage7d  = "7d: "  + coinData.MarketData.PriceChangePercentage7d.ToString()  + "%";
                PriceChangePercentage14d = "14d: " + coinData.MarketData.PriceChangePercentage14d.ToString() + "%";
                PriceChangePercentage30d = "30d: " + coinData.MarketData.PriceChangePercentage30d.ToString() + "%";
                PriceChangePercentage1y  = "1y: "  + coinData.MarketData.PriceChangePercentage1y.ToString()  + "%";
            }
        }

        // Данні для відображення у вікні
        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                if (value != null) { }
                OnPropertyChanged("Name");
            }
        }

        private string _currentPrice;
        public string CurrentPrice
        {
            get { return _currentPrice; }
            set
            {
                _currentPrice = value;
                if (value != null) { }
                OnPropertyChanged("CurrentPrice");
            }
        }

        private string _marketCapitalization;
        public string MarketCapitalization
        {
            get { return _marketCapitalization; }
            set
            {
                _marketCapitalization = value;
                if (value != null) { }
                OnPropertyChanged("MarketCapitalization");
            }
        }

        private string _totalVolume;
        public string TotalVolume
        {
            get { return _totalVolume; }
            set
            {
                _totalVolume = value;
                if (value != null) { }
                OnPropertyChanged("TotalVolume");
            }
        }

        private string _priceChangePercentage24h;
        public string PriceChangePercentage24h
        {
            get { return _priceChangePercentage24h; }
            set
            {
                _priceChangePercentage24h = value;
                if (value != null) { }
                OnPropertyChanged("PriceChangePercentage24h");
            }
        }

        private string _priceChangePercentage7d;
        public string PriceChangePercentage7d
        {
            get { return _priceChangePercentage7d; }
            set
            {
                _priceChangePercentage7d = value;
                if (value != null) { }
                OnPropertyChanged("PriceChangePercentage7d");
            }
        }

        private string _priceChangePercentage14d;
        public string PriceChangePercentage14d
        {
            get { return _priceChangePercentage14d; }
            set
            {
                _priceChangePercentage14d = value;
                if (value != null) { }
                OnPropertyChanged("PriceChangePercentage14d");
            }
        }

        private string _priceChangePercentage30d;
        public string PriceChangePercentage30d
        {
            get { return _priceChangePercentage30d; }
            set
            {
                _priceChangePercentage30d = value;
                if (value != null) { }
                OnPropertyChanged("PriceChangePercentage30d");
            }
        }

        private string _priceChangePercentage1y;
        public string PriceChangePercentage1y
        {
            get { return _priceChangePercentage1y; }
            set
            {
                _priceChangePercentage1y = value;
                if (value != null) { }
                OnPropertyChanged("PriceChangePercentage1y");
            }
        }
    }
}
