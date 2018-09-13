using System;
using System.Globalization;
using Xamarin.Forms;

namespace Airlex
{
    public class textcolor_length : IValueConverter
    {


        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string valuestring)
            {
                if (valuestring.Length > 4)
                {
                    return Color.Red;
                    
                }
                else 
                {
                    return Color.Black;
                }
            }
            else
            {
                return Color.Default;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
