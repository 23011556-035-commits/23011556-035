using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23011556_035
{
    internal class MultiplicationTable
    {
        class Multiplication
        {
            public static void Run()
            {
                Console.Write("Enter a number: ");
                int num = Convert.ToInt32(Console.ReadLine());

                for (int i = 1; i <= 10; i++)
                    Console.WriteLine($"{num} x {i} = {num * i}");
            }
        }

    }
}
