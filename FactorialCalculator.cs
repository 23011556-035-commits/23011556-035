﻿using System;



public class FactorialCalculator
    {
       public class Factorial()
        
        
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

    


