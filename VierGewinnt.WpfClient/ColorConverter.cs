using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;
using Color = VierGewinnt.Core.Color;

namespace VierGewinnt.WpfClient
{
    public class ColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var color = value as Color;
            if (color == null)
                return new SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 255, 255));

            return new SolidColorBrush(System.Windows.Media.Color.FromRgb(color.Red,color.Green,color.Blue));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}
