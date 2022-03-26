﻿using System;
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
        List<Tuple<Button, int[]>> pickedCards;
        //Dictionary<int, string> cardsPairs;
        Dictionary<int, int> cardsPairs;
        // array with strings corresponding to each card
        Dictionary<int, string> cardsStringValues;

        // button grid info
        int rowCount = 4;
        int columnCount = 4;

        // number of correctly chosen pairs
        int correctBets = 0;
        // number of moves
        int moveCount = 0;


        public Form2()
        {
            InitializeComponent();
            cardsPairs = new Dictionary<int, int>();
            cardsStringValues = new Dictionary<int, string>();
            pickedCards = new List<Tuple<Button, int[]>>();
            movesCountLabel.Text = "0";
            // initialize components attributes
            initializeCardValues();
            createVisualCards();
            label3.Text = "00:00";
            movesCountLabel.Text = "0";
            timer1.Enabled = true;
        }

        private void initializeCardValues()
        {
            // generate 8 pairs of indexes (8*2 indexes included)
            generateIndexPairs2();
            // generate card value for each pair
            generateCardValues();
        }


        // generate cards pairs by picking random index of another card for each card
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

        public void createVisualCards()
        {

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
                    button.BackgroundImageLayout = ImageLayout.Stretch;
                    button.BackgroundImage = Properties.Resources.cardDesign;
                    this.tableLayoutPanel1.Controls.Add(button, j, i);
                }
            }
        }

        protected void button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            // identify which button was clicked and perform necessary actions
            int[] cords = button.Name.Split().Select(Int32.Parse).ToArray<int>();
            // position in the array: 
            //pickedCards.Add(new Tuple<int, int>(cords[0], cords[1]));
            if(pickedCards.Count < 2)
            {
                Tuple<Button, int[]> card = Tuple.Create(button, cords);
                //pickedCards.Add(Tuple.Create(cords[0], cords[1]));
                // check if added card is not the same as already picked one
                if (!(pickedCards.Count == 1 && 
                    pickedCards[0].Item2[0] == card.Item2[0] && 
                    pickedCards[0].Item2[1] == card.Item2[1]))
                {
                    pickedCards.Add(card);
                    showCardValue(button, cords);
                    hideCardValue(button, milisecCardShown);
                }
            }
        }

        public async Task showCardValue(Button button, int[] buttonCords)
        {
            int x_cord = buttonCords[0];
            int y_cord = buttonCords[1];
            // calculate button values idx in the dicts
            int buttonIdx = columnCount * x_cord + y_cord;
            // hide card image
            button.BackgroundImage = null;
            // show hidden text of the card
            button.Text = cardsStringValues[buttonIdx];
        }

        public async Task hideCardValue(Button button, int time)
        {
            // wait until second card is picked
            if(pickedCards.Count == 2)
            {
                int firstCardIdx = pickedCards[0].Item2[0] * columnCount + pickedCards[0].Item2[1];
                int secondCardIdx = pickedCards[1].Item2[0] * columnCount + pickedCards[1].Item2[1];
                if (cardsStringValues[firstCardIdx] == cardsStringValues[secondCardIdx])
                {
                    // hide correctly picked pair
                    pickedCards[0].Item1.Visible = false;
                    pickedCards[1].Item1.Visible = false;
                    correctBets += 1;
                }
                
                time = 1000;
                // wait some time with the pair shown
                await Task.Delay(time);
                // hide cards
                pickedCards[0].Item1.Text = pickedCards[0].Item1.Name;
                pickedCards[1].Item1.Text = pickedCards[1].Item1.Name;

                moveCount += 1;
                movesCountLabel.Text = moveCount.ToString();
                // hide card value and show cards image
                pickedCards[0].Item1.BackgroundImage = Properties.Resources.cardDesign;
                pickedCards[1].Item1.BackgroundImage = Properties.Resources.cardDesign;
                // clear picked cards list
                pickedCards.Clear();
            }
            
            // open new window after the end of the game
            if(correctBets == cardsCount / 2)
            {
                MessageBox.Show("Nice");
            }
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
