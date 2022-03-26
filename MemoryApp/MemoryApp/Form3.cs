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
    public partial class Form3 : Form
    {
        List<string> records;

        public Form3()
        {
            InitializeComponent();
            
            
            RankingReader rr = new RankingReader();
            records = rr.getRecords();

            listBox1.DataSource = records;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //start new game
            Form1 nextGame = new Form1();
            nextGame.Show();
            this.Close();
        }
    }
}
