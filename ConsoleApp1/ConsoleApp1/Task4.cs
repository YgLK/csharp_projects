using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Task4
    {
        public static void task4()
        {
            Console.WriteLine("Podaj ilość pomiarów:");
            int n = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wagi:");
            string[] weight_str = Console.ReadLine().Split(' ');
            int[] weight_int = Array.ConvertAll(weight_str, s => int.Parse(s));

            int bestMassLoss = 0;
            for (int i = 0; i < weight_str.Length; i++)
            {
                for(int j=i+1; j < weight_str.Length; j++)
                {
                    // first condition is not compulsory but it's more clear to read if occurs
                    if(weight_int[i] > weight_int[j] && 
                        (weight_int[i] - weight_int[j]) > bestMassLoss)
                    {
                        bestMassLoss = weight_int[i] - weight_int[j];
                    }
                }
            }
            Console.WriteLine("Max massloss: " + bestMassLoss);
            Console.ReadKey();
        }
    } 
}
