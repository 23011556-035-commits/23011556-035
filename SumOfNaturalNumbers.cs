using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23011556_035
{
    internal class SumOfNaturalNumbers
    {
        class NaturalNumbers
        {
            public static void Run()
            {
                Console.Write("Enter n: ");
                int n = Convert.ToInt32(Console.ReadLine());
                int sum = 0;

                for (int i = 1; i <= n; i++)
                    sum += i;

                Console.WriteLine($"Sum of numbers from 1 to {n} = {sum}");
            }
        }

    }
}
