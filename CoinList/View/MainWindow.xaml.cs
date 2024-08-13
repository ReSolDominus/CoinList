using System.Windows;
using CoinList.ViewModel;

namespace CoinList.View
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel(this);
        }

    }
}
