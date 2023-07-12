using CrossCalendarMAUI.Components;
using CrossCalendarMAUI.Data;
using CrossCalendarMAUI.Services;
using UIKit;

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
            _calendarView.HasShadow = false;
            _calendarView.Margin = 0;
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
            };
            _calendarView.HandlerChanged += _calendarView_HandlerChanged;
            Application.Current.OpenWindow(_calendarView.window);
        }

        private void _calendarView_HandlerChanged(object sender, EventArgs e)
        {
            var win = sender as Microsoft.Maui.Controls.Window;
            var uiWin = win.Handler.PlatformView as UIWindow;
            if (uiWin != null)
            {
                uiWin.WindowScene.Title = "Calendar";
            }
        }
    }
}