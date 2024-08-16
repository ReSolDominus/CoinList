using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoinList.Model;
using CoinList.View;
using Prism.Commands;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Windows.Threading;
using System.Threading;

namespace CoinList.ViewModel
{
    public class CoinWindowViewModel : BaseViewModel
    {
        public CoinWindowViewModel(string coinID) 
        {
            coinGeckoAPI = new CoinGeckoModel(this);
            this.coinID = coinID;
            coinGeckoAPI.GetCoinData(coinID, this);
            GetData();
        }

        private CoinGeckoModel coinGeckoAPI;

        private DispatcherTimer _timer;

        private string coinID;

        async void GetData()
        {
            _timer = new DispatcherTimer();
            _timer.Interval = TimeSpan.FromSeconds(10);
            _timer.Tick += async (sender, e) => await coinGeckoAPI.GetCoinData(coinID, this);
            _timer.Start();
        }

        string _name;
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


        CoinsModelCoinWindow coinData;
        public void Update(CoinsModelCoinWindow coinData)
        {
            this.coinData = coinData;

            if (coinData != null)
            {
                Name = coinData.Name;
            }
        }


    }
}
