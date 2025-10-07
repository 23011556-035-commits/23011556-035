using System;

public class ReverseNumber
    {
        public void Reverse()
        
    
            {
                Console.Write("Enter an integer: ");
                int num = Convert.ToInt32(Console.ReadLine());
                int reversed = 0;

                while (num > 0)
                {
                    int digit = num % 10;
                    reversed = reversed * 10 + digit;
                    num /= 10;
                }

                Console.WriteLine($"Reversed number = {reversed}");
            }
        }

    


