using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossCalendarMAUI.Data
{
    public class ContextCalendar : NotifyLive
    {
        public static int CornerRadius;
        public string sunday = "Su";
        public double index = 44;
        public double Index
        {
            get { return index; }
            set { SetProperty(ref index, value); }
        }

        public Color daysTextColor = Colors.Transparent;

        public Color DaysTextColor
        {
            get { return daysTextColor; }
            set { SetProperty(ref daysTextColor, value); }
        }

        public Color panelColor = Colors.Transparent;

        public Color PanelColor
        {
            get { return panelColor; }
            set { SetProperty(ref panelColor, value); }
        }

        public Color tintPanelColor = Colors.Transparent;

        public Color TintPanelColor
        {
            get { return tintPanelColor; }
            set { SetProperty(ref tintPanelColor, value); }
        }

        public string Sunday
        {
            get { return sunday; }
            set { SetProperty(ref sunday, value); }
        }

        public string monday = "Mo";

        public string Monday
        {
            get { return monday; }
            set { SetProperty(ref monday, value); }
        }

        public string tuesday = "Tu";

        public string Tuesday
        {
            get { return tuesday; }
            set { SetProperty(ref tuesday, value); }
        }

        public string wednesday = "We";

        public string Wednesday
        {
            get { return wednesday; }
            set { SetProperty(ref wednesday, value); }
        }

        public string thursday = "Th";

        public string Thursday
        {
            get { return thursday; }
            set { SetProperty(ref thursday, value); }
        }

        public string friday = "Th";

        public string Friday
        {
            get { return friday; }
            set { SetProperty(ref friday, value); }
        }

        public string saturday = "Sa";

        public string Saturday
        {
            get { return saturday; }
            set { SetProperty(ref saturday, value); }
        }

        public string title = "Title";

        public string Title
        {
            get { return title; }
            set { SetProperty(ref title, value); }
        }

        public Color titleTextColor = Colors.Transparent;

        public Color TitleTextColor
        {
            get { return titleTextColor; }
            set { SetProperty(ref titleTextColor, value); }
        }

        public string subtitle = "SubTitle";

        public string SubTitle
        {
            get { return subtitle; }
            set { SetProperty(ref subtitle, value); }
        }

        public Color subTitleTextColor = Colors.Transparent;

        public Color SubTitleTextColor
        {
            get { return  subTitleTextColor; }
            set { SetProperty(ref subTitleTextColor, value); }
        }

        public string periodDate = "";

        public string PeriodDate
        {
            get { return periodDate; }
            set { SetProperty(ref periodDate, value); }
        }

        public DateTime dateText = DateTime.Now;

        public DateTime DateText
        {
            get { return dateText; }
            set { SetProperty(ref dateText, value); }
        }

        public string event00Text = "";

        public string Event00Text
        {
            get { return event00Text; }
            set { SetProperty(ref event00Text, value); }
        }

        public string event01Text = "";

        public string Event01Text
        {
            get { return event01Text; }
            set { SetProperty(ref event01Text, value); }
        }

        public string event02Text = "";

        public string Event02Text
        {
            get { return event02Text; }
            set { SetProperty(ref event02Text, value); }
        }

        public string event03Text = "";

        public string Event03Text
        {
            get { return event03Text; }
            set { SetProperty(ref event03Text, value); }
        }

        public string event04Text = "";

        public string Event04Text
        {
            get { return event04Text; }
            set { SetProperty(ref event04Text, value); }
        }

        public string event05Text = "";

        public string Event05Text
        {
            get { return event05Text; }
            set { SetProperty(ref event05Text, value); }
        }

        public string event06Text = "";

        public string Event06Text
        {
            get { return event06Text; }
            set { SetProperty(ref event06Text, value); }
        }

        public string event10Text = "";

        public string Event10Text
        {
            get { return event10Text; }
            set { SetProperty(ref event10Text, value); }
        }

        public string event11Text = "";

        public string Event11Text
        {
            get { return event11Text; }
            set { SetProperty(ref event11Text, value); }
        }

        public string event12Text = "";

        public string Event12Text
        {
            get { return event12Text; }
            set { SetProperty(ref event12Text, value); }
        }

        public string event13Text = "";

        public string Event13Text
        {
            get { return event13Text; }
            set { SetProperty(ref event13Text, value); }
        }

        public string event14Text = "";

        public string Event14Text
        {
            get { return event14Text; }
            set { SetProperty(ref event14Text, value); }
        }

        public string event15Text = "";

        public string Event15Text
        {
            get { return event15Text; }
            set { SetProperty(ref event15Text, value); }
        }

        public string event16Text = "";

        public string Event16Text
        {
            get { return event16Text; }
            set { SetProperty(ref event16Text, value); }
        }

        public string event20Text = "";

        public string Event20Text
        {
            get { return event20Text; }
            set { SetProperty(ref event20Text, value); }
        }

        public string event21Text = "";

        public string Event21Text
        {
            get { return event21Text; }
            set { SetProperty(ref event21Text, value); }
        }

        public string event22Text = "";

        public string Event22Text
        {
            get { return event22Text; }
            set { SetProperty(ref event22Text, value); }
        }

        public string event23Text = "";

        public string Event23Text
        {
            get { return event23Text; }
            set { SetProperty(ref event23Text, value); }
        }

        public string event24Text = "";

        public string Event24Text
        {
            get { return event24Text; }
            set { SetProperty(ref event24Text, value); }
        }

        public string event25Text = "";

        public string Event25Text
        {
            get { return event25Text; }
            set { SetProperty(ref event25Text, value); }
        }

        public string event26Text = "";

        public string Event26Text
        {
            get { return event26Text; }
            set { SetProperty(ref event26Text, value); }
        }

        public string event30Text = "";

        public string Event30Text
        {
            get { return event30Text; }
            set { SetProperty(ref event30Text, value); }
        }

        public string event31Text = "";

        public string Event31Text
        {
            get { return event31Text; }
            set { SetProperty(ref event31Text, value); }
        }

        public string event32Text = "";

        public string Event32Text
        {
            get { return event32Text; }
            set { SetProperty(ref event32Text, value); }
        }

        public string event33Text = "";

        public string Event33Text
        {
            get { return event33Text; }
            set { SetProperty(ref event33Text, value); }
        }

        public string event34Text = "";

        public string Event34Text
        {
            get { return event34Text; }
            set { SetProperty(ref event34Text, value); }
        }

        public string event35Text = "";

        public string Event35Text
        {
            get { return event35Text; }
            set { SetProperty(ref event35Text, value); }
        }

        public string event36Text = "";

        public string Event36Text
        {
            get { return event36Text; }
            set { SetProperty(ref event36Text, value); }
        }

        public string event40Text = "";

        public string Event40Text
        {
            get { return event40Text; }
            set { SetProperty(ref event40Text, value); }
        }

        public string event41Text = "";

        public string Event41Text
        {
            get { return event41Text; }
            set { SetProperty(ref event41Text, value); }
        }

        public string event42Text = "";

        public string Event42Text
        {
            get { return event42Text; }
            set { SetProperty(ref event42Text, value); }
        }

        public string event43Text = "";

        public string Event43Text
        {
            get { return event43Text; }
            set { SetProperty(ref event43Text, value); }
        }

        public string event44Text = "";

        public string Event44Text
        {
            get { return event44Text; }
            set { SetProperty(ref event44Text, value); }
        }

        public string event45Text = "";

        public string Event45Text
        {
            get { return event45Text; }
            set { SetProperty(ref event45Text, value); }
        }

        public string event46Text = "";

        public string Event46Text
        {
            get { return event46Text; }
            set { SetProperty(ref event46Text, value); }
        }

        public Color event00BackgroundColor = Colors.Transparent;

        public Color Event00BackgroundColor
        {
            get { return event00BackgroundColor; }
            set { SetProperty(ref event00BackgroundColor, value); }
        }

        public Color event01BackgroundColor = Colors.White;

        public Color Event01BackgroundColor
        {
            get { return event01BackgroundColor; }
            set { SetProperty(ref event01BackgroundColor, value); }
        }

        public Color event02BackgroundColor = Colors.Transparent;

        public Color Event02BackgroundColor
        {
            get { return event02BackgroundColor; }
            set { SetProperty(ref event02BackgroundColor, value); }
        }

        public Color event03BackgroundColor = Colors.Transparent;

        public Color Event03BackgroundColor
        {
            get { return event03BackgroundColor; }
            set { SetProperty(ref event03BackgroundColor, value); }
        }

        public Color event04BackgroundColor = Colors.Transparent;

        public Color Event04BackgroundColor
        {
            get { return event04BackgroundColor; }
            set { SetProperty(ref event04BackgroundColor, value); }
        }

        public Color event05BackgroundColor = Colors.Transparent;

        public Color Event05BackgroundColor
        {
            get { return event05BackgroundColor; }
            set { SetProperty(ref event05BackgroundColor, value); }
        }

        public Color event06BackgroundColor = Colors.Transparent;

        public Color Event06BackgroundColor
        {
            get { return event06BackgroundColor; }
            set { SetProperty(ref event06BackgroundColor, value); }
        }

        public Color event10BackgroundColor = Colors.Transparent;

        public Color Event10BackgroundColor
        {
            get { return event10BackgroundColor; }
            set { SetProperty(ref event10BackgroundColor, value); }
        }

        public Color event11BackgroundColor = Colors.Transparent;

        public Color Event11BackgroundColor
        {
            get { return event11BackgroundColor; }
            set { SetProperty(ref event11BackgroundColor, value); }
        }

        public Color event12BackgroundColor = Colors.Transparent;

        public Color Event12BackgroundColor
        {
            get { return event12BackgroundColor; }
            set { SetProperty(ref event12BackgroundColor, value); }
        }

        public Color event13BackgroundColor = Colors.Transparent;

        public Color Event13BackgroundColor
        {
            get { return event13BackgroundColor; }
            set { SetProperty(ref event13BackgroundColor, value); }
        }

        public Color event14BackgroundColor = Colors.Transparent;

        public Color Event14BackgroundColor
        {
            get { return event14BackgroundColor; }
            set { SetProperty(ref event14BackgroundColor, value); }
        }

        public Color event15BackgroundColor = Colors.Transparent;

        public Color Event15BackgroundColor
        {
            get { return event15BackgroundColor; }
            set { SetProperty(ref event15BackgroundColor, value); }
        }

        public Color event16BackgroundColor = Colors.Transparent;

        public Color Event16BackgroundColor
        {
            get { return event16BackgroundColor; }
            set { SetProperty(ref event16BackgroundColor, value); }
        }

        public Color event20BackgroundColor = Colors.Transparent;

        public Color Event20BackgroundColor
        {
            get { return event20BackgroundColor; }
            set { SetProperty(ref event20BackgroundColor, value); }
        }

        public Color event21BackgroundColor = Colors.Transparent;

        public Color Event21BackgroundColor
        {
            get { return event21BackgroundColor; }
            set { SetProperty(ref event21BackgroundColor, value); }
        }

        public Color event22BackgroundColor = Colors.Transparent;

        public Color Event22BackgroundColor
        {
            get { return event22BackgroundColor; }
            set { SetProperty(ref event22BackgroundColor, value); }
        }

        public Color event23BackgroundColor = Colors.Transparent;

        public Color Event23BackgroundColor
        {
            get { return event23BackgroundColor; }
            set { SetProperty(ref event23BackgroundColor, value); }
        }

        public Color event24BackgroundColor = Colors.Transparent;

        public Color Event24BackgroundColor
        {
            get { return event24BackgroundColor; }
            set { SetProperty(ref event24BackgroundColor, value); }
        }

        public Color event25BackgroundColor = Colors.Transparent;

        public Color Event25BackgroundColor
        {
            get { return event25BackgroundColor; }
            set { SetProperty(ref event25BackgroundColor, value); }
        }

        public Color event26BackgroundColor = Colors.Transparent;

        public Color Event26BackgroundColor
        {
            get { return event26BackgroundColor; }
            set { SetProperty(ref event26BackgroundColor, value); }
        }

        public Color event30BackgroundColor = Colors.Transparent;

        public Color Event30BackgroundColor
        {
            get { return event30BackgroundColor; }
            set { SetProperty(ref event30BackgroundColor, value); }
        }

        public Color event31BackgroundColor = Colors.Transparent;

        public Color Event31BackgroundColor
        {
            get { return event31BackgroundColor; }
            set { SetProperty(ref event31BackgroundColor, value); }
        }

        public Color event32BackgroundColor = Colors.Transparent;

        public Color Event32BackgroundColor
        {
            get { return event32BackgroundColor; }
            set { SetProperty(ref event32BackgroundColor, value); }
        }

        public Color event33BackgroundColor = Colors.Transparent;

        public Color Event33BackgroundColor
        {
            get { return event33BackgroundColor; }
            set { SetProperty(ref event33BackgroundColor, value); }
        }

        public Color event34BackgroundColor = Colors.Transparent;

        public Color Event34BackgroundColor
        {
            get { return event34BackgroundColor; }
            set { SetProperty(ref event34BackgroundColor, value); }
        }

        public Color event35BackgroundColor = Colors.Transparent;

        public Color Event35BackgroundColor
        {
            get { return event35BackgroundColor; }
            set { SetProperty(ref event35BackgroundColor, value); }
        }

        public Color event36BackgroundColor = Colors.Transparent;

        public Color Event36BackgroundColor
        {
            get { return event36BackgroundColor; }
            set { SetProperty(ref event36BackgroundColor, value); }
        }

        public Color event40BackgroundColor = Colors.Transparent;

        public Color Event40BackgroundColor
        {
            get { return event40BackgroundColor; }
            set { SetProperty(ref event40BackgroundColor, value); }
        }

        public Color event41BackgroundColor = Colors.Transparent;

        public Color Event41BackgroundColor
        {
            get { return event41BackgroundColor; }
            set { SetProperty(ref event41BackgroundColor, value); }
        }

        public Color event42BackgroundColor = Colors.Transparent;

        public Color Event42BackgroundColor
        {
            get { return event42BackgroundColor; }
            set { SetProperty(ref event42BackgroundColor, value); }
        }

        public Color event43BackgroundColor = Colors.Transparent;

        public Color Event43BackgroundColor
        {
            get { return event43BackgroundColor; }
            set { SetProperty(ref event43BackgroundColor, value); }
        }

        public Color event44BackgroundColor = Colors.Transparent;

        public Color Event44BackgroundColor
        {
            get { return event44BackgroundColor; }
            set { SetProperty(ref event44BackgroundColor, value); }
        }

        public Color event45BackgroundColor = Colors.Transparent;

        public Color Event45BackgroundColor
        {
            get { return event45BackgroundColor; }
            set { SetProperty(ref event45BackgroundColor, value); }
        }

        public Color event46BackgroundColor = Colors.Transparent;

        public Color Event46BackgroundColor
        {
            get { return event46BackgroundColor; }
            set { SetProperty(ref event46BackgroundColor, value); }
        }

        public Color event00TextColor = Color.FromArgb("#000000");

        public Color Event00TextColor
        {
            get { return event00TextColor; }
            set { SetProperty(ref event00TextColor, value); }
        }

        public Color event01TextColor = Color.FromArgb("#000000");

        public Color Event01TextColor
        {
            get { return event01TextColor; }
            set { SetProperty(ref event01TextColor, value); }
        }

        public Color event02TextColor = Color.FromArgb("#000000");

        public Color Event02TextColor
        {
            get { return event02TextColor; }
            set { SetProperty(ref event02TextColor, value); }
        }

        public Color event03TextColor = Color.FromArgb("#000000");

        public Color Event03TextColor
        {
            get { return event03TextColor; }
            set { SetProperty(ref event03TextColor, value); }
        }

        public Color event04TextColor = Color.FromArgb("#000000");

        public Color Event04TextColor
        {
            get { return event04TextColor; }
            set { SetProperty(ref event04TextColor, value); }
        }

        public Color event05TextColor = Color.FromArgb("#000000");

        public Color Event05TextColor
        {
            get { return event05TextColor; }
            set { SetProperty(ref event05TextColor, value); }
        }

        public Color event06TextColor = Color.FromArgb("#000000");

        public Color Event06TextColor
        {
            get { return event06TextColor; }
            set { SetProperty(ref event06TextColor, value); }
        }

        public Color event10TextColor = Color.FromArgb("#000000");

        public Color Event10TextColor
        {
            get { return event10TextColor; }
            set { SetProperty(ref event10TextColor, value); }
        }

        public Color event11TextColor = Color.FromArgb("#000000");

        public Color Event11TextColor
        {
            get { return event11TextColor; }
            set { SetProperty(ref event11TextColor, value); }
        }

        public Color event12TextColor = Color.FromArgb("#000000");

        public Color Event12TextColor
        {
            get { return event12TextColor; }
            set { SetProperty(ref event12TextColor, value); }
        }

        public Color event13TextColor = Color.FromArgb("#000000");

        public Color Event13TextColor
        {
            get { return event13TextColor; }
            set { SetProperty(ref event13TextColor, value); }
        }

        public Color event14TextColor = Color.FromArgb("#000000");

        public Color Event14TextColor
        {
            get { return event14TextColor; }
            set { SetProperty(ref event14TextColor, value); }
        }

        public Color event15TextColor = Color.FromArgb("#000000");

        public Color Event15TextColor
        {
            get { return event15TextColor; }
            set { SetProperty(ref event15TextColor, value); }
        }

        public Color event16TextColor = Color.FromArgb("#000000");

        public Color Event16TextColor
        {
            get { return event16TextColor; }
            set { SetProperty(ref event16TextColor, value); }
        }

        public Color event20TextColor = Color.FromArgb("#000000");

        public Color Event20TextColor
        {
            get { return event20TextColor; }
            set { SetProperty(ref event20TextColor, value); }
        }

        public Color event21TextColor = Color.FromArgb("#000000");

        public Color Event21TextColor
        {
            get { return event21TextColor; }
            set { SetProperty(ref event21TextColor, value); }
        }

        public Color event22TextColor = Color.FromArgb("#000000");

        public Color Event22TextColor
        {
            get { return event22TextColor; }
            set { SetProperty(ref event22TextColor, value); }
        }

        public Color event23TextColor = Color.FromArgb("#000000");

        public Color Event23TextColor
        {
            get { return event23TextColor; }
            set { SetProperty(ref event23TextColor, value); }
        }

        public Color event24TextColor = Color.FromArgb("#000000");

        public Color Event24TextColor
        {
            get { return event24TextColor; }
            set { SetProperty(ref event24TextColor, value); }
        }

        public Color event25TextColor = Color.FromArgb("#000000");

        public Color Event25TextColor
        {
            get { return event25TextColor; }
            set { SetProperty(ref event25TextColor, value); }
        }

        public Color event26TextColor = Color.FromArgb("#000000");

        public Color Event26TextColor
        {
            get { return event26TextColor; }
            set { SetProperty(ref event26TextColor, value); }
        }

        public Color event30TextColor = Color.FromArgb("#000000");

        public Color Event30TextColor
        {
            get { return event30TextColor; }
            set { SetProperty(ref event30TextColor, value); }
        }

        public Color event31TextColor = Color.FromArgb("#000000");

        public Color Event31TextColor
        {
            get { return event31TextColor; }
            set { SetProperty(ref event31TextColor, value); }
        }

        public Color event32TextColor = Color.FromArgb("#000000");

        public Color Event32TextColor
        {
            get { return event32TextColor; }
            set { SetProperty(ref event32TextColor, value); }
        }

        public Color event33TextColor = Color.FromArgb("#000000");

        public Color Event33TextColor
        {
            get { return event33TextColor; }
            set { SetProperty(ref event33TextColor, value); }
        }

        public Color event34TextColor = Color.FromArgb("#000000");

        public Color Event34TextColor
        {
            get { return event34TextColor; }
            set { SetProperty(ref event34TextColor, value); }
        }

        public Color event35TextColor = Color.FromArgb("#000000");

        public Color Event35TextColor
        {
            get { return event35TextColor; }
            set { SetProperty(ref event35TextColor, value); }
        }

        public Color event36TextColor = Color.FromArgb("#000000");

        public Color Event36TextColor
        {
            get { return event36TextColor; }
            set { SetProperty(ref event36TextColor, value); }
        }

        public Color event40TextColor = Color.FromArgb("#000000");

        public Color Event40TextColor
        {
            get { return event40TextColor; }
            set { SetProperty(ref event40TextColor, value); }
        }

        public Color event41TextColor = Color.FromArgb("#000000");

        public Color Event41TextColor
        {
            get { return event41TextColor; }
            set { SetProperty(ref event41TextColor, value); }
        }

        public Color event42TextColor = Color.FromArgb("#000000");

        public Color Event42TextColor
        {
            get { return event42TextColor; }
            set { SetProperty(ref event42TextColor, value); }
        }

        public Color event43TextColor = Color.FromArgb("#000000");

        public Color Event43TextColor
        {
            get { return event43TextColor; }
            set { SetProperty(ref event43TextColor, value); }
        }

        public Color event44TextColor = Color.FromArgb("#000000");

        public Color Event44TextColor
        {
            get { return event44TextColor; }
            set { SetProperty(ref event44TextColor, value); }
        }

        public Color event45TextColor = Color.FromArgb("#000000");

        public Color Event45TextColor
        {
            get { return event45TextColor; }
            set { SetProperty(ref event45TextColor, value); }
        }

        public Color event46TextColor = Color.FromArgb("#000000");

        public Color Event46TextColor
        {
            get { return event46TextColor; }
            set { SetProperty(ref event46TextColor, value); }
        }


        public string event00AutomationId = "";

        public string Event00AutomationId
        {
            get { return event00AutomationId; }
            set { SetProperty(ref event00AutomationId, value); }
        }

        public string event01AutomationId = "";

        public string Event01AutomationId
        {
            get { return event01AutomationId; }
            set { SetProperty(ref event01AutomationId, value); }
        }

        public string event02AutomationId = "";

        public string Event02AutomationId
        {
            get { return event02AutomationId; }
            set { SetProperty(ref event02AutomationId, value); }
        }

        public string event03AutomationId = "";

        public string Event03AutomationId
        {
            get { return event03AutomationId; }
            set { SetProperty(ref event03AutomationId, value); }
        }

        public string event04AutomationId = "";

        public string Event04AutomationId
        {
            get { return event04AutomationId; }
            set { SetProperty(ref event04AutomationId, value); }
        }

        public string event05AutomationId = "";

        public string Event05AutomationId
        {
            get { return event05AutomationId; }
            set { SetProperty(ref event05AutomationId, value); }
        }

        public string event06AutomationId = "";

        public string Event06AutomationId
        {
            get { return event06AutomationId; }
            set { SetProperty(ref event06AutomationId, value); }
        }

        public string event10AutomationId = "";

        public string Event10AutomationId
        {
            get { return event10AutomationId; }
            set { SetProperty(ref event10AutomationId, value); }
        }

        public string event11AutomationId = "";

        public string Event11AutomationId
        {
            get { return event11AutomationId; }
            set { SetProperty(ref event11AutomationId, value); }
        }

        public string event12AutomationId = "";

        public string Event12AutomationId
        {
            get { return event12AutomationId; }
            set { SetProperty(ref event12AutomationId, value); }
        }

        public string event13AutomationId = "";

        public string Event13AutomationId
        {
            get { return event13AutomationId; }
            set { SetProperty(ref event13AutomationId, value); }
        }

        public string event14AutomationId = "";

        public string Event14AutomationId
        {
            get { return event14AutomationId; }
            set { SetProperty(ref event14AutomationId, value); }
        }

        public string event15AutomationId = "";

        public string Event15AutomationId
        {
            get { return event15AutomationId; }
            set { SetProperty(ref event15AutomationId, value); }
        }

        public string event16AutomationId = "";

        public string Event16AutomationId
        {
            get { return event16AutomationId; }
            set { SetProperty(ref event16AutomationId, value); }
        }

        public string event20AutomationId = "";

        public string Event20AutomationId
        {
            get { return event20AutomationId; }
            set { SetProperty(ref event20AutomationId, value); }
        }

        public string event21AutomationId = "";

        public string Event21AutomationId
        {
            get { return event21AutomationId; }
            set { SetProperty(ref event21AutomationId, value); }
        }

        public string event22AutomationId = "";

        public string Event22AutomationId
        {
            get { return event22AutomationId; }
            set { SetProperty(ref event22AutomationId, value); }
        }

        public string event23AutomationId = "";

        public string Event23AutomationId
        {
            get { return event23AutomationId; }
            set { SetProperty(ref event23AutomationId, value); }
        }

        public string event24AutomationId = "";

        public string Event24AutomationId
        {
            get { return event24AutomationId; }
            set { SetProperty(ref event24AutomationId, value); }
        }

        public string event25AutomationId = "";

        public string Event25AutomationId
        {
            get { return event25AutomationId; }
            set { SetProperty(ref event25AutomationId, value); }
        }

        public string event26AutomationId = "";

        public string Event26AutomationId
        {
            get { return event26AutomationId; }
            set { SetProperty(ref event26AutomationId, value); }
        }

        public string event30AutomationId = "";

        public string Event30AutomationId
        {
            get { return event30AutomationId; }
            set { SetProperty(ref event30AutomationId, value); }
        }

        public string event31AutomationId = "";

        public string Event31AutomationId
        {
            get { return event31AutomationId; }
            set { SetProperty(ref event31AutomationId, value); }
        }

        public string event32AutomationId = "";

        public string Event32AutomationId
        {
            get { return event32AutomationId; }
            set { SetProperty(ref event32AutomationId, value); }
        }

        public string event33AutomationId = "";

        public string Event33AutomationId
        {
            get { return event33AutomationId; }
            set { SetProperty(ref event33AutomationId, value); }
        }

        public string event34AutomationId = "";

        public string Event34AutomationId
        {
            get { return event34AutomationId; }
            set { SetProperty(ref event34AutomationId, value); }
        }

        public string event35AutomationId = "";

        public string Event35AutomationId
        {
            get { return event35AutomationId; }
            set { SetProperty(ref event35AutomationId, value); }
        }

        public string event36AutomationId = "";

        public string Event36AutomationId
        {
            get { return event36AutomationId; }
            set { SetProperty(ref event36AutomationId, value); }
        }

        public string event40AutomationId = "";

        public string Event40AutomationId
        {
            get { return event40AutomationId; }
            set { SetProperty(ref event40AutomationId, value); }
        }

        public string event41AutomationId = "";

        public string Event41AutomationId
        {
            get { return event41AutomationId; }
            set { SetProperty(ref event41AutomationId, value); }
        }

        public string event42AutomationId = "";

        public string Event42AutomationId
        {
            get { return event42AutomationId; }
            set { SetProperty(ref event42AutomationId, value); }
        }

        public string event43AutomationId = "";

        public string Event43AutomationId
        {
            get { return event43AutomationId; }
            set { SetProperty(ref event43AutomationId, value); }
        }

        public string event44AutomationId = "";

        public string Event44AutomationId
        {
            get { return event44AutomationId; }
            set { SetProperty(ref event44AutomationId, value); }
        }

        public string event45AutomationId = "";

        public string Event45AutomationId
        {
            get { return event45AutomationId; }
            set { SetProperty(ref event45AutomationId, value); }
        }

        public string event46AutomationId = "";

        public string Event46AutomationId
        {
            get { return event46AutomationId; }
            set { SetProperty(ref event46AutomationId, value); }
        }


        public int event00CornerRadius = CornerRadius;

        public int Event00CornerRadius
        {
            get { return event00CornerRadius; }
            set { SetProperty(ref event00CornerRadius, value); }
        }

        public int event01CornerRadius = CornerRadius;

        public int Event01CornerRadius
        {
            get { return event01CornerRadius; }
            set { SetProperty(ref event01CornerRadius, value); }
        }

        public int event02CornerRadius = CornerRadius;

        public int Event02CornerRadius
        {
            get { return event02CornerRadius; }
            set { SetProperty(ref event02CornerRadius, value); }
        }

        public int event03CornerRadius = CornerRadius;

        public int Event03CornerRadius
        {
            get { return event03CornerRadius; }
            set { SetProperty(ref event03CornerRadius, value); }
        }

        public int event04CornerRadius = CornerRadius;

        public int Event04CornerRadius
        {
            get { return event04CornerRadius; }
            set { SetProperty(ref event04CornerRadius, value); }
        }

        public int event05CornerRadius = CornerRadius;

        public int Event05CornerRadius
        {
            get { return event05CornerRadius; }
            set { SetProperty(ref event05CornerRadius, value); }
        }

        public int event06CornerRadius = CornerRadius;

        public int Event06CornerRadius
        {
            get { return event06CornerRadius; }
            set { SetProperty(ref event06CornerRadius, value); }
        }

        public int event10CornerRadius = CornerRadius;

        public int Event10CornerRadius
        {
            get { return event10CornerRadius; }
            set { SetProperty(ref event10CornerRadius, value); }
        }

        public int event11CornerRadius = CornerRadius;

        public int Event11CornerRadius
        {
            get { return event11CornerRadius; }
            set { SetProperty(ref event11CornerRadius, value); }
        }

        public int event12CornerRadius = CornerRadius;

        public int Event12CornerRadius
        {
            get { return event12CornerRadius; }
            set { SetProperty(ref event12CornerRadius, value); }
        }

        public int event13CornerRadius = CornerRadius;

        public int Event13CornerRadius
        {
            get { return event13CornerRadius; }
            set { SetProperty(ref event13CornerRadius, value); }
        }

        public int event14CornerRadius = CornerRadius;

        public int Event14CornerRadius
        {
            get { return event14CornerRadius; }
            set { SetProperty(ref event14CornerRadius, value); }
        }

        public int event15CornerRadius = CornerRadius;

        public int Event15CornerRadius
        {
            get { return event15CornerRadius; }
            set { SetProperty(ref event15CornerRadius, value); }
        }

        public int event16CornerRadius = CornerRadius;

        public int Event16CornerRadius
        {
            get { return event16CornerRadius; }
            set { SetProperty(ref event16CornerRadius, value); }
        }

        public int event20CornerRadius = CornerRadius;

        public int Event20CornerRadius
        {
            get { return event20CornerRadius; }
            set { SetProperty(ref event20CornerRadius, value); }
        }

        public int event21CornerRadius = CornerRadius;

        public int Event21CornerRadius
        {
            get { return event21CornerRadius; }
            set { SetProperty(ref event21CornerRadius, value); }
        }

        public int event22CornerRadius = CornerRadius;

        public int Event22CornerRadius
        {
            get { return event22CornerRadius; }
            set { SetProperty(ref event22CornerRadius, value); }
        }

        public int event23CornerRadius = CornerRadius;

        public int Event23CornerRadius
        {
            get { return event23CornerRadius; }
            set { SetProperty(ref event23CornerRadius, value); }
        }

        public int event24CornerRadius = CornerRadius;

        public int Event24CornerRadius
        {
            get { return event24CornerRadius; }
            set { SetProperty(ref event24CornerRadius, value); }
        }

        public int event25CornerRadius = CornerRadius;

        public int Event25CornerRadius
        {
            get { return event25CornerRadius; }
            set { SetProperty(ref event25CornerRadius, value); }
        }

        public int event26CornerRadius = CornerRadius;

        public int Event26CornerRadius
        {
            get { return event26CornerRadius; }
            set { SetProperty(ref event26CornerRadius, value); }
        }

        public int event30CornerRadius = CornerRadius;

        public int Event30CornerRadius
        {
            get { return event30CornerRadius; }
            set { SetProperty(ref event30CornerRadius, value); }
        }

        public int event31CornerRadius = CornerRadius;

        public int Event31CornerRadius
        {
            get { return event31CornerRadius; }
            set { SetProperty(ref event31CornerRadius, value); }
        }

        public int event32CornerRadius = CornerRadius;

        public int Event32CornerRadius
        {
            get { return event32CornerRadius; }
            set { SetProperty(ref event32CornerRadius, value); }
        }

        public int event33CornerRadius = CornerRadius;

        public int Event33CornerRadius
        {
            get { return event33CornerRadius; }
            set { SetProperty(ref event33CornerRadius, value); }
        }

        public int event34CornerRadius = CornerRadius;

        public int Event34CornerRadius
        {
            get { return event34CornerRadius; }
            set { SetProperty(ref event34CornerRadius, value); }
        }

        public int event35CornerRadius = CornerRadius;

        public int Event35CornerRadius
        {
            get { return event35CornerRadius; }
            set { SetProperty(ref event35CornerRadius, value); }
        }

        public int event36CornerRadius = CornerRadius;

        public int Event36CornerRadius
        {
            get { return event36CornerRadius; }
            set { SetProperty(ref event36CornerRadius, value); }
        }

        public int event40CornerRadius = CornerRadius;

        public int Event40CornerRadius
        {
            get { return event40CornerRadius; }
            set { SetProperty(ref event40CornerRadius, value); }
        }

        public int event41CornerRadius = CornerRadius;

        public int Event41CornerRadius
        {
            get { return event41CornerRadius; }
            set { SetProperty(ref event41CornerRadius, value); }
        }

        public int event42CornerRadius = CornerRadius;

        public int Event42CornerRadius
        {
            get { return event42CornerRadius; }
            set { SetProperty(ref event42CornerRadius, value); }
        }

        public int event43CornerRadius = CornerRadius;

        public int Event43CornerRadius
        {
            get { return event43CornerRadius; }
            set { SetProperty(ref event43CornerRadius, value); }
        }

        public int event44CornerRadius = CornerRadius;

        public int Event44CornerRadius
        {
            get { return event44CornerRadius; }
            set { SetProperty(ref event44CornerRadius, value); }
        }

        public int event45CornerRadius = CornerRadius;

        public int Event45CornerRadius
        {
            get { return event45CornerRadius; }
            set { SetProperty(ref event45CornerRadius, value); }
        }

        public int event46CornerRadius = CornerRadius;

        public int Event46CornerRadius
        {
            get { return event46CornerRadius; }
            set { SetProperty(ref event46CornerRadius, value); }
        }


        public double event00Opacity = 1;

        public double Event00Opacity
        {
            get { return event00Opacity; }
            set { SetProperty(ref event00Opacity, value); }
        }

        public double event01Opacity = 1;

        public double Event01Opacity
        {
            get { return event01Opacity; }
            set { SetProperty(ref event01Opacity, value); }
        }

        public double event02Opacity = 1;

        public double Event02Opacity
        {
            get { return event02Opacity; }
            set { SetProperty(ref event02Opacity, value); }
        }

        public double event03Opacity = 1;

        public double Event03Opacity
        {
            get { return event03Opacity; }
            set { SetProperty(ref event03Opacity, value); }
        }

        public double event04Opacity = 1;

        public double Event04Opacity
        {
            get { return event04Opacity; }
            set { SetProperty(ref event04Opacity, value); }
        }

        public double event05Opacity = 1;

        public double Event05Opacity
        {
            get { return event05Opacity; }
            set { SetProperty(ref event05Opacity, value); }
        }

        public double event06Opacity = 1;

        public double Event06Opacity
        {
            get { return event06Opacity; }
            set { SetProperty(ref event06Opacity, value); }
        }

        public double event10Opacity = 1;

        public double Event10Opacity
        {
            get { return event10Opacity; }
            set { SetProperty(ref event10Opacity, value); }
        }

        public double event11Opacity = 1;

        public double Event11Opacity
        {
            get { return event11Opacity; }
            set { SetProperty(ref event11Opacity, value); }
        }

        public double event12Opacity = 1;

        public double Event12Opacity
        {
            get { return event12Opacity; }
            set { SetProperty(ref event12Opacity, value); }
        }

        public double event13Opacity = 1;

        public double Event13Opacity
        {
            get { return event13Opacity; }
            set { SetProperty(ref event13Opacity, value); }
        }

        public double event14Opacity = 1;

        public double Event14Opacity
        {
            get { return event14Opacity; }
            set { SetProperty(ref event14Opacity, value); }
        }

        public double event15Opacity = 1;

        public double Event15Opacity
        {
            get { return event15Opacity; }
            set { SetProperty(ref event15Opacity, value); }
        }

        public double event16Opacity = 1;

        public double Event16Opacity
        {
            get { return event16Opacity; }
            set { SetProperty(ref event16Opacity, value); }
        }

        public double event20Opacity = 1;

        public double Event20Opacity
        {
            get { return event20Opacity; }
            set { SetProperty(ref event20Opacity, value); }
        }

        public double event21Opacity = 1;

        public double Event21Opacity
        {
            get { return event21Opacity; }
            set { SetProperty(ref event21Opacity, value); }
        }

        public double event22Opacity = 1;

        public double Event22Opacity
        {
            get { return event22Opacity; }
            set { SetProperty(ref event22Opacity, value); }
        }

        public double event23Opacity = 1;

        public double Event23Opacity
        {
            get { return event23Opacity; }
            set { SetProperty(ref event23Opacity, value); }
        }

        public double event24Opacity = 1;

        public double Event24Opacity
        {
            get { return event24Opacity; }
            set { SetProperty(ref event24Opacity, value); }
        }

        public double event25Opacity = 1;

        public double Event25Opacity
        {
            get { return event25Opacity; }
            set { SetProperty(ref event25Opacity, value); }
        }

        public double event26Opacity = 1;

        public double Event26Opacity
        {
            get { return event26Opacity; }
            set { SetProperty(ref event26Opacity, value); }
        }

        public double event30Opacity = 1;

        public double Event30Opacity
        {
            get { return event30Opacity; }
            set { SetProperty(ref event30Opacity, value); }
        }

        public double event31Opacity = 1;

        public double Event31Opacity
        {
            get { return event31Opacity; }
            set { SetProperty(ref event31Opacity, value); }
        }

        public double event32Opacity = 1;

        public double Event32Opacity
        {
            get { return event32Opacity; }
            set { SetProperty(ref event32Opacity, value); }
        }

        public double event33Opacity = 1;

        public double Event33Opacity
        {
            get { return event33Opacity; }
            set { SetProperty(ref event33Opacity, value); }
        }

        public double event34Opacity = 1;

        public double Event34Opacity
        {
            get { return event34Opacity; }
            set { SetProperty(ref event34Opacity, value); }
        }

        public double event35Opacity = 1;

        public double Event35Opacity
        {
            get { return event35Opacity; }
            set { SetProperty(ref event35Opacity, value); }
        }

        public double event36Opacity = 1;

        public double Event36Opacity
        {
            get { return event36Opacity; }
            set { SetProperty(ref event36Opacity, value); }
        }

        public double event40Opacity = 1;

        public double Event40Opacity
        {
            get { return event40Opacity; }
            set { SetProperty(ref event40Opacity, value); }
        }

        public double event41Opacity = 1;

        public double Event41Opacity
        {
            get { return event41Opacity; }
            set { SetProperty(ref event41Opacity, value); }
        }

        public double event42Opacity = 1;

        public double Event42Opacity
        {
            get { return event42Opacity; }
            set { SetProperty(ref event42Opacity, value); }
        }

        public double event43Opacity = 1;

        public double Event43Opacity
        {
            get { return event43Opacity; }
            set { SetProperty(ref event43Opacity, value); }
        }

        public double event44Opacity = 1;

        public double Event44Opacity
        {
            get { return event44Opacity; }
            set { SetProperty(ref event44Opacity, value); }
        }

        public double event45Opacity = 1;

        public double Event45Opacity
        {
            get { return event45Opacity; }
            set { SetProperty(ref event45Opacity, value); }
        }

        public double event46Opacity = 1;

        int radius = 0;
        public ContextCalendar()
        {

        }

        public double Event46Opacity
        {
            get { return event46Opacity; }
            set { SetProperty(ref event46Opacity, value); }
        }

    }
}
