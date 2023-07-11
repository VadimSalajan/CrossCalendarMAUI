using CrossCalendarMAUI.Components;
using CrossCalendarMAUI.Data;
using CrossCalendarMAUI.Services;
using System.Runtime.Versioning;

namespace CrossCalendarMAUI
{
    // All the code in this file is only included on Android.
    public class PlatformCalendar : ICalendar
    {
        public PopUpCalendar PopUp { get; set; }
        public Calendar _calendarView { get; set; }

        public PlatformCalendar()
        {
            ContextCalendar.CornerRadius = 22;
            PopUp = new PopUpCalendar();
            _calendarView = PopUp.calendar;
        }

        public async Task OpenCalendar(ContentPage content)
        {
            await PopUp.ShowCalendar(content);
        }
    }
}
