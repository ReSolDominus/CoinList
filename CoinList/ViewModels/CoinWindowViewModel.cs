using CoinList.Model;
using Prism.Commands;
using System;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Threading;

namespace CoinList.ViewModels
{
    public class CoinWindowViewModel : BaseViewModel
    {
        private string _coinId;                      // ID криптовалюти, для якої буде відображатися інформація
        private CoinGeckoModel _сoinGeckoService;    // Екземпляр для отримання даних про криптовалюту
        private DispatcherTimer _timer;              // Таймер для періодичного оновлення даних
        private CoinDTO _coinData;                   // Модель даних для криптовалюти

        // Конструктор, який приймає ID криптовалюти, для якої буде відображатися інформація
        public CoinWindowViewModel(string coinId) 
        {
            _сoinGeckoService = new CoinGeckoModel(this);
            this._coinId = coinId;
            WindowLoadedCommand = new DelegateCommand(this.WindowLoaded);
        }

        // Метод для запуску періодичного оновлення даних
        private async Task GetData()
        {
            await _сoinGeckoService.GetCoinData(_coinId); // Отримання початкових даних
            _timer = new DispatcherTimer();
            _timer.Interval = TimeSpan.FromSeconds(10);
            _timer.Tick += async (sender, e) => await _сoinGeckoService.GetCoinData(_coinId);
            _timer.Start();
        }

        // Метод для оновлення відображуваних даних криптовалюти
        public void Update(CoinDTO coinData)
        {
            this._coinData = coinData;

            if (coinData != null)
            {
                Name = coinData.Name;
                CurrentPrice = "Current price: " + coinData.MarketData.CurrentPrice["usd"].ToString() + "$";
                MarketCapitalization = "MarketCapitalization: " + coinData.MarketData.MarketCap["usd"].ToString() + "$";
                TotalVolume = "MarketCapitalization: " + coinData.MarketData.TotalVolume["usd"].ToString() + "$";

                PriceChangePercentage24Hours = "24h: " + coinData.MarketData.PriceChangePercentage24Hours.ToString() + "%";
                PriceChangePercentage7Days  = "7d: "  + coinData.MarketData.PriceChangePercentage7Days.ToString()  + "%";
                PriceChangePercentage14Days = "14d: " + coinData.MarketData.PriceChangePercentage14Days.ToString() + "%";
                PriceChangePercentage30Days = "30d: " + coinData.MarketData.PriceChangePercentage30Days.ToString() + "%";
                PriceChangePercentage1Year  = "1y: "  + coinData.MarketData.PriceChangePercentage1Year.ToString()  + "%";
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

        private string _priceChangePercentage24Hours;
        public string PriceChangePercentage24Hours
        {
            get { return _priceChangePercentage24Hours; }
            set
            {
                _priceChangePercentage24Hours = value;
                if (value != null) { }
                OnPropertyChanged("PriceChangePercentage24Hours");
            }
        }

        private string _priceChangePercentage7Days;
        public string PriceChangePercentage7Days
        {
            get { return _priceChangePercentage7Days; }
            set
            {
                _priceChangePercentage7Days = value;
                if (value != null) { }
                OnPropertyChanged("PriceChangePercentage7Days");
            }
        }

        private string _priceChangePercentage14Days;
        public string PriceChangePercentage14Days
        {
            get { return _priceChangePercentage14Days; }
            set
            {
                _priceChangePercentage14Days = value;
                if (value != null) { }
                OnPropertyChanged("PriceChangePercentage14Days");
            }
        }

        private string _priceChangePercentage30Days;
        public string PriceChangePercentage30Days
        {
            get { return _priceChangePercentage30Days; }
            set
            {
                _priceChangePercentage30Days = value;
                if (value != null) { }
                OnPropertyChanged("PriceChangePercentage30Days");
            }
        }

        private string _priceChangePercentage1Year;
        public string PriceChangePercentage1Year
        {
            get { return _priceChangePercentage1Year; }
            set
            {
                _priceChangePercentage1Year = value;
                if (value != null) { }
                OnPropertyChanged("PriceChangePercentage1Year");
            }
        }

        // Запуск методу для періодичного оновлення даних під час завантаження вікна
        public ICommand WindowLoadedCommand { get; private set; }
        private void WindowLoaded()
        {
            _ = GetData();
        }
    }
}
