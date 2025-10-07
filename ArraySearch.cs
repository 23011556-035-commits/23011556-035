using System;



public class ArraySearch
    {
       public class Array1()
        
        
            {
                Console.Write("Enter number of elements: ");
                int n = Convert.ToInt32(Console.ReadLine());
                int[] arr = new int[n];

                Console.WriteLine($"Enter {n} elements:");
                for (int i = 0; i < n; i++)
                    arr[i] = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter number to search: ");
                int search = Convert.ToInt32(Console.ReadLine());
                bool found = false;

                foreach (int x in arr)
                {
                    if (x == search)
                    {
                        found = true;
                        break;
                    }
                }

                if (found)
                    Console.WriteLine($"{search} found in array.");
                else
                    Console.WriteLine($"{search} not found in array.");
            }
        }
    


        

