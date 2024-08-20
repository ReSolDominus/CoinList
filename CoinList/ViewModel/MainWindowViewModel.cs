using CoinList.Model;
using CoinList.View;
using Prism.Commands;
using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;

namespace CoinList.ViewModel
{
    public class MainWindowViewModel : BaseViewModel
    {
        CoinGeckoModel сoinGeckoService; // Екземпляр для отримання даних про криптовалюту
        private DispatcherTimer _timer;  // Таймер для періодичного оновлення даних

        // Конструктор, який приймає посилання на головне вікно
        public MainWindowViewModel(MainWindow mainWindow)
        {
            _currentCoins = new ObservableCollection<Coin>();
            сoinGeckoService = new CoinGeckoModel(this);
            ItemDoubleClickCommand = new DelegateCommand(this.CoinListView_MouseDoubleClick); // Прив'язка команди до події подвійного кліку
            ThemeSwitchCommand = new DelegateCommand(this.ThemeSwitch); // Прив'язка команди зміни теми інтерфейсу
            ThemeSwitch();
            GetData();
        }

        // Метод для запуску періодичного оновлення даних
        private async void GetData()
        {
            await сoinGeckoService.TrendingSearchList(); // Отримання початкових даних
            _timer = new DispatcherTimer();
            _timer.Interval = TimeSpan.FromSeconds(10);
            _timer.Tick += async (sender, e) => await сoinGeckoService.TrendingSearchList();
            _timer.Start();
        }

        // Оновлення списку монет новими даними
        public void Update(CoinsModelMainWindow coins)
        {
            CurrentCoins.Clear();
            foreach (var coin in coins.Coins)
            {
                CurrentCoins.Add(coin);
            }
        }

        // Данні для відображення у вікні
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


        // Відкриття нового вікна через подвійний клік на назву елементу списка
        public ICommand ItemDoubleClickCommand { get; private set; }
        void CoinListView_MouseDoubleClick()
        {
            if (_itemSelected != null)
            {
                CoinWindow window = new CoinWindow(ItemSelected.Item.Id);
                window.Show();
            }
        }

        // Зміна теми інтерфейсу
        bool isDarkTheme = true;
        public ICommand ThemeSwitchCommand { get; private set; }
        void ThemeSwitch()
        {
            isDarkTheme = !isDarkTheme;
            var dictionary = new ResourceDictionary();
            if (isDarkTheme)
            {
                dictionary.Source = new Uri("View/Themes/DarkTheme.xaml", UriKind.Relative);
            }
            else
            {
                dictionary.Source = new Uri("View/Themes/LightTheme.xaml", UriKind.Relative);
            }
            Application.Current.Resources.MergedDictionaries.Clear();
            Application.Current.Resources.MergedDictionaries.Add(dictionary);
        }
    }
}
