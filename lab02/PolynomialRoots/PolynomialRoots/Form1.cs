using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolynomialRoots
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = Int32.Parse(textBox1.Text);
            b = Int32.Parse(textBox2.Text);
            c = Int32.Parse(textBox3.Text);
            double delta = Math.Pow(b, 2.0) - 4 * a * c;
            if(delta < 0)
            {
                Form resultForm = new Form2("Brak miejsc zerowych");
                resultForm.Show();
            } else if(delta == 0)
            {
                double root = (-b) / (2 * a);
                Form resultForm = new Form2("Miejsce zerowe: " + root);
                resultForm.Show();
            }
            else if(delta > 0)
            {
                double root1 = (-b - Math.Sqrt(delta)) / (2 * a);
                double root2 = (-b + Math.Sqrt(delta)) / (2 * a);
                Form resultForm = new Form2("Miejsca zerowe: " + root1 + " oraz " + root2);
                resultForm.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Text = String.Empty;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox3.Text = String.Empty;
        }
    }
}
