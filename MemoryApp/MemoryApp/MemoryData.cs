using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryApp
{
    internal static class MemoryData
    {
        public static string nickname = "Unknown";
        public static int timeToWin = 0;
        public static int movesToWin = 0;
        // --- CONFIGURATION --- 
        // button grid info
        public static int rowCount = 4;
        public static int columnCount = 4;
        // defualt mode 16 cards
        public static int cardsCount = rowCount * columnCount;
        // before start cards shown time
        public static int prepTime = 3000;
        // time of the card being shown after clicking on it
        public static int milisecCardShown = 400;
        public static int gameTimeInSec = 0;

         
        public static int evaluateScore()
        {
            return 100 * cardsCount - (timeToWin * 12 + movesToWin * 15);
        }

        public static void setData(int row_size=4, int col_size=4, double pre_time=3000, double card_shown_time=400)
        {
            rowCount = row_size;
            columnCount = col_size;
            cardsCount = row_size * col_size;
            prepTime = (int)(pre_time * 1000);
            milisecCardShown = (int)(card_shown_time * 1000);
        }
    }
}
