using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Task3
    {
        public static void task3()
        {
            Console.WriteLine("Ile liczb: ");
            int ile_liczb = Int32.Parse(Console.ReadLine());
            string[] liczby = Console.ReadLine().Split(' ');
            if (liczby.Count() != liczby.Distinct().Count())
            {
                // Duplicates exist
                Console.WriteLine("NIE");
            } else
            {
                // check if all digits are in the list
                for (int i = 1; i <= ile_liczb; i++)
                {
                    if (!liczby.Contains(i.ToString()))
                    {
                        Console.WriteLine("NIE");
                        break;
                    }
                    // if we get to the end
                    if(i == ile_liczb)
                    {
                        Console.WriteLine("TAK");
                    }
                }

            }
            Console.ReadKey();
        }
    }
}
