# CrossCalendarMAUI

```
   FactoryCalendar factory;

   public MainPage()
   {
        InitializeComponent();
        factory.calendar._calendarView.listDatesCalendar.Add(new CrossCalendarMAUI.Data.DateCalendar { Day = DateTime.Now});
        factory.calendar._calendarView.listDatesCalendar.Add(new CrossCalendarMAUI.Data.DateCalendar { Day = DateTime.Now.AddDays(1)});
        factory.calendar._calendarView._graphic.ChangeDate(DateTime.Now, factory.calendar._calendarView.listDatesCalendar);
        factory.calendar._calendarView.ShowOnlyListDates = true;
        factory.calendar._calendarView.ClickedDate += Calendar_ClickedDate;
        factory.calendar.SetAlarm(DateTime.Now.AddSeconds(10), "Some Text ..."); // working only on Windows Version!
    }

    private void Calendar_ClickedDate(object sender, EventArgs e)
    {
        var btn = sender as CustomButton; //changed button in customButton, because are bugs style in MAC from .NET MAUI in Release Apple Store
    }

    private async void BtnOpen_Calendar(object sender, EventArgs e)
    {
        await factory.calendar.OpenCalendar(this);
    }

```
