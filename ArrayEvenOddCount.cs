using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23011556_035
{
    internal class ArrayEvenOddCount
    {
        class EvenOddCount
        {
            public static void Run()
            {
                int[] arr = new int[10];
                int even = 0, odd = 0;

                Console.WriteLine("Enter 10 integers:");

                for (int i = 0; i < 10; i++)
                {
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                    if (arr[i] % 2 == 0) even++;
                    else odd++;
                }

                Console.WriteLine($"Even numbers: {even}");
                Console.WriteLine($"Odd numbers: {odd}");
            }
        }

    }
}
