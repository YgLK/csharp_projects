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
        public DeleteTask()
        {
            InitializeComponent();
            comboBox1.DataSource = ReaderJSON.getTaskNames();

            Task pickedTask = ReaderJSON.getTaskByName(comboBox1.Text);
            lblDate.Text =  pickedTask.date;
            lblDescription.Text = pickedTask.taskDescription;
            lblPriority.Text = pickedTask.priority;
            lblStartTime.Text = pickedTask.timeStart;
            lblEndTime.Text = pickedTask.timeEnd;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Task toDel = ReaderJSON.getTaskByName(comboBox1.Text);
            ReaderJSON.deleteTask(toDel);
            MessageBox.Show("Task successfully deleted.");
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Task pickedTask = ReaderJSON.getTaskByName(comboBox1.Text);
            lblDate.Text = pickedTask.date;
            lblDescription.Text = pickedTask.taskDescription;
            lblPriority.Text = pickedTask.priority;
            lblStartTime.Text = pickedTask.timeStart;
            lblEndTime.Text = pickedTask.timeEnd;
        }
    }
}
