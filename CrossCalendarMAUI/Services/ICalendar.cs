using CrossCalendarMAUI.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossCalendarMAUI.Services
{
    public interface ICalendar
    {
        public Calendar _calendarView { get; set; }
        public Task OpenCalendar(ContentPage content = null);
    }
}
