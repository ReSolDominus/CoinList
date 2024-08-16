using CoinList.Model;
using CoinList.View;
using Prism.Commands;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace CoinList.ViewModel
{
    public class MainWindowViewModel : BaseViewModel
    {
        CoinGeckoModel coinGeckoAPI;
        public MainWindowViewModel(MainWindow mainWindow)
        {
            _currentCoins = new ObservableCollection<Coin>();
            coinGeckoAPI = new CoinGeckoModel(this);
            ItemDoubleClickCommand = new DelegateCommand(this.CoinListView_MouseDoubleClick);
        }


        Coin _itemSelected;
        public Coin ItemSelected
        {
            get { return _itemSelected; }
            set
            {
                _itemSelected = value;
                OnPropertyChanged("ItemSelected");
            }
        }

        // Список монет
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
        public void Update(CoinsModelMainWindow coins)
        {
            CurrentCoins.Clear();
            foreach (var coin in coins.Coins)
            {
                CurrentCoins.Add(coin);
            }
        }

        // Подвійний клік на назву елементу списка
        public ICommand ItemDoubleClickCommand { get; private set; }

        CoinWindow window;
        void CoinListView_MouseDoubleClick()
        {
            window = new CoinWindow(ItemSelected.Item.Id);
            window.Show();
        }
    }
}
