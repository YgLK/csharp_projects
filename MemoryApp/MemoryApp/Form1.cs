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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Tuple<int, int> test1 = new Tuple<int, int>(3, 5);
            Tuple<int, int> test2 = new Tuple<int, int>(3, 5);
            comboBox1.Items.Add("EASY"); // 16
            comboBox1.Items.Add("MEDIUM"); // 36
            comboBox1.Items.Add("HARD"); // 64
            // test how to compare tuples
            comboBox1.Items.Add(test1.Item1 == test2.Item1 
                && test1.Item2 == test2.Item2); 
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //string selected = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);
            //MessageBox.Show(selected);
            this.Hide();
            Form2 gameForm = new Form2();
            gameForm.Show();
        }
    }
}
