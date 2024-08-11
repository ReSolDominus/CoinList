using System.Windows;
using CoinList.Model;

namespace CoinList.View
{
    public partial class MainWindow : Window
    {
        CoinGeckoModel geckoModel = new CoinGeckoModel();
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
