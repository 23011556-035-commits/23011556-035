using System;


public class SumOfNaturalNumbers
    {
       public void NaturalNumbers()
        
        
            {
                Console.Write("Enter n: ");
                int n = Convert.ToInt32(Console.ReadLine());
                int sum = 0;

                for (int i = 1; i <= n; i++)
                    sum += i;

                Console.WriteLine($"Sum of numbers from 1 to {n} = {sum}");
            }
        }

    


