using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekSchedulerControl
{
    public class Reminder
    {
        List<Task> tasks;
        // store the time of reminder pop and associated task
        public Dictionary<DateTime, Task> remindTask;

        public Reminder()
        {
            tasks = ReaderJSON.getTasksList();
            remindTask = new Dictionary<DateTime, Task>();
            getTasksDates();
        }

        public void getTasksDates() 
        {
            // get datetime for each task starting time
            foreach(Task task in tasks)
            {

                string timeStart = task.timeStart;
                string date = task.date;
                string[] dateSplit = date.Split("/");
                string[] timeStartSplit = timeStart.Split(":");

                // date format: "22/5/2022"
                int day = Int32.Parse(dateSplit[0]);
                int month = Int32.Parse(dateSplit[1]);
                int year = Int32.Parse(dateSplit[2]);

                // time format: "12:30"
                int hour = Int32.Parse(timeStartSplit[0]);
                int minute = Int32.Parse(timeStartSplit[1]);
                // seconds doesnt't matter much in this case
                int seconds = 0;

                DateTime taskStartDate = new DateTime(
                    year, month, day, hour, minute, seconds
                    );

                // if task is to be completed the same day as app is running add to the list
                if( taskStartDate.ToShortDateString() == DateTime.Now.ToShortDateString())
                {
                    // 15 minutes before task start is set the reminder time
                    DateTime remindTime = taskStartDate.AddMinutes(-15); 
                    //DateTime remindTime = taskStartDate.AddMinutes(-12);
                    // add datetime with its task to the list
                    remindTask.Add(remindTime, task);
                }
            }
        }
    }
}
