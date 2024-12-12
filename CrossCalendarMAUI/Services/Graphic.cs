using CrossCalendarMAUI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CrossCalendarMAUI.Services
{
    public interface IGraphic
    {
        public Color TitleTextColorLightMode { get; set; }
        public Color TitleTextColorDarkMode { get; set; }
        public Color SubTitleTextColorLightMode { get; set; }
        public Color SubTitleTextColorDarkMode { get; set; }
        public Color BackGroundColorBtnLightMode { get; set; }
        public Color BackGroundColorBtnDarkMode { get; set; }
        public Color SelectedColorBtnLightMode { get; set; }
        public Color SelectedColorBtnDarkMode { get; set; }
        public Color ColorTextBtnLightMode { get; set; }
        public Color ColorTextBtnDarkMode { get; set; }
        public Color SelectedColorTextBtnLightMode { get; set; }
        public Color SelectedColorTextBtnDarkMode { get; set; }
        public Color UnSelectedColorTextBtnLightMode { get; set; }
        public Color UnSelectedColorTextBtnDarkMode { get; set; }
        public void ChangeDate(DateTime date, List<DateCalendar> dates);
        public void SetBackGroundColorBtnsRunTime();
        public void SetColorTextBtnsRunTime();
        public void SetCornerRadiusBtnsRunTime(int CornerRadius);
    }

    public class Graphic: IGraphic
    {
        private DateTime _date;
        private List<DateCalendar> _dates;
        public ContextCalendar _context;
        public Color PanelColorLightMode { get; set; }
        public Color PanelColorDarkMode { get; set; }
        public Color TintPanelColorLightMode { get; set; }
        public Color TintPanelColorDarkMode { get; set; }
        public Color DaysTextColorLightMode { get; set; }
        public Color DaysTextColorDarkMode { get; set; }
        public Color TitleTextColorLightMode { get; set; }
        public Color TitleTextColorDarkMode { get; set; }
        public Color SubTitleTextColorLightMode { get; set; }
        public Color SubTitleTextColorDarkMode { get; set; }
        public Color BackGroundColorBtnLightMode { get; set; }
        public Color BackGroundColorBtnDarkMode { get; set; }
        public Color SelectedColorBtnLightMode { get; set; }
        public Color SelectedColorBtnDarkMode { get; set; }
        public Color ColorTextBtnLightMode { get; set; }
        public Color ColorTextBtnDarkMode { get; set; }
        public Color SelectedColorTextBtnLightMode { get; set; }
        public Color SelectedColorTextBtnDarkMode { get; set; }
        public Color UnSelectedColorTextBtnLightMode { get; set; }
        public Color UnSelectedColorTextBtnDarkMode { get; set; }
        public Graphic(ContextCalendar context)
        {
            PanelColorLightMode = Color.FromArgb("#3A4959");
            PanelColorDarkMode = Color.FromArgb("#000000");
            TintPanelColorLightMode = Color.FromArgb("#FFFFFF");
            TintPanelColorDarkMode = Color.FromArgb("#FFFFFF");
            DaysTextColorLightMode = Color.FromArgb("#161B1D");
            DaysTextColorDarkMode = Color.FromArgb("#E2E7E9");
            TitleTextColorLightMode = Color.FromArgb("#161B1D");
            TitleTextColorDarkMode = Color.FromArgb("#FFFFFF");
            SubTitleTextColorLightMode = Color.FromArgb("#161B1D");
            SubTitleTextColorDarkMode = Color.FromArgb("#FFFFFF");
           _context = context;

            _context.TitleTextColor = GetColor(Mode.TitleText);
            _context.SubTitleTextColor = GetColor(Mode.SubTitleText);
            _context.DaysTextColor = GetColor(Mode.DaysText);
            _context.PanelColor = GetColor(Mode.Panel);
            _context.TintPanelColor = GetColor(Mode.TintPanel);
        }

        public void ChangeDate(DateTime date, List<DateCalendar> dates)
        {
            AppTheme appTheme = Application.Current.RequestedTheme;
            _date = date;
            _dates = dates;
            var listDays = ResultDates(date);
            var SelectedColorBtn = GetColor(Mode.SelectedBgr);
            var BackGroundColorBtn = GetColor(Mode.BgrColor);
            var ColorTextBtn = GetColor(Mode.Text);
            var SelectedColorTextBtn = GetColor(Mode.SelectedText);
            var UnSelectedColorTextBtn = GetColor(Mode.UnselectedText);
            _context.Event00Text = listDays[0].Skip(0).Take(1).First().Day.ToString();
            _context.Event01Text = listDays[1].Skip(0).Take(1).First().Day.ToString();
            _context.Event02Text = listDays[2].Skip(0).Take(1).First().Day.ToString();
            _context.Event03Text = listDays[3].Skip(0).Take(1).First().Day.ToString();
            _context.Event04Text = listDays[4].Skip(0).Take(1).First().Day.ToString();
            _context.Event05Text = listDays[5].Skip(0).Take(1).First().Day.ToString();
            _context.Event06Text = listDays[6].Skip(0).Take(1).First().Day.ToString();

            _context.Event10Text = listDays[0].Skip(1).Take(1).First().Day.ToString();
            _context.Event11Text = listDays[1].Skip(1).Take(1).First().Day.ToString();
            _context.Event12Text = listDays[2].Skip(1).Take(1).First().Day.ToString();
            _context.Event13Text = listDays[3].Skip(1).Take(1).First().Day.ToString();
            _context.Event14Text = listDays[4].Skip(1).Take(1).First().Day.ToString();
            _context.Event15Text = listDays[5].Skip(1).Take(1).First().Day.ToString();
            _context.Event16Text = listDays[6].Skip(1).Take(1).First().Day.ToString();

            _context.Event20Text = listDays[0].Skip(2).Take(1).First().Day.ToString();
            _context.Event21Text = listDays[1].Skip(2).Take(1).First().Day.ToString();
            _context.Event22Text = listDays[2].Skip(2).Take(1).First().Day.ToString();
            _context.Event23Text = listDays[3].Skip(2).Take(1).First().Day.ToString();
            _context.Event24Text = listDays[4].Skip(2).Take(1).First().Day.ToString();
            _context.Event25Text = listDays[5].Skip(2).Take(1).First().Day.ToString();
            _context.Event26Text = listDays[6].Skip(2).Take(1).First().Day.ToString();

            _context.Event30Text = listDays[0].Skip(3).Take(1).First().Day.ToString();
            _context.Event31Text = listDays[1].Skip(3).Take(1).First().Day.ToString();
            _context.Event32Text = listDays[2].Skip(3).Take(1).First().Day.ToString();
            _context.Event33Text = listDays[3].Skip(3).Take(1).First().Day.ToString();
            _context.Event34Text = listDays[4].Skip(3).Take(1).First().Day.ToString();
            _context.Event35Text = listDays[5].Skip(3).Take(1).First().Day.ToString();
            _context.Event36Text = listDays[6].Skip(3).Take(1).First().Day.ToString();

            _context.Event40Text = listDays[0].Skip(4).Take(1).First().Day.ToString();
            _context.Event41Text = listDays[1].Skip(4).Take(1).First().Day.ToString();
            _context.Event42Text = listDays[2].Skip(4).Take(1).First().Day.ToString();
            _context.Event43Text = listDays[3].Skip(4).Take(1).First().Day.ToString();
            _context.Event44Text = listDays[4].Skip(4).Take(1).First().Day.ToString();
            _context.Event45Text = listDays[5].Skip(4).Take(1).First().Day.ToString();
            _context.Event46Text = listDays[6].Skip(4).Take(1).First().Day.ToString();

            _context.Event00AutomationId = listDays[0].Skip(0).Take(1).First().ToString();
            _context.Event01AutomationId = listDays[1].Skip(0).Take(1).First().ToString();
            _context.Event02AutomationId = listDays[2].Skip(0).Take(1).First().ToString();
            _context.Event03AutomationId = listDays[3].Skip(0).Take(1).First().ToString();
            _context.Event04AutomationId = listDays[4].Skip(0).Take(1).First().ToString();
            _context.Event05AutomationId = listDays[5].Skip(0).Take(1).First().ToString();
            _context.Event06AutomationId = listDays[6].Skip(0).Take(1).First().ToString();

            _context.Event10AutomationId = listDays[0].Skip(1).Take(1).First().ToString();
            _context.Event11AutomationId = listDays[1].Skip(1).Take(1).First().ToString();
            _context.Event12AutomationId = listDays[2].Skip(1).Take(1).First().ToString();
            _context.Event13AutomationId = listDays[3].Skip(1).Take(1).First().ToString();
            _context.Event14AutomationId = listDays[4].Skip(1).Take(1).First().ToString();
            _context.Event15AutomationId = listDays[5].Skip(1).Take(1).First().ToString();
            _context.Event16AutomationId = listDays[6].Skip(1).Take(1).First().ToString();

            _context.Event20AutomationId = listDays[0].Skip(2).Take(1).First().ToString();
            _context.Event21AutomationId = listDays[1].Skip(2).Take(1).First().ToString();
            _context.Event22AutomationId = listDays[2].Skip(2).Take(1).First().ToString();
            _context.Event23AutomationId = listDays[3].Skip(2).Take(1).First().ToString();
            _context.Event24AutomationId = listDays[4].Skip(2).Take(1).First().ToString();
            _context.Event25AutomationId = listDays[5].Skip(2).Take(1).First().ToString();
            _context.Event26AutomationId = listDays[6].Skip(2).Take(1).First().ToString();

            _context.Event30AutomationId = listDays[0].Skip(3).Take(1).First().ToString();
            _context.Event31AutomationId = listDays[1].Skip(3).Take(1).First().ToString();
            _context.Event32AutomationId = listDays[2].Skip(3).Take(1).First().ToString();
            _context.Event33AutomationId = listDays[3].Skip(3).Take(1).First().ToString();
            _context.Event34AutomationId = listDays[4].Skip(3).Take(1).First().ToString();
            _context.Event35AutomationId = listDays[5].Skip(3).Take(1).First().ToString();
            _context.Event36AutomationId = listDays[6].Skip(3).Take(1).First().ToString();

            _context.Event40AutomationId = listDays[0].Skip(4).Take(1).First().ToString();
            _context.Event41AutomationId = listDays[1].Skip(4).Take(1).First().ToString();
            _context.Event42AutomationId = listDays[2].Skip(4).Take(1).First().ToString();
            _context.Event43AutomationId = listDays[3].Skip(4).Take(1).First().ToString();
            _context.Event44AutomationId = listDays[4].Skip(4).Take(1).First().ToString();
            _context.Event45AutomationId = listDays[5].Skip(4).Take(1).First().ToString();
            _context.Event46AutomationId = listDays[6].Skip(4).Take(1).First().ToString();

            _context.Event00BackgroundColor = dates.Where(x => x.Day.Date == listDays[0].Skip(0).Take(1).First().Date).Any() ? SelectedColorBtn : BackGroundColorBtn;
            _context.Event01BackgroundColor = dates.Where(x => x.Day.Date == listDays[1].Skip(0).Take(1).First().Date).Any() ? SelectedColorBtn : BackGroundColorBtn;
            _context.Event02BackgroundColor = dates.Where(x => x.Day.Date == listDays[2].Skip(0).Take(1).First().Date).Any() ? SelectedColorBtn : BackGroundColorBtn;
            _context.Event03BackgroundColor = dates.Where(x => x.Day.Date == listDays[3].Skip(0).Take(1).First().Date).Any() ? SelectedColorBtn : BackGroundColorBtn;
            _context.Event04BackgroundColor = dates.Where(x => x.Day.Date == listDays[4].Skip(0).Take(1).First().Date).Any() ? SelectedColorBtn : BackGroundColorBtn;
            _context.Event05BackgroundColor = dates.Where(x => x.Day.Date == listDays[5].Skip(0).Take(1).First().Date).Any() ? SelectedColorBtn : BackGroundColorBtn;
            _context.Event06BackgroundColor = dates.Where(x => x.Day.Date == listDays[6].Skip(0).Take(1).First().Date).Any() ? SelectedColorBtn : BackGroundColorBtn;

            _context.Event10BackgroundColor = dates.Where(x => x.Day.Date == listDays[0].Skip(1).Take(1).First().Date).Any() ? SelectedColorBtn : BackGroundColorBtn;
            _context.Event11BackgroundColor = dates.Where(x => x.Day.Date == listDays[1].Skip(1).Take(1).First().Date).Any() ? SelectedColorBtn : BackGroundColorBtn;
            _context.Event12BackgroundColor = dates.Where(x => x.Day.Date == listDays[2].Skip(1).Take(1).First().Date).Any() ? SelectedColorBtn : BackGroundColorBtn;
            _context.Event13BackgroundColor = dates.Where(x => x.Day.Date == listDays[3].Skip(1).Take(1).First().Date).Any() ? SelectedColorBtn : BackGroundColorBtn;
            _context.Event14BackgroundColor = dates.Where(x => x.Day.Date == listDays[4].Skip(1).Take(1).First().Date).Any() ? SelectedColorBtn : BackGroundColorBtn;
            _context.Event15BackgroundColor = dates.Where(x => x.Day.Date == listDays[5].Skip(1).Take(1).First().Date).Any() ? SelectedColorBtn : BackGroundColorBtn;
            _context.Event16BackgroundColor = dates.Where(x => x.Day.Date == listDays[6].Skip(1).Take(1).First().Date).Any() ? SelectedColorBtn : BackGroundColorBtn;

            _context.Event20BackgroundColor = dates.Where(x => x.Day.Date == listDays[0].Skip(2).Take(1).First().Date).Any() ? SelectedColorBtn : BackGroundColorBtn;
            _context.Event21BackgroundColor = dates.Where(x => x.Day.Date == listDays[1].Skip(2).Take(1).First().Date).Any() ? SelectedColorBtn : BackGroundColorBtn;
            _context.Event22BackgroundColor = dates.Where(x => x.Day.Date == listDays[2].Skip(2).Take(1).First().Date).Any() ? SelectedColorBtn : BackGroundColorBtn;
            _context.Event23BackgroundColor = dates.Where(x => x.Day.Date == listDays[3].Skip(2).Take(1).First().Date).Any() ? SelectedColorBtn : BackGroundColorBtn;
            _context.Event24BackgroundColor = dates.Where(x => x.Day.Date == listDays[4].Skip(2).Take(1).First().Date).Any() ? SelectedColorBtn : BackGroundColorBtn;
            _context.Event25BackgroundColor = dates.Where(x => x.Day.Date == listDays[5].Skip(2).Take(1).First().Date).Any() ? SelectedColorBtn : BackGroundColorBtn;
            _context.Event26BackgroundColor = dates.Where(x => x.Day.Date == listDays[6].Skip(2).Take(1).First().Date).Any() ? SelectedColorBtn : BackGroundColorBtn;

            _context.Event30BackgroundColor = dates.Where(x => x.Day.Date == listDays[0].Skip(3).Take(1).First().Date).Any() ? SelectedColorBtn : BackGroundColorBtn;
            _context.Event31BackgroundColor = dates.Where(x => x.Day.Date == listDays[1].Skip(3).Take(1).First().Date).Any() ? SelectedColorBtn : BackGroundColorBtn;
            _context.Event32BackgroundColor = dates.Where(x => x.Day.Date == listDays[2].Skip(3).Take(1).First().Date).Any() ? SelectedColorBtn : BackGroundColorBtn;
            _context.Event33BackgroundColor = dates.Where(x => x.Day.Date == listDays[3].Skip(3).Take(1).First().Date).Any() ? SelectedColorBtn : BackGroundColorBtn;
            _context.Event34BackgroundColor = dates.Where(x => x.Day.Date == listDays[4].Skip(3).Take(1).First().Date).Any() ? SelectedColorBtn : BackGroundColorBtn;
            _context.Event35BackgroundColor = dates.Where(x => x.Day.Date == listDays[5].Skip(3).Take(1).First().Date).Any() ? SelectedColorBtn : BackGroundColorBtn;
            _context.Event36BackgroundColor = dates.Where(x => x.Day.Date == listDays[6].Skip(3).Take(1).First().Date).Any() ? SelectedColorBtn : BackGroundColorBtn;

            _context.Event40BackgroundColor = dates.Where(x => x.Day.Date == listDays[0].Skip(4).Take(1).First().Date).Any() ? SelectedColorBtn : BackGroundColorBtn;
            _context.Event41BackgroundColor = dates.Where(x => x.Day.Date == listDays[1].Skip(4).Take(1).First().Date).Any() ? SelectedColorBtn : BackGroundColorBtn;
            _context.Event42BackgroundColor = dates.Where(x => x.Day.Date == listDays[2].Skip(4).Take(1).First().Date).Any() ? SelectedColorBtn : BackGroundColorBtn;
            _context.Event43BackgroundColor = dates.Where(x => x.Day.Date == listDays[3].Skip(4).Take(1).First().Date).Any() ? SelectedColorBtn : BackGroundColorBtn;
            _context.Event44BackgroundColor = dates.Where(x => x.Day.Date == listDays[4].Skip(4).Take(1).First().Date).Any() ? SelectedColorBtn : BackGroundColorBtn;
            _context.Event45BackgroundColor = dates.Where(x => x.Day.Date == listDays[5].Skip(4).Take(1).First().Date).Any() ? SelectedColorBtn : BackGroundColorBtn;
            _context.Event46BackgroundColor = dates.Where(x => x.Day.Date == listDays[6].Skip(4).Take(1).First().Date).Any() ? SelectedColorBtn : BackGroundColorBtn;

            _context.Event00TextColor = dates.Where(x => x.Day.Date == listDays[0].Skip(0).Take(1).First().Date).Any() ? SelectedColorTextBtn : (listDays[0].Skip(0).Take(1).First().Month == date.Month ? ColorTextBtn : UnSelectedColorTextBtn);
            _context.Event01TextColor = dates.Where(x => x.Day.Date == listDays[1].Skip(0).Take(1).First().Date).Any() ? SelectedColorTextBtn : (listDays[1].Skip(0).Take(1).First().Month == date.Month ? ColorTextBtn : UnSelectedColorTextBtn);
            _context.Event02TextColor = dates.Where(x => x.Day.Date == listDays[2].Skip(0).Take(1).First().Date).Any() ? SelectedColorTextBtn : (listDays[2].Skip(0).Take(1).First().Month == date.Month ? ColorTextBtn : UnSelectedColorTextBtn);
            _context.Event03TextColor = dates.Where(x => x.Day.Date == listDays[3].Skip(0).Take(1).First().Date).Any() ? SelectedColorTextBtn : (listDays[3].Skip(0).Take(1).First().Month == date.Month ? ColorTextBtn : UnSelectedColorTextBtn);
            _context.Event04TextColor = dates.Where(x => x.Day.Date == listDays[4].Skip(0).Take(1).First().Date).Any() ? SelectedColorTextBtn : (listDays[4].Skip(0).Take(1).First().Month == date.Month ? ColorTextBtn : UnSelectedColorTextBtn);
            _context.Event05TextColor = dates.Where(x => x.Day.Date == listDays[5].Skip(0).Take(1).First().Date).Any() ? SelectedColorTextBtn : (listDays[5].Skip(0).Take(1).First().Month == date.Month ? ColorTextBtn : UnSelectedColorTextBtn);
            _context.Event06TextColor = dates.Where(x => x.Day.Date == listDays[6].Skip(0).Take(1).First().Date).Any() ? SelectedColorTextBtn : (listDays[6].Skip(0).Take(1).First().Month == date.Month ? ColorTextBtn : UnSelectedColorTextBtn);

            _context.Event10TextColor = dates.Where(x => x.Day.Date == listDays[0].Skip(1).Take(1).First().Date).Any() ? SelectedColorTextBtn : ColorTextBtn;
            _context.Event11TextColor = dates.Where(x => x.Day.Date == listDays[1].Skip(1).Take(1).First().Date).Any() ? SelectedColorTextBtn : ColorTextBtn;
            _context.Event12TextColor = dates.Where(x => x.Day.Date == listDays[2].Skip(1).Take(1).First().Date).Any() ? SelectedColorTextBtn : ColorTextBtn;
            _context.Event13TextColor = dates.Where(x => x.Day.Date == listDays[3].Skip(1).Take(1).First().Date).Any() ? SelectedColorTextBtn : ColorTextBtn;
            _context.Event14TextColor = dates.Where(x => x.Day.Date == listDays[4].Skip(1).Take(1).First().Date).Any() ? SelectedColorTextBtn : ColorTextBtn;
            _context.Event15TextColor = dates.Where(x => x.Day.Date == listDays[5].Skip(1).Take(1).First().Date).Any() ? SelectedColorTextBtn : ColorTextBtn;
            _context.Event16TextColor = dates.Where(x => x.Day.Date == listDays[6].Skip(1).Take(1).First().Date).Any() ? SelectedColorTextBtn : ColorTextBtn;

            _context.Event20TextColor = dates.Where(x => x.Day.Date == listDays[0].Skip(2).Take(1).First().Date).Any() ? SelectedColorTextBtn : ColorTextBtn;
            _context.Event21TextColor = dates.Where(x => x.Day.Date == listDays[1].Skip(2).Take(1).First().Date).Any() ? SelectedColorTextBtn : ColorTextBtn;
            _context.Event22TextColor = dates.Where(x => x.Day.Date == listDays[2].Skip(2).Take(1).First().Date).Any() ? SelectedColorTextBtn : ColorTextBtn;
            _context.Event23TextColor = dates.Where(x => x.Day.Date == listDays[3].Skip(2).Take(1).First().Date).Any() ? SelectedColorTextBtn : ColorTextBtn;
            _context.Event24TextColor = dates.Where(x => x.Day.Date == listDays[4].Skip(2).Take(1).First().Date).Any() ? SelectedColorTextBtn : ColorTextBtn;
            _context.Event25TextColor = dates.Where(x => x.Day.Date == listDays[5].Skip(2).Take(1).First().Date).Any() ? SelectedColorTextBtn : ColorTextBtn;
            _context.Event26TextColor = dates.Where(x => x.Day.Date == listDays[6].Skip(2).Take(1).First().Date).Any() ? SelectedColorTextBtn : ColorTextBtn;

            _context.Event30TextColor = dates.Where(x => x.Day.Date == listDays[0].Skip(3).Take(1).First().Date).Any() ? SelectedColorTextBtn : ColorTextBtn;
            _context.Event31TextColor = dates.Where(x => x.Day.Date == listDays[1].Skip(3).Take(1).First().Date).Any() ? SelectedColorTextBtn : ColorTextBtn;
            _context.Event32TextColor = dates.Where(x => x.Day.Date == listDays[2].Skip(3).Take(1).First().Date).Any() ? SelectedColorTextBtn : ColorTextBtn;
            _context.Event33TextColor = dates.Where(x => x.Day.Date == listDays[3].Skip(3).Take(1).First().Date).Any() ? SelectedColorTextBtn : ColorTextBtn;
            _context.Event34TextColor = dates.Where(x => x.Day.Date == listDays[4].Skip(3).Take(1).First().Date).Any() ? SelectedColorTextBtn : ColorTextBtn;
            _context.Event35TextColor = dates.Where(x => x.Day.Date == listDays[5].Skip(3).Take(1).First().Date).Any() ? SelectedColorTextBtn : ColorTextBtn;
            _context.Event36TextColor = dates.Where(x => x.Day.Date == listDays[6].Skip(3).Take(1).First().Date).Any() ? SelectedColorTextBtn : ColorTextBtn;

            _context.Event40TextColor = dates.Where(x => x.Day.Date == listDays[0].Skip(4).Take(1).First().Date).Any() ? SelectedColorTextBtn : (listDays[0].Skip(4).Take(1).First().Month == date.Month ? ColorTextBtn : UnSelectedColorTextBtn);
            _context.Event41TextColor = dates.Where(x => x.Day.Date == listDays[1].Skip(4).Take(1).First().Date).Any() ? SelectedColorTextBtn : (listDays[1].Skip(4).Take(1).First().Month == date.Month ? ColorTextBtn : UnSelectedColorTextBtn);
            _context.Event42TextColor = dates.Where(x => x.Day.Date == listDays[2].Skip(4).Take(1).First().Date).Any() ? SelectedColorTextBtn : (listDays[2].Skip(4).Take(1).First().Month == date.Month ? ColorTextBtn : UnSelectedColorTextBtn);
            _context.Event43TextColor = dates.Where(x => x.Day.Date == listDays[3].Skip(4).Take(1).First().Date).Any() ? SelectedColorTextBtn : (listDays[3].Skip(4).Take(1).First().Month == date.Month ? ColorTextBtn : UnSelectedColorTextBtn);
            _context.Event44TextColor = dates.Where(x => x.Day.Date == listDays[4].Skip(4).Take(1).First().Date).Any() ? SelectedColorTextBtn : (listDays[4].Skip(4).Take(1).First().Month == date.Month ? ColorTextBtn : UnSelectedColorTextBtn);
            _context.Event45TextColor = dates.Where(x => x.Day.Date == listDays[5].Skip(4).Take(1).First().Date).Any() ? SelectedColorTextBtn : (listDays[5].Skip(4).Take(1).First().Month == date.Month ? ColorTextBtn : UnSelectedColorTextBtn);
            _context.Event46TextColor = dates.Where(x => x.Day.Date == listDays[6].Skip(4).Take(1).First().Date).Any() ? SelectedColorTextBtn : (listDays[6].Skip(4).Take(1).First().Month == date.Month ? ColorTextBtn : UnSelectedColorTextBtn);

            _context.Event00Opacity = dates.Where(x => x.Day.Date == listDays[0].Skip(0).Take(1).First().Date).Any() ? (listDays[0].Skip(0).Take(1).First().Month == date.Month ? 1 : 0.8) : 1;
            _context.Event01Opacity = dates.Where(x => x.Day.Date == listDays[1].Skip(0).Take(1).First().Date).Any() ? (listDays[1].Skip(0).Take(1).First().Month == date.Month ? 1 : 0.8) : 1;
            _context.Event02Opacity = dates.Where(x => x.Day.Date == listDays[2].Skip(0).Take(1).First().Date).Any() ? (listDays[2].Skip(0).Take(1).First().Month == date.Month ? 1 : 0.8) : 1;
            _context.Event03Opacity = dates.Where(x => x.Day.Date == listDays[3].Skip(0).Take(1).First().Date).Any() ? (listDays[3].Skip(0).Take(1).First().Month == date.Month ? 1 : 0.8) : 1;
            _context.Event04Opacity = dates.Where(x => x.Day.Date == listDays[4].Skip(0).Take(1).First().Date).Any() ? (listDays[4].Skip(0).Take(1).First().Month == date.Month ? 1 : 0.8) : 1;
            _context.Event05Opacity = dates.Where(x => x.Day.Date == listDays[5].Skip(0).Take(1).First().Date).Any() ? (listDays[5].Skip(0).Take(1).First().Month == date.Month ? 1 : 0.8) : 1;
            _context.Event06Opacity = dates.Where(x => x.Day.Date == listDays[6].Skip(0).Take(1).First().Date).Any() ? (listDays[6].Skip(0).Take(1).First().Month == date.Month ? 1 : 0.8) : 1;

            _context.Event40Opacity = dates.Where(x => x.Day.Date == listDays[0].Skip(4).Take(1).First().Date).Any() ? (listDays[0].Skip(4).Take(1).First().Month == date.Month ? 1 : 0.8) : 1;
            _context.Event41Opacity = dates.Where(x => x.Day.Date == listDays[1].Skip(4).Take(1).First().Date).Any() ? (listDays[1].Skip(4).Take(1).First().Month == date.Month ? 1 : 0.8) : 1;
            _context.Event42Opacity = dates.Where(x => x.Day.Date == listDays[2].Skip(4).Take(1).First().Date).Any() ? (listDays[2].Skip(4).Take(1).First().Month == date.Month ? 1 : 0.8) : 1;
            _context.Event43Opacity = dates.Where(x => x.Day.Date == listDays[3].Skip(4).Take(1).First().Date).Any() ? (listDays[3].Skip(4).Take(1).First().Month == date.Month ? 1 : 0.8) : 1;
            _context.Event44Opacity = dates.Where(x => x.Day.Date == listDays[4].Skip(4).Take(1).First().Date).Any() ? (listDays[4].Skip(4).Take(1).First().Month == date.Month ? 1 : 0.8) : 1;
            _context.Event45Opacity = dates.Where(x => x.Day.Date == listDays[5].Skip(4).Take(1).First().Date).Any() ? (listDays[5].Skip(4).Take(1).First().Month == date.Month ? 1 : 0.8) : 1;
            _context.Event46Opacity = dates.Where(x => x.Day.Date == listDays[6].Skip(4).Take(1).First().Date).Any() ? (listDays[6].Skip(4).Take(1).First().Month == date.Month ? 1 : 0.8) : 1;
          
            Application.Current.RequestedThemeChanged += Current_RequestedThemeChanged;       
        }

        private void Current_RequestedThemeChanged(object sender, AppThemeChangedEventArgs e)
        {
            ChangeDate(_date, _dates);
            _context.TitleTextColor = GetColor(Mode.TitleText);
            _context.SubTitleTextColor = GetColor(Mode.SubTitleText);
            _context.DaysTextColor = GetColor(Mode.DaysText);
            _context.PanelColor = GetColor(Mode.Panel);
            _context.TintPanelColor = GetColor(Mode.TintPanel);
        }

        public void SetBackGroundColorBtnsRunTime()
        {
            var listProprieties = _context.GetType().GetProperties().ToList();
            var colorBgr = GetColor(Mode.BgrColor);
            var selectedColorBgr = GetColor(Mode.SelectedBgr);
            object objBgr = colorBgr;
            foreach (var item in listProprieties)
            {
                if (item.Name.Contains("BackgroundColor")) 
                {
                    if (item.GetValue(_context).Equals(objBgr))
                        item.SetValue(_context, colorBgr);
                    else item.SetValue(_context, selectedColorBgr);
                }
            }
        }

        public void SetColorTextBtnsRunTime()
        {
            var listProprieties = _context.GetType().GetProperties().ToList();
            var colorText = GetColor(Mode.Text);
            var selectedColorText = GetColor(Mode.SelectedText);
            var unselectedColorText = GetColor(Mode.UnselectedText);
            object objText = colorText;
            object objselectedText = selectedColorText;
            object objunselectedText = unselectedColorText;
            foreach (var item in listProprieties)
            {
                if (item.Name.Contains("TextColor"))
                {
                    if (item.GetValue(_context).Equals(objText))
                        item.SetValue(_context, colorText);
                    if (item.GetValue(_context).Equals(objselectedText))
                        item.SetValue(_context, selectedColorText);
                    if (item.GetValue(_context).Equals(objunselectedText))
                        item.SetValue(_context, unselectedColorText);
                }
            }
        }

        public void SetCornerRadiusBtnsRunTime(int CornerRadius)
        {
            var listProprieties = _context.GetType().GetProperties().ToList();
            foreach (var item in listProprieties)
            {
                if (item.Name.Contains("CornerRadius"))
                {
                    item.SetValue(_context, CornerRadius);
                }
            }
        }

        private List<List<DateTime>> ResultDates(DateTime date)
        {
            List<List<DateTime>> listDates = new List<List<DateTime>>();

            var dates = Enumerable.Range(1, DateTime.DaysInMonth(date.Year, date.Month)).Select(n => new DateTime(date.Year, date.Month, n)).ToList();

            var sundays = (from d in dates
                           where d.DayOfWeek == DayOfWeek.Sunday
                           select d).First();

            var saturdays = (from d in dates
                             where d.DayOfWeek == DayOfWeek.Saturday
                             select d).First();

            var beginSunday = sundays.Date > saturdays.Date ? sundays.Date.AddDays(-7).Date : sundays;

            listDates.Add(CompareDates(beginSunday, 0, date));
            listDates.Add(CompareDates(beginSunday, 1, date));
            listDates.Add(CompareDates(beginSunday, 2, date));
            listDates.Add(CompareDates(beginSunday, 3, date));
            listDates.Add(CompareDates(beginSunday, 4, date));
            listDates.Add(CompareDates(beginSunday, 5, date));
            listDates.Add(CompareDates(beginSunday, 6, date));

            return listDates;
        }

        private List<DateTime> CompareDates(DateTime beginSunday, int day, DateTime currentTime)
        {
            var dates = new List<DateTime>();

            beginSunday = beginSunday.AddDays(day);
            dates.Add(beginSunday);
            dates.Add(beginSunday.AddDays(7));
            dates.Add(beginSunday.AddDays(14));
            dates.Add(beginSunday.AddDays(21));
            dates.Add(beginSunday.AddDays(28));

            return dates;
        }

        private Color GetColor(Mode mode)
        {
            var IsLight = Application.Current.RequestedTheme == AppTheme.Light;
            return mode switch
            {
                Mode.Text when IsLight => ColorTextBtnLightMode,
                Mode.Text when !IsLight => ColorTextBtnDarkMode,
                Mode.SelectedText when IsLight => SelectedColorTextBtnLightMode,
                Mode.SelectedText when !IsLight => SelectedColorTextBtnDarkMode,
                Mode.UnselectedText when IsLight => UnSelectedColorTextBtnLightMode,
                Mode.UnselectedText when !IsLight => UnSelectedColorTextBtnDarkMode,
                Mode.BgrColor when IsLight => BackGroundColorBtnLightMode,
                Mode.BgrColor when !IsLight => BackGroundColorBtnDarkMode,
                Mode.SelectedBgr when IsLight => SelectedColorBtnLightMode,
                Mode.SelectedBgr when !IsLight => SelectedColorBtnDarkMode,
                Mode.TitleText when IsLight => TitleTextColorLightMode,
                Mode.TitleText when !IsLight => TitleTextColorDarkMode,
                Mode.SubTitleText when IsLight => SubTitleTextColorLightMode,
                Mode.SubTitleText when !IsLight => SubTitleTextColorDarkMode,
                Mode.Panel when IsLight => PanelColorLightMode,
                Mode.Panel when !IsLight => PanelColorDarkMode,
                Mode.TintPanel when IsLight => TintPanelColorLightMode,
                Mode.TintPanel when !IsLight => TintPanelColorDarkMode,
                Mode.DaysText when IsLight => DaysTextColorLightMode,
                Mode.DaysText when !IsLight => DaysTextColorDarkMode,
                _ => Colors.Transparent
            };
        }
    }
}
