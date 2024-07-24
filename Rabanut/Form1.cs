using System;
using static Rabanut.Service.RabanutService;

namespace Rabanut
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CreateXMLIfNotExist();
        }

        private void onInsertClick(object sender, EventArgs e)
        {
            var dayWeek = DayWeekCmbx.SelectedItem;
            string dayDisplay = "";
            switch (dayWeek)
            {
                case "ראשון":
                    dayDisplay = "באחד בשבת";
                    break;
                case "שני":
                    dayDisplay = "בשני בשבת";
                    break;
                case "שלישי":
                    dayDisplay = "בשלישי בשבת";
                    break;
                case "רביעי":
                    dayDisplay = "ברביעי בשבת";
                    break;
                case "חמישי":
                    dayDisplay = "בחמישי בשבת";
                    break;
                case "ששי":
                    dayDisplay = "בששי בשבת";
                    break;
            }

            var month = MonthCmbx.SelectedItem;
            string nextMonthDisplay = "";
            switch (month)
            {
                case "תשרי":
                    nextMonthDisplay = "מרחשון";
                    break;
                case "מרחשון":
                    nextMonthDisplay = "כסלו";
                    break;
                case "כסלו":
                    nextMonthDisplay = "טבת";
                    break;
                case "טבת":
                    nextMonthDisplay = "שבט";
                    break;
                case "שבט":
                    nextMonthDisplay = "אדר";
                    break;
                case "אדר הראשון":
                    nextMonthDisplay = "אדר השני";
                    break;
                case "אדר השני":
                    nextMonthDisplay = "ניסן";
                    break;
                case "אדר":
                    nextMonthDisplay = "ניסן";
                    break;
                case "ניסן":
                    nextMonthDisplay = "אייר";
                    break;
                case "אייר":
                    nextMonthDisplay = "סיון";
                    break;
                case "סיון":
                    nextMonthDisplay = "תמוז";
                    break;
                case "תמוז":
                    nextMonthDisplay = "אב";
                    break;
                case "אב":
                    nextMonthDisplay = "אלול";
                    break;
                case "אלול":
                    nextMonthDisplay = "תשרי";
                    break;
            }

            var dayMonth = DayMonthCmbx.SelectedItem;
            string dayMonthDisplay = "";
            switch (dayMonth)
            {
                case "1":
                    dayMonthDisplay = "יום אחד לירח";
                    break;
                case "2":
                    dayMonthDisplay = "שני ימים לירח";
                    break;
                case "3":
                    dayMonthDisplay = "שלשה ימים לירח";
                    break;
                case "4":
                    dayMonthDisplay = "ארבעה ימים לירח";
                    break;
                case "6":
                    dayMonthDisplay = "ששה ימים לירח";
                    break;
                case "7":
                    dayMonthDisplay = "שבעה ימים לירח";
                    break;
                case "8":
                    dayMonthDisplay = "שמונה ימים לירח";
                    break;
                case "9":
                    dayMonthDisplay = "תשעה ימים לירח";
                    break;
                case "10":
                    dayMonthDisplay = "עשרה ימים לירח";
                    break;
                case "11":
                    dayMonthDisplay = "אחד עשר יום לירח";
                    break;
                case "12":
                    dayMonthDisplay = "שנים עשר יום לירח";
                    break;
                case "13":
                    dayMonthDisplay = "שלושה עשר יום לירח";
                    break;
                case "14":
                    dayMonthDisplay = "ארבעה עשר יום לירח";
                    break;
                case "15":
                    dayMonthDisplay = "חמישה עשר יום לירח";
                    break;
                case "16":
                    dayMonthDisplay = "ששה עשר יום לירח";
                    break;
                case "17":
                    dayMonthDisplay = "שבעה עשר יום לירח";
                    break;
                case "18":
                    dayMonthDisplay = "שמונה עשר יום לירח";
                    break;
                case "19":
                    dayMonthDisplay = "תשעה עשר יום לירח";
                    break;
                case "20":
                    dayMonthDisplay = "עשרים יום לירח";
                    break;
                case "21":
                    dayMonthDisplay = "אחד ועשרים יום לירח";
                    break;
                case "22":
                    dayMonthDisplay = "שנים ועשרים יום לירח";
                    break;
                case "23":
                    dayMonthDisplay = "שלושה ועשרים יום לירח";
                    break;
                case "24":
                    dayMonthDisplay = "ארבעה ועשרים יום לירח";
                    break;
                case "25":
                    dayMonthDisplay = "חמישה ועשרים יום לירח";
                    break;
                case "26":
                    dayMonthDisplay = "ששה ועשרים יום לירח";
                    break;
                case "27":
                    dayMonthDisplay = "שבעה ועשרים יום לירח";
                    break;
                case "28":
                    dayMonthDisplay = "שמונה ועשרים יום לירח";
                    break;
                case "29":
                    dayMonthDisplay = "תשעה ועשרים יום לירח";
                    break;
                case "30":
                    dayMonthDisplay = $"יום שלשים לחודש {MonthCmbx.SelectedItem} שהוא ראש חודש {nextMonthDisplay}";
                    break;
            }

            var year = YearCmbx.SelectedItem;
            string yearDisplay = "";
            switch (year)
            {
                case "התשפד":
                    yearDisplay = "בשנת חמשת אלפים ושבע מאות ושמונים וארבע לבריאת העולם";
                    break;
                case "התשפה":
                    yearDisplay = "בשנת חמשת אלפים ושבע מאות ושמונים וחמש לבריאת העולם";
                    break;
                case "התשפו":
                    yearDisplay = "בשנת חמשת אלפים ושבע מאות ושמונים ושש לבריאת העולם";
                    break;
                case "התשפז":
                    yearDisplay = "בשנת חמשת אלפים ושבע מאות ושמונים ושבע לבריאת העולם";
                    break;
                case "התשפח":
                    yearDisplay = "בשנת חמשת אלפים ושבע מאות ושמונים ושמונה לבריאת העולם";
                    break;
                case "התשפט":
                    yearDisplay = "בשנת חמשת אלפים ושבע מאות ושמונים ותשע לבריאת העולם";
                    break;
                case "התשצ":
                    yearDisplay = "בשנת חמשת אלפים ושבע מאות ותשעים לבריאת העולם";
                    break;
                case "התשצא":
                    yearDisplay = "בשנת חמשת אלפים ושבע מאות ותשעים ואחת לבריאת העולם";
                    break;
                case "התשצב":
                    yearDisplay = "בשנת חמשת אלפים ושבע מאות ותשעים ושתיים לבריאת העולם";
                    break;
                case "התשצג":
                    yearDisplay = "בשנת חמשת אלפים ושבע מאות ותשעים ושלש לבריאת העולם";
                    break;
            }

            var result = $"{dayDisplay} {dayMonthDisplay} {MonthCmbx.SelectedItem} {yearDisplay}";
            AddQuery(dayWeek?.ToString(), dayMonth?.ToString(), MonthCmbx.SelectedItem.ToString(), year?.ToString(), result);
        }
    }
}
