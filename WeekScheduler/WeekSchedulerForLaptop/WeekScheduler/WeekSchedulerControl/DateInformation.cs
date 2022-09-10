using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekSchedulerControl
{
    public class DateInformation
    {
        public string dateString { get; set; }
        public DateTime date { get; set; }
        public string dayName { get; set; }
        public int weekNumber { get; set; }
        public int year { get; set; }


        public DateInformation(string _dateString)
        {
            dateString = _dateString;
            date = Convert.ToDateTime(_dateString);
            dayName = date.DayOfWeek.ToString();

            DateTimeFormatInfo dfi = DateTimeFormatInfo.CurrentInfo;
            Calendar cal = dfi.Calendar;
            weekNumber = cal.GetWeekOfYear(date, dfi.CalendarWeekRule,
                                          dfi.FirstDayOfWeek);
            year = date.Year;
        }
    }
}
