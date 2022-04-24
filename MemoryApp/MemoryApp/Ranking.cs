using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace MemoryApp
{
    public partial class Ranking : Form
    {
        List<string> records;

        public Ranking()
        {
            InitializeComponent();
            
            
            RankingReader rr = new RankingReader();
            records = rr.getRecords();

            listBox1.DataSource = records;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //start new game
            Start nextGame = new Start();
            nextGame.Show();
            this.Close();
        }
    }
}
