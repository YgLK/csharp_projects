using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeekSchedulerControl
{
    public partial class AddTask : Form
    {
        // custom weekscheduler
        WeekScheduler currOpenScheduler;

        // list of all possible starting and ending time frames
        List<string> listOfTimeFrames = new List<string>(){
                    "00:00", "00:30", "01:00", "01:30", "02:00", "02:30", "03:00", "03:30", "04:00", "04:30", "05:00",
                    "05:30", "06:00", "06:30", "07:00", "07:30", "08:00", "08:30", "09:00", "09:30", "10:00", "10:30",
                    "11:00", "11:30", "12:00", "12:30", "13:00", "13:30", "14:00", "14:30", "15:00", "15:30", "16:00",
                    "16:30", "17:00", "17:30", "18:00", "18:30", "19:00", "19:30", "20:00", "20:30", "21:00" ,"21:30" ,
                    "22:00", "22:30", "23:00", "23:30" };



        public AddTask(WeekScheduler _weekScheduler, string date = "", int rowIdx = -1, int colIdx = -1)
        {

            InitializeComponent();
            currOpenScheduler = _weekScheduler;

            // hide custom priority creation
            lblNewPriority.Visible = false;
            txtNewPriority.Visible = false;
            txtNewPriority.Enabled = false;
            btnColourChoose.Visible = false;
            btnColourChoose.Enabled = false;

            // load priorities to combobox
            cbxPriority.DataSource = ReaderJSON.getPriorityColours().Keys.ToList();

            // create copies of time frames list for start and end time
            List<string> hours1 = new List<string>(listOfTimeFrames);
            List<string> hours2 = new List<string>(listOfTimeFrames);

            cbbStart.DataSource = hours1;
            cbbEnd.DataSource = hours2;

            // set start time of added task based on the row idx of clicked button
            if (rowIdx != -1)
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
                
                string dayName = "";
                // set monday by default
                DayOfWeek chosenDay = DayOfWeek.Monday;

                // get day of week based on the column idx of clicked button
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

                // calculate date of chosen day
                dayDiff = chosenDay - calendarDay;
                dateTime = dateTime.AddDays(dayDiff);
                // set picked date on datepicker
                datePicker.Text = dateTime.ToString();
            }

            // if properly rowIdx and colIdx is picked
            if (rowIdx != -1  && colIdx != -1)
            {
                cbbStart.Text = hours1[rowIdx];
            }
        }


        private bool checkIfDatesOverlaps(string date, string startTime, string endTime)
        {
            List<Task> data = ReaderJSON.getTasksList();
            List<string> startDates = new List<string>();
            List<string> endDates = new List<string>();

            // add occupied time frames to lists
            foreach (Task task in data)
            {
                if (task.date == date)
                {
                    startDates.Add(task.timeStart);
                    endDates.Add(task.timeEnd);
                }
            }

            
            // find indexes of start and end time in list of time frames
            int startTimeIdx = listOfTimeFrames.FindIndex(a => a.Contains(startTime));
            int endTimeIdx = listOfTimeFrames.FindIndex(a => a.Contains(endTime));

            for (int i=0; i < startDates.Count; i++)
            {
                // get idx of task start and end time in the list of time frames
                int taskStartTimeIdx = listOfTimeFrames.FindIndex(a => a.Contains(startDates[i]));
                int taskEndTimeIdx = listOfTimeFrames.FindIndex(a => a.Contains(endDates[i]));

                // Condition of time frames overlapping:
                //[x1, x2] and [y1, y2]
                //if (x1 <= y2 && y1 <= x2)
                
                // if dates overlaps
                if (startTimeIdx < taskEndTimeIdx && endTimeIdx > taskStartTimeIdx)
                {
                    return true;
                }
            };
            return false;

        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // get provided task data
            string taskName = txtTaskName.Text;
            string taskDescription = txtTaskDescription.Text;
            string taskDate = datePicker.Text;
            string taskStartTime = cbbStart.Text;
            string taskEndTime = cbbEnd.Text;
            string taskPriority = cbxPriority.Text;
            // init colour variable
            string taskPriorityColour = ""; 
            // get custom priority information
            if (checkBoxCustomPriority.Checked)
            {
                // get custom priority name
                taskPriority = txtNewPriority.Text;
                // check if priority doenst exist yet in the dataset
                if (ReaderJSON.getPriorityColours().ContainsKey(taskPriority))
                {
                    // get colour of existing priority
                    taskPriorityColour = ReaderJSON.getColorOfPriority(taskPriority);
                } else
                {
                    // get colour from colour dialog
                    taskPriorityColour = (btnColourChoose.BackColor.ToArgb() & 0x00FFFFFF).ToString("X6");
                    Debug.WriteLine(taskPriorityColour);
                }
            } else
            {
                // get color of chosen priority
                taskPriorityColour = ReaderJSON.getColorOfPriority(taskPriority);
            }


            // if all data is provided
            if (taskName != "" && taskDescription != "" && taskPriority != "" && taskStartTime != "" && taskEndTime != "")
            {
                // validate chosen task start and end time frames
                int startIdx = listOfTimeFrames.FindIndex(a => a.Contains(taskStartTime));
                int endIdx = listOfTimeFrames.FindIndex(a => a.Contains(taskEndTime));
                if (startIdx >= endIdx)
                {
                    MessageBox.Show("Incorrect timeframes were chosen. Try again.");
                    return;
                }
                Task task = new Task(taskName, taskDescription, taskDate, taskStartTime, taskEndTime, taskPriority, taskPriorityColour);


                // if dates overlaps show message
                bool isDatesOverlapping = checkIfDatesOverlaps(task.date, task.timeStart, task.timeEnd);
                if (!isDatesOverlapping)
                {
                    // add task
                    ReaderJSON.addNewTask(task);
                    // show message
                    MessageBox.Show("Success! You added new task to your todo list.");
                    // update scheduler by showing added tasks
                    TableLayoutPanel tlp = currOpenScheduler.Controls.Find("tableLayoutPanel1", true).FirstOrDefault() as TableLayoutPanel;
                    tlp.Visible = false;
                    currOpenScheduler.deleteButtonsFromPreviousTasks();
                    currOpenScheduler.loadTasks();
                    tlp.Visible = true;
                    this.Hide();
                } else
                {
                    MessageBox.Show("Already added tasks timelines overlaps with the chosen one! Try again.");
                }
            } else
            {
                MessageBox.Show("Fill all the fields before adding the task!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxCustomPriority.Checked == true)
            {
                // show custom priority creation tools
                lblNewPriority.Visible = true;
                txtNewPriority.Visible = true;
                txtNewPriority.Enabled = true;
                btnColourChoose.Visible = true;
                btnColourChoose.Enabled = true;

                cbxPriority.Enabled = false;
            } else
            {
                // hide custom priority creation tools
                lblNewPriority.Visible = false;
                txtNewPriority.Visible = false;
                txtNewPriority.Enabled = false;
                btnColourChoose.Visible = false;
                btnColourChoose.Enabled = false;

                cbxPriority.Enabled = true;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // choose custom colour of new priority
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Color color = colorDialog1.Color;
                // convert colour to string
                string colorCode = (colorDialog1.Color.ToArgb() & 0x00FFFFFF).ToString("X6");
                btnColourChoose.Text = colorCode;
                // convert string to colour
                Color colorFromColorCode = System.Drawing.ColorTranslator.FromHtml("#" + colorCode);
                //Color.FromArgb(Convert.ToInt32(colorCode, 16));
                btnColourChoose.BackColor = colorFromColorCode;
                // print color
                Debug.WriteLine((btnColourChoose.BackColor.ToArgb() & 0x00FFFFFF).ToString("X6"));
            }
        }
    }
}
