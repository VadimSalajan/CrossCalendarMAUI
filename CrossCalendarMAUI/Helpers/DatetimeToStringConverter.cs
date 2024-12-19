using CrossCalendarMAUI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossCalendarMAUI.Helpers
{
    public class DatetimeToStringConverter : IValueConverter
    {
        public string Format { get; set; }
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value == null)
                return string.Empty;

            var datetime = (DateTime)value;
            //put your custom formatting here
            return datetime.ToLocalTime().ToString(Format, ContextCalendar._CultureInfo);
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return value;
        }
    }
}
