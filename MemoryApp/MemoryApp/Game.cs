﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MemoryApp
{
    public partial class Game : Form
    {
        //-----------------------
        //    CONFIGURATION 
        //-----------------------
        // button grid info
        int rowCount;
        int columnCount;
        // defualt mode 16 cards
        int cardsCount;
        // before start cards shown time
        int prepTime;
        // time of the card being shown after clicking on it
        int milisecCardShown;
        int gameTimeInSec = 0;


        // each index in arrays corresponds to the x, y coordinates on the grid
        List<Tuple<Button, int[]>> pickedCards;
        Dictionary<int, int> cardsPairs;
        Dictionary<int, int> cardsImageIdx;

        // number of correctly chosen pairs
        int correctBets = 0;
        // number of moves
        int moveCount = 0;


        public Game()
        {
            InitializeComponent();
            
            // set background of labels transparent
            label1.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;
            label3.BackColor = System.Drawing.Color.Transparent;
            label4.BackColor = System.Drawing.Color.Transparent;
            movesCountLabel.BackColor = System.Drawing.Color.Transparent;

            // set game configuration values
            InitConfiguration();
            // initialize components attributes
            InitializeCardValues();
            // create grid of cards 
            CreateVisualCards();
            // start the game by showing the cards
            StartShowCards();
        }

        private void InitConfiguration()
        {
            cardsPairs = new Dictionary<int, int>();
            cardsImageIdx = new Dictionary<int, int>();


            pickedCards = new List<Tuple<Button, int[]>>();
            movesCountLabel.Text = "0";

            // SET config from MemoryData class
            rowCount = MemoryData.rowCount;
            columnCount = MemoryData.columnCount;
            cardsCount = rowCount * columnCount;
            prepTime = MemoryData.prepTime;
            milisecCardShown = MemoryData.milisecCardShown;

            cardsCount = rowCount * columnCount;


            // init values of components
            label3.Text = "00:00";
            movesCountLabel.Text = "0";
            timer1.Enabled = true;
        }


        // let player memorize cards values for the first 5 sec of the game 
        private async void StartShowCards()
        {
            // for the first 15 sec show cards values - Player tries to memorize its positions
            foreach (Button button in tableLayoutPanel1.Controls)
            {
                ShowCardValue(button);
            }

            // show cards for preparation Time
            await Task.Delay(prepTime);

            // hide cards
            foreach (Button button in tableLayoutPanel1.Controls)
            {
                button.BackgroundImage = Properties.Resources.cardDesign;
                button.Text = "";
            }
        }


        private void InitializeCardValues()
        {
            // generate 8 pairs of indexes (8*2 indexes included) for 4x4 board size
            cardsPairs = PairGenerator.GenerateIndexPairs(cardsCount);
            // generate card value for each pair
            cardsImageIdx = PairGenerator.GenerateCardValues(cardsCount, cardsPairs);
        }

        public void CreateVisualCards()
        {
            // create grid
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

            // put cards on the grid
            InitializeButtons();
        }

        private void InitializeButtons()
        {
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    var button = new Button();
                    button.Text = string.Format("");
                    // button id will be its name - name can be parsed with " " separator to get x, y indexes 
                    button.Name = string.Format("{0} {1}", i, j);
                    button.Click += new EventHandler(Button_Click);
                    button.Dock = DockStyle.Fill;
                    button.BackgroundImageLayout = ImageLayout.Stretch;
                    button.BackgroundImage = Properties.Resources.cardDesign;
                    this.tableLayoutPanel1.Controls.Add(button, j, i);
                }
            }
        }

        protected void Button_Click(object sender, EventArgs e)
        {
            if(timer1.Enabled == true)
            {
                Button button = sender as Button;
                // identify which button was clicked and perform necessary actions
                int[] cords = button.Name.Split().Select(Int32.Parse).ToArray<int>();
                // position in the array: 
                //pickedCards.Add(new Tuple<int, int>(cords[0], cords[1]));
                if (pickedCards.Count < 2)
                {
                    Tuple<Button, int[]> card = Tuple.Create(button, cords);
                    //pickedCards.Add(Tuple.Create(cords[0], cords[1]));
                    // check if added card is not the same as already picked one
                    if (!(pickedCards.Count == 1 && 
                        pickedCards[0].Item2[0] == card.Item2[0] && 
                        pickedCards[0].Item2[1] == card.Item2[1]))
                    {
                        pickedCards.Add(card);
                        ShowCardValue(button);
                        HideCardValue(button, milisecCardShown);
                    }
                }
            }
        }

        public async void ShowCardValue(Button button)
        {
            // identify which button was clicked and perform necessary actions
            int[] buttonCords = button.Name.Split().Select(Int32.Parse).ToArray<int>();
            int x_cord = buttonCords[0];
            int y_cord = buttonCords[1];
            // calculate button values idx in the dicts
            int buttonIdx = columnCount * x_cord + y_cord;
            // hide card image
            button.BackgroundImage = null;
            // show hidden image of the card
            string filename = "im" + cardsImageIdx[buttonIdx];
            // retrieve corresponding card image
            var cardImage = Properties.Resources.ResourceManager.GetObject(filename, Properties.Resources.Culture);
            // show card image
            button.BackgroundImage = (Image)cardImage;
        }

        public async void HideCardValue(Button button, int time)
        {
            // wait until second card is picked
            if(pickedCards.Count == 2)
            {
                // get card indexes and check if pair is picked
                int firstCardIdx = pickedCards[0].Item2[0] * columnCount + pickedCards[0].Item2[1];
                int secondCardIdx = pickedCards[1].Item2[0] * columnCount + pickedCards[1].Item2[1];
                if (cardsImageIdx[firstCardIdx] == cardsImageIdx[secondCardIdx])
                {
                    await Task.Delay(MemoryData.milisecCardShown);
                    // hide correctly picked pair
                    pickedCards[0].Item1.Visible = false;
                    pickedCards[1].Item1.Visible = false;
                    correctBets += 1;
                }
                

                // wait some time with the pair shown
                await Task.Delay(MemoryData.milisecCardShown);


                // update move counter
                moveCount += 1;
                movesCountLabel.Text = moveCount.ToString();
                // hide card value and show cards image
                pickedCards[0].Item1.BackgroundImage = Properties.Resources.cardDesign;
                pickedCards[1].Item1.BackgroundImage = Properties.Resources.cardDesign;
                pickedCards[0].Item1.Text = string.Format("");
                pickedCards[1].Item1.Text = string.Format("");
                // clear picked cards list
                pickedCards.Clear();
            }
            
            // save data to file and open new window after the end of the game
            if(correctBets == cardsCount / 2)
            {
                MemoryData.movesToWin = moveCount;
                MemoryData.timeToWin = gameTimeInSec;
                // evaluate score
                int score = MemoryData.evaluateScore();
                // prepare data record
                string rankingRecord = score + "," + MemoryData.nickname + "," + MemoryData.timeToWin + "," + MemoryData.movesToWin;

                // use relative path instead of absolute
                string rankingDataPath = @".\rankingData.txt";

                // write new game data record to the file
                using (StreamWriter sw = File.AppendText(rankingDataPath))
                {
                    sw.WriteLine(rankingRecord);
                }

                Ranking rankingForm = new Ranking();
                rankingForm.Show();
                this.Hide();
            }
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            gameTimeInSec += 1;
            // extract min:sec time format
            int minPast = gameTimeInSec / 60;
            int secPast = gameTimeInSec % 60;
            string minPastStr =  minPast.ToString();
            string secPastStr = secPast.ToString();

            // show time in the elegant way (instead of 0:1 it's 0:01 etc.)
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

        private void SetShowCardTime_Click(object sender, EventArgs e)
        {
            double newTime = InputValidator.validateDouble(visTimeChange.Text);
            // if newTime isn't in proper format -1 is returned
            if(newTime != -1)
            {
                // set card show time to configuration variable
                int newTimeInMilSec = (int)(newTime * 1000);
                // get absolute value of parameters to cope with negative values
                MemoryData.milisecCardShown = Math.Abs(newTimeInMilSec);
            }
        }

        private void GamePause_Click(object sender, EventArgs e)
        {
            // switch timer mode when gamePuase button is clicked
            if(timer1.Enabled == true)
            {
                timer1.Enabled = false;
            }
            else
            {
                timer1.Enabled = true;
            }
        }
    }
}
