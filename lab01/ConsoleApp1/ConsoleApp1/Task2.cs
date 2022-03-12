using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Task2
    {
        public static void task2()
        {
            Console.WriteLine("Podaj liczbę:");
            int n = Int32.Parse(Console.ReadLine());
            int sum = 0;
            while (n != 0)
            {
                sum += n % 10;
                n /= 10;
            }
            Console.WriteLine("Suma liczb to: " + sum);
            Console.ReadKey();
        }
    }
}
