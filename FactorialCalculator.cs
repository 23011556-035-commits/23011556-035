using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23011556_035
{
    internal class FactorialCalculator
    {
        class Factorial
        {
            public static void Run()
            {
                Console.Write("Enter a number: ");
                int n = Convert.ToInt32(Console.ReadLine());
                int fact = 1;
                int i = 1;

                while (i <= n)
                {
                    fact *= i;
                    i++;
                }

                Console.WriteLine($"Factorial of {n} = {fact}");
            }
        }

    }
}
