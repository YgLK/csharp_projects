using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeekSchedulerControl
{
    public partial class AddTask : Form
    {
        //public AddTask(int year = -1, int weekNum = -1, int rowIdx = -1, int colIdx = -1)\

        // not sure if i passed the correct parameter as string date
        public AddTask(string date = "", int rowIdx = -1, int colIdx = -1)
        {
            InitializeComponent();
            cbxPriority.DataSource = new List<string>()
            {
                "Important", "Casual", "Non-relevant"
            };

            List<string> hours1 = new List<string>()
            {
                "00:00", "00:30", "01:00", "01:30", "02:00", "02:30", "03:00", "03:30", "04:00", "04:30", "05:00", 
                "05:30", "06:00", "06:30", "07:00", "07:30", "08:00", "08:30", "09:00", "09:30", "10:00", "10:30", 
                "11:00", "11:30", "12:00", "12:30", "13:00", "13:30", "14:00", "14:30", "15:00", "15:30", "16:00", 
                "16:30", "17:00", "17:30", "18:00", "18:30", "19:00", "19:30", "20:00", "20:30", "21:00" ,"21:30" ,
                "22:00", "22:30", "23:00", "23:30"
            };

            List<string> hours2 = new List<string>()
            {
                "00:00", "00:30", "01:00", "01:30", "02:00", "02:30", "03:00", "03:30", "04:00", "04:30", "05:00",
                "05:30", "06:00", "06:30", "07:00", "07:30", "08:00", "08:30", "09:00", "09:30", "10:00", "10:30",
                "11:00", "11:30", "12:00", "12:30", "13:00", "13:30", "14:00", "14:30", "15:00", "15:30", "16:00",
                "16:30", "17:00", "17:30", "18:00", "18:30", "19:00", "19:30", "20:00", "20:30", "21:00" ,"21:30" ,
                "22:00", "22:30", "23:00", "23:30"
            };

            cbbStart.DataSource = hours1;
            cbbEnd.DataSource = hours2;
            if(rowIdx != -1)
            {
                cbbStart.Text = hours1[rowIdx];
                cbbEnd.Text = hours2[rowIdx + 1];
            }

            // day difference between calendar chosen date and actual task chosen day
            int dayDiff = 0;

            // get date from weekNum, year and dayName
            if (date != "")
            {
                DateTime dateTime = Convert.ToDateTime(date);
                // this dayname is redundant
                DayOfWeek calendarDay = dateTime.DayOfWeek;
                // -----
                string dayName = "";
                // ----
                // set monday by default
                DayOfWeek chosenDay = DayOfWeek.Monday;

                switch (colIdx)
                {
                    case 1:
                        dayName = "Monday";
                        chosenDay = DayOfWeek.Monday;
                        break;
                    case 2:
                        dayName = "Tuesday";
                        chosenDay = DayOfWeek.Tuesday;
                        break;
                    case 3:
                        dayName = "Wednesday";
                        chosenDay = DayOfWeek.Wednesday;
                        break;
                    case 4:
                        dayName = "Thursday";
                        chosenDay = DayOfWeek.Thursday;
                        break;
                    case 5:
                        dayName = "Friday";
                        chosenDay = DayOfWeek.Friday;
                        break;
                    case 6:
                        dayName = "Saturday";
                        chosenDay = DayOfWeek.Saturday;
                        break;
                    case 7:
                        dayName = "Sunday";
                        chosenDay = DayOfWeek.Sunday;
                        break;
                }

                dayDiff = chosenDay - calendarDay;
                dateTime = dateTime.AddDays(dayDiff);
                // set picked date on datepicker
                datePicker.Text = dateTime.ToString();
                //DateTime()

                // TODO: set date of the chosen year, weeknumber, 



                //DateTime tmpDate = new DateTime(year, 1, 1).AddDays(7 * (weekNum - 1));
                //DayOfWeek tmpDayName = tmpDate.DayOfWeek;
                //tmpDate = tmpDate.AddDays(-1);

                // set date to string
                //datePicker.Value = tmpDate;
                //datePicker.Text = tmpDate.Date.ToString();
            }

            // if properly rowIdx and colIdx is picked
            if (rowIdx != -1  && colIdx != -1)
            {
                cbbStart.Text = hours1[rowIdx];
            }
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string taskName = txtTaskName.Text;
            string taskDescription = txtTaskDescription.Text;
            string taskDate = datePicker.Text;
            string taskPriority = cbxPriority.Text;
            string taskStartTime = cbbStart.Text;
            string taskEndTime = cbbEnd.Text;
            if (taskName != "" && taskDescription != "" && taskPriority != "" && taskStartTime != "" && taskEndTime != "")
            {
                Task task = new Task(taskName, taskDescription, taskDate, taskStartTime, taskEndTime, taskPriority);
                ReaderJSON.addNewTask(task);
                MessageBox.Show("Success! You added new task to your todo list.");
                this.Hide();
            } else
            {
                MessageBox.Show("Fill all the fields before adding the task!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WeekScheduler wk = new WeekScheduler();
            this.Close();
            wk.Show();

        }
    }
}
