namespace WeekSchedulerControl
{
    public partial class WeekScheduler : UserControl
    {
        public WeekScheduler()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddTask addTask = new AddTask();
            addTask.Show();
        }

        private void WeekScheduler_Load(object sender, EventArgs e)
        {

        }
    }
}