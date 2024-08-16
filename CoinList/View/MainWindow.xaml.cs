using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using CoinList.ViewModel;

namespace CoinList.View
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel(this);
            SwitchTheme(false);
        }

        private void SwitchTheme(bool isDarkTheme)
        {
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
