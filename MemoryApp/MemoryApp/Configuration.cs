using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace MemoryApp
{
    public partial class Configuration : Form
    {
        public Configuration()
        {
            InitializeComponent();
            // set background of labels transparent
            label1.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;
            label3.BackColor = System.Drawing.Color.Transparent;
            label4.BackColor = System.Drawing.Color.Transparent;
            label5.BackColor = System.Drawing.Color.Transparent;
            label6.BackColor = System.Drawing.Color.Transparent;
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {

            // validate entered board size
            string[] rowColSizes;
            var regex = new Regex(@"^[0-9]+x[0-9]+$");
            try
            {
                if (regex.IsMatch(boardSizeTextBox.Text))
                {
                    rowColSizes = boardSizeTextBox.Text.Split('x');
                } else
                {
                    throw new Exception("BoardSize doesn't match correct format.");
                }
            } catch(Exception exception)
            {
                MessageBox.Show("Exception: " + exception.Message + "\n Incorrect board size format is entered.");
                return;
            }


            // validate data
            double preTime = InputValidator.validateDouble(initTimeTextBox.Text);
            int rowSize = InputValidator.validateInteger(rowColSizes[0]);
            int colSize = InputValidator.validateInteger(rowColSizes[1]);
            double cardShownTime = InputValidator.validateDouble(cardVisibilityTextBox.Text);

            // check if all provided data is correct
            if (preTime == -1 || rowSize == -1 || colSize == -1 || cardShownTime == -1)
            {
                return;
            }

            // max 12x12 board size
            if(rowSize * colSize > 100)
            {
                MessageBox.Show("Max board size can contain 100 cards (10 x 10).");
                return;
            }

            // check if number of cards in the given board size is even
            if ((Int32.Parse(rowColSizes[0]) * Int32.Parse(rowColSizes[1])) % 2 != 0){
                MessageBox.Show("Cards number must be even! -> (rows * cols) %2 == 0");
            } else
            {
                MemoryData.setData(
                    pre_time: preTime,
                    row_size: rowSize,
                    col_size: colSize,
                    card_shown_time: cardShownTime
                );

                // open game form
                Game gameForm = new Game();
                gameForm.Show();
                this.Hide();
            }

        }


    }
}
