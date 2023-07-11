using CrossCalendarMAUI.Components;
using CrossCalendarMAUI.Data;
using CrossCalendarMAUI.Services;

namespace CrossCalendarMAUI
{
    // All the code in this file is only included on Mac Catalyst.
    public class PlatformCalendar: ICalendar
    {
        public Calendar _calendarView { get; set; }

        public PlatformCalendar()
        {
            ContextCalendar.CornerRadius = 24;
            _calendarView = new Calendar();
        }

        public async Task OpenCalendar(ContentPage contentPage = null)
        {
            await Task.Delay(500);
            _calendarView.window = new Window
            {
                Page = new ContentPage { Content = _calendarView, BackgroundColor = Color.FromArgb("#F5F6FA") },
                MaximumHeight = 600,
                MinimumHeight = 600,
                MaximumWidth = 440,
                MinimumWidth = 440,
                Title = "Calendar",
            };
            Application.Current.OpenWindow(_calendarView.window);
        }
    }
}