using System;
using System.Globalization;
using AppleMAUsIc.Model;

namespace AppleMAUsIc.Converters
{
    public class QualityTypeToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!value.GetType().Equals(typeof(Quality)))
            {
                return string.Empty;
            }
            return culture.TextInfo.ToTitleCase(culture.TextInfo.ToLower(value.ToString().Replace('_', ' ')));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

