using CrossCalendarMAUI.Components;
using CrossCalendarMAUI.Data;
using CrossCalendarMAUI.Services;
using Microsoft.Windows.AppNotifications;
using Microsoft.Windows.AppNotifications.Builder;
using System.ComponentModel;
using System.Runtime.Versioning;
using System.Timers;
using Windows.Media.Core;
using Windows.Media.Playback;
using Windows.Storage;
using Windows.Storage.Pickers;

namespace CrossCalendarMAUI
{
    // All the code in this file is only included on Windows.
    public class PlatformCalendar : ICalendar
    {
        private static string _NotificationText;
        private static DateTime _dateTimeSetedAlarm;

        public Calendar _calendarView { get; set; }

        public PlatformCalendar()
        {
            ContextCalendar.CornerRadius = 24;
            _calendarView = new Calendar();
        }

        public async Task OpenCalendar(ContentPage contentPage = null)
        {
            _calendarView.window = new Window
            {
                Page = new ContentPage { Content = _calendarView, BackgroundColor = Color.FromArgb("#F5F6FA") },
                MinimumHeight = 650,
                MaximumHeight = 650,
                MaximumWidth = 450,
                MinimumWidth = 450,
                Title = "Calendar",
            };
            Application.Current.OpenWindow(_calendarView.window);
        }

        public Task SetAlarm(DateTime dateTimeSetedAlarm, string NotificationText)
        {
            _dateTimeSetedAlarm = dateTimeSetedAlarm;
            _NotificationText = NotificationText ?? "Some ???";
            BackgroundWorker backgroundWorker = new();
            backgroundWorker.DoWork += BackgroundWorker_DoWork;
            backgroundWorker.RunWorkerAsync();

            return Task.CompletedTask;
        }

        private async void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            var interval = _dateTimeSetedAlarm - DateTime.Now;
            PeriodicTimer periodicTimer = new PeriodicTimer(interval);
            await periodicTimer.WaitForNextTickAsync();

            var builder = new AppNotificationBuilder()
            .AddArgument("conversationId", "9813")
            .AddText(_NotificationText);
            var notification = builder.BuildNotification();
            AppNotificationManager.Default.Show(notification);
            
            await Task.Delay(500);
            
            MediaPlayer player = new MediaPlayer
            {
                AudioCategory = MediaPlayerAudioCategory.Media
            };
            var file = await StorageFile.GetFileFromPathAsync("C:\\Windows\\Media\\Alarm01.wav");
            
            player.Source = MediaSource.CreateFromStorageFile(file);
            player.Play();
        }
    }
}
