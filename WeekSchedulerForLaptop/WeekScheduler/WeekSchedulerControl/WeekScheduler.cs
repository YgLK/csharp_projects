using System.Diagnostics;
using System.Globalization;

namespace WeekSchedulerControl
{
    public partial class WeekScheduler : UserControl
    {
        bool isReminderShown;

        public WeekScheduler()
        {
            InitializeComponent();
            addTimelines();
            // read data for each week
            monthCalendar1.ShowWeekNumbers = true;
            isReminderShown = false;

            initTableLayout();
            timerRemind.Start();
            //tableLayoutPanel1.Size = new Size(850, 800);

            // read tasks
            var tasks = ReaderJSON.getTasksList();
        }

        public void initTableLayout()
        {
            // create column for each timeframe
            for (int i = 0; i < 48; i++)
            {
                this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            }

            // add addButtons for each timeframe of each day 
            generateAddButtons();

            // load tasks from JSON format
            loadTasks();

            this.tableLayoutPanel1.Size = new System.Drawing.Size(850, 800);
            this.tableLayoutPanel1.TabIndex = 0;

            TableLayoutRowStyleCollection styles = tableLayoutPanel1.RowStyles;
            foreach (RowStyle style in styles)
            {
                // Set the row height to 20 pixels.
                style.SizeType = SizeType.Absolute;
                style.Height = 40;
            }
        }

        public void generateAddButtons()
        {
            // add AddButton for each day (columns)
            for (int i = 1; i < 8; i++)
            {
                // for each time interval (rows)
                for (int j = 0; j < 48; j++)
                {
                    if(tableLayoutPanel1.GetControlFromPosition(i, j) == null)
                    {
                        addVanillaAddButton(i, j);
                    }
                }
            }
        }


        public void addVanillaAddButton(int colIdx, int rowIdx)
        {
            Button taskButton = new Button();
            taskButton.Text = "";
            taskButton.Name = "addButton" + colIdx + "-" + rowIdx;
            taskButton.Click +=
                (s, e) =>
                {
                    CultureInfo ciCurr = CultureInfo.CurrentCulture;
                    AddTask addTask = new AddTask(this, date: monthCalendar1.SelectionStart.ToShortDateString(), colIdx: colIdx, rowIdx: rowIdx);
                    addTask.Show();
                };
            taskButton.Size = new System.Drawing.Size(100, 60);
            taskButton.UseVisualStyleBackColor = true;
            tableLayoutPanel1.Controls.Add(taskButton, colIdx, rowIdx);
        }


        public void deleteButton(int colIdx, int rowIdx)
        {
            var toDel = tableLayoutPanel1.GetControlFromPosition(colIdx, rowIdx);
            tableLayoutPanel1.Controls.Remove(toDel);
        }

        public void deleteButtonsFromPreviousTasks()
        {
            // add AddButton for each day (columns)
            for (int i = 1; i < 8; i++)
            {
                // for each time interval (rows)
                for (int j = 0; j < 48; j++)
                {
                    if (tableLayoutPanel1.GetControlFromPosition(i, j) != null && tableLayoutPanel1.GetControlFromPosition(i, j).Text != "")
                    {
                        tableLayoutPanel1.Controls.Remove(tableLayoutPanel1.GetControlFromPosition(i, j));
                        addVanillaAddButton(i, j);
                    }
                }
            }
        }

        public void loadTasks()
        {
            // get selected from calendar date week number
            int weekNumber = getWeekNumber(monthCalendar1.SelectionStart.Date);
            int year = monthCalendar1.SelectionStart.Year;
            // get tasks with the correct weeknumber and year selected
            List<Task> appropriateTasks = getTasksWithWeekNumber(weekNumber, year);

            // button positions in table grid
            List<List<int>> rowIdxs = new List<List<int>>();
            List<int> colIdxs = new List<int>();

            // list of buttons placed on the coords [rowIdx, colIdx]
            List<List<Button>> taskButtons = new List<List<Button>>();

            // create buttons for tasks
            foreach (var task in appropriateTasks)
            {
                List<int> rowIdxesForTask = getRowIdxs(task);
                rowIdxs.Add(rowIdxesForTask);
                colIdxs.Add(getColumnIdx(task));
                List<Button> buttonsForTask = new List<Button>();
                for(int j=0; j < rowIdxesForTask.Count; j++)
                {
                    Button taskButton = new Button();
                    taskButton.Text = task.taskName;
                    taskButton.Name = task.taskName + j;
                    taskButton.ForeColor = Color.Black;
                    // paint button on priority color

                    string colorArgb = ReaderJSON.getColorOfPriority(task.priority);
                    Debug.Write(colorArgb);
                    Color colorFromColorCode = System.Drawing.ColorTranslator.FromHtml("#" + colorArgb);
                    taskButton.BackColor = colorFromColorCode;
                    
                    taskButton.Click += 
                        (s, e) =>
                         {
                             DeleteTask deleteTask = new DeleteTask(this, task.taskName);
                             deleteTask.Show();
                         };
                    taskButton.Size = new System.Drawing.Size(100, 90);
                    buttonsForTask.Add(taskButton);
                }
                taskButtons.Add(buttonsForTask);
            }

            
            // add task buttons
            for(int i=0; i < taskButtons.Count; i++)
            {
                for(int j=0; j < taskButtons[i].Count; j++)
                {
                    int rowIdx = rowIdxs[i][j];
                    int colidx = colIdxs[i];
                    // delete default button
                    tableLayoutPanel1.Controls.Remove(tableLayoutPanel1.GetControlFromPosition(colIdxs[i], rowIdxs[i][j]));
                    // add task button in the empty place
                    tableLayoutPanel1.Controls.Add(taskButtons[i][j],colIdxs[i], rowIdxs[i][j]);
                }
            }
        }

        public List<int> getRowIdxs(Task task)
        {
            // get row idx (which means timeframes of tasks)
            string startTime = task.timeStart;
            string endTime = task.timeEnd;

            var listOfTimeFrames = new List<string>(){
                "00:00", "00:30", "01:00", "01:30", "02:00", "02:30", "03:00", "03:30", "04:00", "04:30", "05:00",
                "05:30", "06:00", "06:30", "07:00", "07:30", "08:00", "08:30", "09:00", "09:30", "10:00", "10:30",
                "11:00", "11:30", "12:00", "12:30", "13:00", "13:30", "14:00", "14:30", "15:00", "15:30", "16:00",
                "16:30", "17:00", "17:30", "18:00", "18:30", "19:00", "19:30", "20:00", "20:30", "21:00" ,"21:30" ,
                "22:00", "22:30", "23:00", "23:30"
            };

            
            int indexStart = listOfTimeFrames.FindIndex(a => a == startTime);
            int indexEnd = listOfTimeFrames.FindIndex(a => a == endTime);

            // get list of row indexes for the timeframes
            List<int> idxes = new List<int>();
            for(int i=indexStart; i < indexEnd; i++)
            {
                idxes.Add(i);
            }
            return idxes;
        }

        public int getColumnIdx(Task task)
        {
            string DayName = task.dateInfo.dayName;
            switch (DayName)
            {
                // in the json data days are moved by 1
                case "Monday":
                    return 1;
                case "Tuesday":
                    return 2;
                case "Wednesday":
                    return 3;
                case "Thursday":
                    return 4;
                case "Friday":
                    return 5;
                case "Saturday":
                    return 6;
                case "Sunday":
                    return 7;
            }
            return -1;
        }

        public void delButtonsFromTable()
        {
            List<Button> buttons = tableLayoutPanel1.Controls.OfType<Button>().ToList();
            foreach (Button btn in buttons)
            {
                tableLayoutPanel1.Controls.Remove(btn);
                btn.Dispose();
            }
        }

        public int getWeekNumber(DateTime date)
        {
            CultureInfo ciCurr = CultureInfo.CurrentCulture;
            int weekNum = ciCurr.Calendar.GetWeekOfYear(date,
                                                  CalendarWeekRule.FirstFourDayWeek,
                                                  DayOfWeek.Monday);
            return weekNum;
        }

        public List<Task> getTasksWithWeekNumber(int weekNumber, int year)
        {
            List<Task> tasks = ReaderJSON.getTasksList();
            List<Task> appropriateTasks = new List<Task>();
            foreach(var task in tasks)
            {
                if(task.dateInfo.weekNumber == weekNumber && task.dateInfo.year == year)
                {
                    appropriateTasks.Add(task);
                }
            }
            return appropriateTasks;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            tableLayoutPanel1.Visible = false;
            deleteButtonsFromPreviousTasks();
            loadTasks();
            tableLayoutPanel1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WeekScheduler currWeekScheduler = this;
            AddTask addTask = new AddTask(currWeekScheduler);
            addTask.Show();
        }

        public void addTimelines()
        {
            tableLayoutPanel1.AutoScroll = true;
            List<string> timelines = getTimelineHeaders();
            for (int i = 0; i < 48; i++)
            {
                Label label = new Label();
                label.Text = timelines[i];
                
                tableLayoutPanel1.Controls.Add(label, 0, i);
            }

        }

        public List<string> getTimelineHeaders()
        {
            int minStart = 0;
            int minEnd = 30;
            string start = "";
            string end = "";
            List<string> timeFrames = new List<string>();
            
            for(int i=0; i < 48; i++)
            {
                int hourCountStart = minStart / 60;
                int hourCountEnd = minEnd / 60;
                int minStartCount = minStart % 60;
                int minEndCount = minEnd % 60;
                
                // prepare start time format
                if (hourCountStart <= 9)
                {
                    start = "0" + hourCountStart + ":";
                } else
                {
                    start = hourCountStart + ":";
                } 
                
                if(minStartCount == 0)
                {
                    start += "00";
                } else
                {
                    start += minStartCount;
                }

                // prepare end time format
                if (hourCountEnd <= 9)
                {
                    end = "0" + hourCountEnd + ":";
                } else
                {
                    end = hourCountEnd + ":";
                }

                if (minEndCount == 0)
                {
                    end += "00";
                }
                else
                {
                    end += minEndCount;
                }
                timeFrames.Add(start + "-" + end);

                minStart += 30;
                minEnd += 30;
            }

            return timeFrames;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WeekScheduler currSchedulerForm = this;
            DeleteTask deleteTask = new DeleteTask(currSchedulerForm);
            deleteTask.Show();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timerRemind_Tick(object sender, EventArgs e)
        {
            if (!isReminderShown)
            {
                DateTime nowDate = DateTime.Now;

                Reminder reminder = new Reminder();

                Dictionary<DateTime, Task> taskByRemindTime = reminder.remindTask;
                foreach(DateTime remindDate in taskByRemindTime.Keys)
                {
                    // if less than 2 seconds to remind time
                    if (Math.Abs((nowDate - remindDate).TotalSeconds) <= 2)
                    {
                        timerRemind.Stop();
                        // show reminder
                        MessageBox.Show($"Reminder. \"{taskByRemindTime[remindDate].taskName}\" task is set to start in 15 minutes!");
                        isReminderShown = true;
                        DialogResult result = MessageBox.Show($"Reminder. \"{taskByRemindTime[remindDate].taskName}\" task is set to start in 15 minutes!", "", MessageBoxButtons.OK);
                        if (result == DialogResult.OK)
                        {
                            isReminderShown = false;
                            timerRemind.Start();
                        }
                    }

                }
            }
        }

        private void btnDataExtract_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    string path = fbd.SelectedPath + "\\" + "schedulerData.json";
                    ReaderJSON.saveTasksToFilepath(path);
                    MessageBox.Show($"Data has been saved in the location: \n {path}");
                }
                else
                {
                    MessageBox.Show($"Couldn't save the data. Try again later.");
                }
            }
        }
    }
}