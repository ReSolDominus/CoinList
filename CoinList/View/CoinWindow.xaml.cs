using CoinList.ViewModel;
using System;
using System.Windows;

namespace CoinList.View
{
    public partial class CoinWindow : Window
    {
        public CoinWindow(string coinID)
        {
            InitializeComponent();
            DataContext = new CoinWindowViewModel(coinID);
        }
    }
}
