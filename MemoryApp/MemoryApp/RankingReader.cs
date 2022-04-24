using System;
using System.Collections.Generic;
using System.IO;


namespace MemoryApp
{
    internal class  RankingReader
    {
        string rankingPath = Directory.GetParent(
            Environment.CurrentDirectory).Parent.FullName + "\\rankingData.txt";
        List<Tuple<int, string>> rankingRecords = new List<Tuple<int, string>>();

        public RankingReader()
        {
            int score = 0;
            string wholeRecord = "";

            // add each record to list
            foreach (string record in System.IO.File.ReadLines(rankingPath))
            {
                string[] elements = record.Split(',');
                score = Int32.Parse(elements[0]);
                wholeRecord = String.Empty;
                foreach (string str in elements)
                {
                    wholeRecord += str + "\t\t"; 
                }
                rankingRecords.Add(Tuple.Create(score, wholeRecord));
            }
            // sort by the score (this sorts ascending)
            rankingRecords.Sort((x, y) => y.Item1.CompareTo(x.Item1));
        }

        public List<string> getRecords()
        {
            List<string> stringRecords = new List<string>();
            // add headers
            stringRecords.Add("SCORE		NICKNAME	TIME	    MOVES");
            stringRecords.Add("");
            foreach(Tuple<int, string> tup in rankingRecords)
            {
                stringRecords.Add(tup.Item2);
            }
            // return sorted records
            return stringRecords;
        }
    }
}
