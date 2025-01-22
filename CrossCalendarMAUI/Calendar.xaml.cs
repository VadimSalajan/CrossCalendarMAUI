using CrossCalendarMAUI.Components;
using CrossCalendarMAUI.Data;
using CrossCalendarMAUI.Services;

namespace CrossCalendarMAUI
{
    public partial class Calendar : Frame
    {
        public List<DateCalendar> listDatesCalendar;
        public DateTime SelectedDate;
        public bool ShowOnlyListDates;
        public bool CalIsInPopUp;
        public IGraphic _graphic;
        public delegate void CalendarDelegate(object sender, EventArgs e);
        public event CalendarDelegate ClickedDate;
        public Window window;
        public Calendar()
        {
            var DisplayMaxHeight = DeviceDisplay.Current.MainDisplayInfo.Height / DeviceDisplay.Current.MainDisplayInfo.Density;
            var DisplayMaxWidth = DeviceDisplay.Current.MainDisplayInfo.Width / DeviceDisplay.Current.MainDisplayInfo.Density;
            var width = DisplayMaxWidth < DisplayMaxHeight ? DisplayMaxWidth : DisplayMaxHeight;
            ContextCalendar.CornerRadius = 4;
            InitializeComponent();
            _graphic = new Graphic(Context);
            var device = DeviceInfo.Current.Idiom;
            Context.Index = device == DeviceIdiom.Desktop ? 64 : device == DeviceIdiom.Tablet ? 56 : width / 7 - 10;
            ShowOnlyListDates = false;
            SelectedDate = DateTime.Now;
            _graphic.BackGroundColorBtnDarkMode = Colors.Transparent;
            _graphic.BackGroundColorBtnLightMode = Colors.Transparent;
            _graphic.SelectedColorBtnLightMode = Color.FromArgb("#0047BB");
            _graphic.SelectedColorBtnDarkMode = Color.FromArgb("#0F7DFF");
            _graphic.ColorTextBtnLightMode = Color.FromArgb("#222222");
            _graphic.ColorTextBtnDarkMode = Color.FromArgb("#E2E7E9");
            _graphic.SelectedColorTextBtnLightMode = Color.FromArgb("#FFFFFF");
            _graphic.SelectedColorTextBtnDarkMode = Color.FromArgb("#FFFFFF");
            _graphic.UnSelectedColorTextBtnLightMode = Color.FromArgb("#6C8693");
            _graphic.UnSelectedColorTextBtnDarkMode = Color.FromArgb("#899099");
            listDatesCalendar = new List<DateCalendar>
            {
                new DateCalendar { Day = SelectedDate },
            };

            _graphic.ChangeDate(SelectedDate, listDatesCalendar);
        }

        private void ButtonPrevDate_Clicked(object sender, EventArgs e)
        {
            AddMonthBtn(-1);
        }

        private void ButtonNextDate_Clicked(object sender, EventArgs e)
        {
            AddMonthBtn(1);
        }

        private void AddMonthBtn(int Month)
        {
            SelectedDate = SelectedDate.Date.AddMonths(Month);
            Context.DateText = SelectedDate;

            _graphic.ChangeDate(SelectedDate, listDatesCalendar);
        }

        private async void ButtonSetDate_Clicked(object sender, EventArgs e)
        {
            if (ClickedDate is null) return;
            ClickedDate.Invoke(sender, e);
            var btn = sender as CustomButton;
            if(btn is null) return;
            SelectedDate = DateTime.Parse(btn.AutomationId);
            if (ShowOnlyListDates)
            {
                if (btn.BackgroundColor == _graphic.SelectedColorBtnDarkMode || btn.BackgroundColor == _graphic.SelectedColorBtnLightMode)
                {
                    _graphic.ChangeDate(SelectedDate, listDatesCalendar);
                    if (CalIsInPopUp) await Navigation.PopModalAsync();
                    else Application.Current.CloseWindow(window);
                }
            }
            else
            {
                if (listDatesCalendar.Any()) listDatesCalendar.Clear();
                listDatesCalendar.Add(new DateCalendar { Day = SelectedDate });
                _graphic.ChangeDate(SelectedDate, listDatesCalendar);
                if (CalIsInPopUp) await Navigation.PopModalAsync();
                else Application.Current.CloseWindow(window);
            }
            //Context.DateText = SelectedDate;
        }
    }
}