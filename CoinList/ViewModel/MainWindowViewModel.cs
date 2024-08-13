using CoinList.View;
using CoinList.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinList.ViewModel
{
    public class MainWindowViewModel : BaseViewModel
    {
        CoinGeckoModel coinGeckoAPI;
        public MainWindowViewModel(MainWindow mainWindow)
        {
            _currentCoins = new ObservableCollection<Coin>();
            coinGeckoAPI = new CoinGeckoModel(this);
        }

        private ObservableCollection<Coin> _currentCoins;
        public ObservableCollection<Coin> CurrentCoins
        {
            get { return _currentCoins; }
            set
            {
                _currentCoins = value;
                OnPropertyChanged("CurrentCoins");
            }
        }

        public void Update(CoinsModel coins)
        {
            CurrentCoins.Clear();
            foreach (var coin in coins.Coins)
            {
                CurrentCoins.Add(coin);
            }
        }
    }
}
