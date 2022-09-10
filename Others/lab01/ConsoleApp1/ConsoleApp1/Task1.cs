using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Task1
    {
        public static void task1()
        {
            Console.WriteLine("Podaj rok:");
            int year = Int32.Parse(Console.ReadLine());
            if (year % 4 == 0)
            {
                Console.WriteLine(year + " - rok jest przestępny");
            } else
            {
                Console.WriteLine(year + " - rok nie jest przestępny");
            }
            Console.ReadKey();
        }
    }
}
