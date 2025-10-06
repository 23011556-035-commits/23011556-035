using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23011556_035
{
    internal class evenoddchecker
    {
        class EvenOdd
        {
            public static void Run()
            {
                Console.Write("Enter a number: ");
                int num = Convert.ToInt32(Console.ReadLine());

                if (num % 2 == 0)
                    Console.WriteLine($"{num} is Even.");
                else
                    Console.WriteLine($"{num} is Odd.");
            }
        }

    }
}
