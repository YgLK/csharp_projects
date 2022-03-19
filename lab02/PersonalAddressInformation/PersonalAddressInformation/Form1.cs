using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalAddressInformation
{
    public partial class Form1 : Form
    {

        int indexData = 0;
        DataStorage ds = Program.getPersonalData();
        public Form1()
        {
            InitializeComponent();
            indexData = 0;
            ds = Program.getPersonalData();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string surname = textBox2.Text;
            string phoneNum = textBox3.Text;
            ds.addRecord(name, surname, phoneNum);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (indexData == 0)
            {
                showData(indexData);
            }
            else if (indexData > 0)
            {
                indexData -= 1;
                showData(indexData);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (indexData == (ds.getData().Count - 1))
            {
                showData(indexData);
            }
            else if (indexData < (ds.getData().Count - 1))
            {
                indexData += 1;
                showData(indexData);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            saveData(indexData);
        }

        private void showData(int index)
        {
            textBox1.Text = (ds.getData()[index]).Name;
            textBox2.Text = (ds.getData()[index]).Surname;
            textBox3.Text = (ds.getData()[index]).PhoneNumber;
        }

        private void saveData(int index)
        {
            (ds.getData()[index]).Name = textBox1.Text;
            (ds.getData()[index]).Surname = textBox2.Text;
            (ds.getData()[index]).PhoneNumber = textBox3.Text;
        }
    }
}
