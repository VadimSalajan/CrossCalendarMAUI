using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossCalendarMAUI.Services
{
    public class FactoryCalendar
    {
        public ICalendar calendar;
        public FactoryCalendar()
        {
            var userSelectedCulture = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentCulture = userSelectedCulture;
            calendar = new PlatformCalendar();
        }
    }
}
