using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media;

namespace BeastApplication.Helpers
{
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
                return new SolidColorBrush(Colors.Green);
            }

            return new SolidColorBrush(Colors.Purple);
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
