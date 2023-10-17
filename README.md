# CrossCalendarMAUI

```
   FactoryCalendar factory;

   public MainPage()
   {
        InitializeComponent();
        factory = new FactoryCalendar();
        factory.calendar._calendarView.ClickedDate += Calendar_ClickedDate;
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
