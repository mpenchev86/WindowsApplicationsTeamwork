namespace BeastApplication.Helpers
{
    using System;
    using Windows.UI;
    using Windows.UI.Xaml.Data;
    using Windows.UI.Xaml.Media;

    public class BoolToColorValueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if(targetType != typeof(Brush))
            {
                return null;
            }

            var isOk = (bool)value;
            if (!isOk)
            {
                return new SolidColorBrush(Colors.Purple);
            }

            return new SolidColorBrush(Colors.Green);
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
