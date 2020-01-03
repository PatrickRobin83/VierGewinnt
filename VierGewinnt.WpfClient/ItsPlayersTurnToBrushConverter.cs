using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace VierGewinnt.WpfClient
{
    public class ItsPlayersTurnToBrushConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var isPlayersTurn = (bool) value;
            return isPlayersTurn ? new SolidColorBrush(Colors.Silver) : new SolidColorBrush(Colors.Transparent);
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}
