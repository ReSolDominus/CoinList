using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Data;

namespace CoinList.ViewModels.Converters
{
    public class PriceChangeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is Dictionary<string, double> dictionary && parameter is string key)
            {
                if (dictionary.TryGetValue(key, out double result))
                {
                    return result.ToString("F2") + " %"; // Форматуємо число з двома десятковими знаками
                }
            }
            return "N/A"; // Значення за замовчуванням, якщо ключ не знайдено
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
