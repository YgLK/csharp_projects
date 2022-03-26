using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryApp
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] rowColSizes = boardSizeTextBox.Text.Split('x');
            // validate board size
            if((Int32.Parse(rowColSizes[0]) * Int32.Parse(rowColSizes[1])) % 2 != 0){
                MessageBox.Show("Cards number must be even! -> (rows * cols) %2 == 0");
            } else
            {
                MemoryData.setData(
                    pre_time: float.Parse(cardVisibilityTextBox.Text, CultureInfo.InvariantCulture),
                    row_size: Int32.Parse(rowColSizes[0]),
                    col_size: Int32.Parse(rowColSizes[1]),
                    card_shown_time: float.Parse(cardVisibilityTextBox.Text, CultureInfo.InvariantCulture)
                );

                // open game form
                Form2 gameForm = new Form2();
                gameForm.Show();
                this.Hide();
            }

        }


    }
}
