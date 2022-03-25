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
    public partial class Form2 : Form
    {
        
        // list of strings placed on the reverse of the card
        List<string> cardsValues = new List<string>() {"flow", "directory", "breast", "palace",
            "reptile", "gene", "ambiguous", "compromise", "assume",
            "corpse", "stun", "criticism", "kidnap", "argument",
            "horror", "bottle", "dare", "stable", "door", "chip",
            "freight", "chest", "fiction", "torch", "bland", "pedestrian",
            "possession", "detective", "stall", "broadcast", "violation", "biscuit"
        };
        
        
        
        
        // defualt mode 16 cards
        int cardsCount = 16;
        // time of the card being shown after clicking on it
        int milisecCardShown = 400;
        int gameTimeInSec = 0;
        // each index in arrays corresponds to the x, y coordinates on the grid
        Tuple<Tuple<int>> pickedCards;
        //Dictionary<int, string> cardsPairs;
        Dictionary<int, int> cardsPairs;
        // array with strings corresponding to each card
        Dictionary<int, string> cardsStringValues;



        public Form2()
        {
            InitializeComponent();
            cardsPairs = new Dictionary<int, int>();
            cardsStringValues = new Dictionary<int, string>();
            // initialize components attributes
            createCards();
            initializeCardValues();
            label3.Text = "00:00";
            label4.Text = "0";
            timer1.Enabled = true;
        }

        private void initializeCardValues()
        {
            // generate 8 pairs of indexes (8*2 indexes included)
            //generateIndexPairs();
            generateIndexPairs2();
            // generate card value for each pair
            generateCardValues();
            int i = 0;
        }


        // generate cards pairs by picking random index of another card for each card
        private void generateIndexPairs() 
        {
            // list of cards indexes
            List<int> indexesFirstCard = Enumerable.Range(0, cardsCount).ToList();
            // shuffle the indexes of the second card in pair in order to get mixed pairs
            List<int> indexesSecondCard = new List<int>();
            // idx of card which is in pair with itself 
            int wrongPairCardIdx = 0;
            // shuffle the cards to make pairs
            while (true){
                // shuffle the indexes of the second card in pair in order to get mixed pairs
                indexesSecondCard = indexesFirstCard.OrderBy(a => Guid.NewGuid()).ToList();
                for(int i=0; i<cardsCount; i++)
                {
                    // quit the for loop if second card equals first card
                    if(indexesSecondCard[i] == indexesFirstCard[i])
                    {
                        // pair with itself occurred
                        wrongPairCardIdx = i;
                        break;
                    }
                }
                // if second card the same as first card reshuffle the second card indexes list 
                if (indexesSecondCard[wrongPairCardIdx] == indexesFirstCard[wrongPairCardIdx])
                {
                    // continue to another iteration in order to reshuffle indexSecondCard list
                    continue;
                }
                // move out of the loop if shuffled successfully
                break;
            }

            // add indices to the dictionary
            for(int i=0; i<cardsCount; i++)
            {
                // if duplicate move on
                if (!(cardsPairs.Keys.Contains(indexesFirstCard[i]) || cardsPairs.Keys.Contains(indexesSecondCard[i])))
                {
                    cardsPairs.Add(indexesFirstCard[i], indexesSecondCard[i]);
                    cardsPairs.Add(indexesSecondCard[i], indexesFirstCard[i]);
                }
            }
        }

        private void generateIndexPairs2()
        {
            // list of cards indexes
            List<int> cardsIdxes = Enumerable.Range(0, cardsCount).ToList();
            // shuffle the indexes
            cardsIdxes = cardsIdxes.OrderBy(a => Guid.NewGuid()).ToList();
            // list of pairs
            List<Tuple<int, int>> cardPairs = new List<Tuple<int, int>>();
            
            // shuffle the cards to make pairs until no cards are left
            while (cardsIdxes.Count != 0)
            {
                // get last element of shuffled list 
                int firstCardIdx = cardsIdxes[cardsIdxes.Count - 1];
                // remove the taken element
                cardsIdxes.RemoveAt(cardsIdxes.Count - 1);
                // get last element of the edited shuffled list
                int secondCardIdx = cardsIdxes[cardsIdxes.Count - 1];
                // remove the taken element
                cardsIdxes.RemoveAt(cardsIdxes.Count - 1);


                // add pairs to the dict
                cardsPairs.Add(firstCardIdx, secondCardIdx);
                cardsPairs.Add(secondCardIdx, firstCardIdx);
            }
        }

        public void generateCardValues()
        {
            // generate 16 random words form cardsValues
            int pairCount = cardsCount / 2;
            List<string> cardValues = cardsValues.OrderBy(arg => Guid.NewGuid()).Take(pairCount).ToList();

            int i = 0;
            // add value of each card into the dictionary
            foreach (KeyValuePair<int, int> kvp in cardsPairs)
            {
                if (!cardsStringValues.Keys.Contains(kvp.Key))
                {
                    cardsStringValues.Add(kvp.Key, cardValues[i]);
                    cardsStringValues.Add(kvp.Value, cardValues[i]);
                    i++;
                }
            }
        }

        public void createCards()
        {
            var rowCount = 4;
            var columnCount = 4;

            this.tableLayoutPanel1.ColumnCount = columnCount;
            this.tableLayoutPanel1.RowCount = rowCount;

            this.tableLayoutPanel1.ColumnStyles.Clear();
            this.tableLayoutPanel1.RowStyles.Clear();

            for (int i = 0; i < columnCount; i++)
            {
                this.tableLayoutPanel1.ColumnStyles.Add(
                    new System.Windows.Forms.ColumnStyle(
                        System.Windows.Forms.SizeType.Percent, 100 / columnCount)
                    );
            }
            for (int i = 0; i < rowCount; i++)
            {
                this.tableLayoutPanel1.RowStyles.Add(
                    new System.Windows.Forms.RowStyle(
                        System.Windows.Forms.SizeType.Percent, 100 / rowCount)
                    );
            }

            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    var button = new Button();
                    button.Text = string.Format("{0} {1}", i, j);
                    // button id will be its name - name can be parsed with " " separator to get x, y indexes 
                    button.Name = string.Format("{0} {1}", i, j);
                    button.Click += new EventHandler(button_Click);
                    button.Dock = DockStyle.Fill;
                    this.tableLayoutPanel1.Controls.Add(button, j, i);
                }
            }
        }

        protected void button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            // identify which button was clicked and perform necessary actions
            button.Text = "card_value";
            int[] cords = button.Name.Split().Select(Int32.Parse).ToArray<int>();
            // position in the array: 
            //pickedCards.Add(new Tuple<int, int>(cords[0], cords[1]));
            HideCardValue(button, milisecCardShown);
        }

        public async Task HideCardValue(Button button, int time)
        {
            await Task.Delay(time);
            button.Text = button.Name;
            //pickedCards.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            gameTimeInSec += 1;
            // extract min:sec time format
            int minPast = gameTimeInSec / 60;
            int secPast = gameTimeInSec % 60;
            string minPastStr =  minPast.ToString();
            string secPastStr = secPast.ToString();

            if(minPast < 10)
            {
                minPastStr = "0" + minPastStr;
            }
            if(secPast < 10)
            {
                secPastStr = "0" + secPastStr;
            }

            label3.Text = minPastStr + ":" + secPastStr;
        }
    }
}
