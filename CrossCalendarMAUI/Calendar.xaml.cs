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
            InitializeComponent();
            _graphic = new Graphic(Context);
            ShowOnlyListDates = false;
            SelectedDate = DateTime.Now;
            _graphic.BackGroundColorBtn = Colors.Transparent;
            _graphic.SelectedColorBtn = Color.FromArgb("#00A8F0");
            _graphic.ColorTextBtn = Color.FromArgb("#222222");
            _graphic.SelectedColorTextBtn = Color.FromArgb("#FFFFFF");
            _graphic.UnSelectedColorTextBtn = Color.FromArgb("#899099");
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
            var btn = sender as Button;
            if(btn is null) return;
            SelectedDate = DateTime.Parse(btn.AutomationId);
            if (ShowOnlyListDates)
            {
                if (btn.BackgroundColor == Color.FromArgb("#00A8F0"))
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
            Context.DateText = SelectedDate;
        }
    }
}