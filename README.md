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
        //throw new NotImplementedException();
    }

    private async void BtnOpen_Calendar(object sender, EventArgs e)
	  {
        await factory.calendar.OpenCalendar(this);
    }

```
