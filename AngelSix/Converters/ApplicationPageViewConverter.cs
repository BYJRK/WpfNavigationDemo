using System;
using System.Globalization;
using System.Windows.Controls;
using System.Windows.Data;

namespace AngelSix.Converters
{
    public class ApplicationPageViewConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch ((ApplicationPage)value)
            {
                case ApplicationPage.Empty:
                    return new TextBlock { Text = "404 Not Found" };
                case ApplicationPage.Login:
                    return new Login();
                case ApplicationPage.Home:
                    return new Home();
                default:
                    throw new ArgumentException("Invalid value passed to ApplicationPageViewConverter");
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
