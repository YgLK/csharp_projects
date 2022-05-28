using System;
using System.Collections.Generic;
using System.IO;


namespace MemoryApp
{
    internal class  RankingReader
    {
        //string rankingPath = Directory.GetParent(
        //    Environment.CurrentDirectory).Parent.FullName + "\\rankingData.txt";
        string rankingPath = @"rankingData.txt";
        List<Tuple<int, string>> rankingRecords = new List<Tuple<int, string>>();

        string sampleData = "922,Unknown,4,2\n934,Unknown,3,2\n859,Bob,8,3\n910,Unknown,5,2\n934,Unknown,3,2\n694,Unknown,23,2\n895,Unknown,5,3\n898,Unknown,6,2\n541,Unknown,57,25\n182,NowyGr,84,54\n346,NowyG,2,2\n609,JohnDOe,28,17\n637,Unknown,39,33\n838,Unknown,31,26\n1009,Krak,28,17\n334,qwe123,3,2\n364,Unknown,58,36\n322,Unknown,4,2\n298,Test123,6,2\n471,Unknown,7,3\n298,Unknown,6,2\n718,Unknown,41,26\n590,Unknown,10,6\n1030,Unknown,25,18\n513,Test,31,21\n841,Test1,7,5\n310,asd,5,2\n378,Karol,11,6\n";

        public RankingReader()
        {
            // if rankingFile doesnt exist create one and fill with the sample data I created
            if (!File.Exists(rankingPath))
            {
                using (StreamWriter sw = File.CreateText(rankingPath))
                {
                    // write sample tasks data 
                    sw.Write(rankingPath);
                }
            }
            else
            {
                File.WriteAllText(rankingPath, sampleData);
            }


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
