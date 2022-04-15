using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryApp
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
            Tuple<int, int> test1 = new Tuple<int, int>(3, 5);
            Tuple<int, int> test2 = new Tuple<int, int>(3, 5);
        }


        private void button1_Click(object sender, EventArgs e)
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
