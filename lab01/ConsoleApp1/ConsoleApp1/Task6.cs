using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Task6
    {
        public static void task6()
        {
            Console.WriteLine("Enter the text:");
            string text = Console.ReadLine();
            Console.WriteLine("Part to be replaced:");
            string toReplace = Console.ReadLine();
            Console.WriteLine("Replacement:");
            string replacement = Console.ReadLine();

            text = text.Replace(toReplace, replacement);
            Console.WriteLine(text);

            Console.ReadKey();
        }
    }
}
