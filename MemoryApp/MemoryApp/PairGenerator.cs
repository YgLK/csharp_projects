using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryApp
{
    public static class PairGenerator
    {
        // generate cards pairs by picking random index of another card for each card
        public static Dictionary<int, int> GenerateIndexPairs(int cardsCount)
        {
            Dictionary<int, int> cardsPairs = new Dictionary<int, int>();

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

            return cardsPairs;
        }

        public static Dictionary<int, int> GenerateCardValues(int cardsCount, Dictionary<int, int> cardsPairs)
        {
            Dictionary<int, int> cardsImageIdx = new Dictionary<int, int>();

            int i = 0;
            // add value of each card into the dictionary
            foreach (KeyValuePair<int, int> kvp in cardsPairs)
            {
                if (!cardsImageIdx.Keys.Contains(kvp.Key))
                {
                    cardsImageIdx.Add(kvp.Key, i);
                    cardsImageIdx.Add(kvp.Value, i);
                    i++;
                }
            }
            return cardsImageIdx;
        }
    }
}
