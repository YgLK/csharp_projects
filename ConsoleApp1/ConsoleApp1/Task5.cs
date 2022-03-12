using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Task5
    {

        public static void task5()
        {
            // obstawiam że nie jest to liniowa złożoność, ale Dicitonary fajnie działa w takim przypadku
            Console.WriteLine("Enter text:");
            char[] text = Console.ReadLine().Replace(" ", "").ToLower().ToCharArray();
            Dictionary<char, int> counts = text.GroupBy(x => x).ToDictionary(g => g.Key, g => g.Count());
            foreach (KeyValuePair<char, int> pair in counts)
            {
                Console.WriteLine("Key: {0}, Value: {1}", pair.Key, pair.Value);
            }

            // different approach to printing
            //counts.ToList().ForEach(x => Console.WriteLine(x.Value));
            //counts.ToList().ForEach(x => Console.WriteLine(x.Key));
            Console.ReadKey();
        }
    }
}
