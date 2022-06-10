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
    public partial class DeleteTask : Form
    {
        WeekScheduler currOpenScheduler;
        String currentTaskName;

        public DeleteTask(WeekScheduler _weekScheduler, String taskName = "")
        {
            InitializeComponent();
            // load all task names
            comboBox1.DataSource = ReaderJSON.getTaskNames();
            currOpenScheduler = _weekScheduler;

            // show picked task information
            Task pickedTask = ReaderJSON.getTaskByName(comboBox1.Text);
            lblDate.Text =  pickedTask.date;
            lblDescription.Text = pickedTask.taskDescription;
            lblPriority.Text = pickedTask.priority;
            lblStartTime.Text = pickedTask.timeStart;
            lblEndTime.Text = pickedTask.timeEnd;

            if(taskName != "")
            {
                comboBox1.Text = taskName;
                showTaskInfo(taskName);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // get task to delete
            Task toDel = ReaderJSON.getTaskByName(comboBox1.Text);
            // delete task 
            ReaderJSON.deleteTask(toDel);
            // show message
            MessageBox.Show("Task successfully deleted.");

            TableLayoutPanel tlp = currOpenScheduler.Controls.Find("tableLayoutPanel1", true).FirstOrDefault() as TableLayoutPanel;
            // update scheduler form
            tlp.Visible = false;
            // refresh WeekScheduler tasks
            currOpenScheduler.deleteButtonsFromPreviousTasks();
            currOpenScheduler.loadTasks();
            tlp.Visible = true;
            // get back to the scheduler
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            showTaskInfo(comboBox1.Text);
        }

        private void showTaskInfo(String taskName)
        {
            Task pickedTask = ReaderJSON.getTaskByName(taskName);
            lblDate.Text = pickedTask.date;
            lblDescription.Text = pickedTask.taskDescription;
            lblPriority.Text = pickedTask.priority;
            lblStartTime.Text = pickedTask.timeStart;
            lblEndTime.Text = pickedTask.timeEnd;
        }
    }
}
