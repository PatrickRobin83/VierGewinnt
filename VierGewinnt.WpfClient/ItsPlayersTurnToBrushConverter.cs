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
            var playerViewModel = value as IPlayerViewModel;
            if(playerViewModel == null)
                throw new ArgumentException("Vlaue is not a PlayerViewModel");
            
            if (playerViewModel.ItsPlayersTurn)
            {
                var playerColor = playerViewModel.Player.PlayerColor;
                return new SolidColorBrush(Color.FromRgb(playerColor.Red,
                                                         playerColor.Green,
                                                         playerColor.Blue));
            }

            return new SolidColorBrush(Colors.Transparent);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}
