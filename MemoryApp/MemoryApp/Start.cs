using System;
using System.Windows.Forms;


namespace MemoryApp
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
            // set background of labels transparent
            label1.BackColor = System.Drawing.Color.Transparent;
            label3.BackColor = System.Drawing.Color.Transparent;
        }


        private void Continue_Click(object sender, EventArgs e)
        {
            // open game form
            Configuration configForm = new Configuration();
            configForm.Show();
            this.Hide();


            // save player's nickname - Bob is set as default
            if (textBox1.Text.Length != 0)
            {
                MemoryData.nickname = textBox1.Text;
            }
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
