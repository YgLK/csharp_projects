using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekSchedulerControl
{
    public class Task
    {
        public string taskName { get; set; }
        public string taskDescription { get; set; }
        public string date { get; set; }
        public DateInformation dateInfo { get; set; }
        public string timeStart { get; set; }
        public string timeEnd { get; set; }
        public string priority { get; set; }
        public string priorityColour { get; set; }

        public Task(string _taskName, string _taskDescription, string _date, string _timeStart, string _timeEnd, string _priority, string _priorityColour)
        {
            taskName = _taskName;
            taskDescription = _taskDescription;
            date = _date;
            timeStart = _timeStart;
            timeEnd = _timeEnd;
            priority = _priority;
            priorityColour = _priorityColour;
            dateInfo = new DateInformation(date);
        }

    }
}
