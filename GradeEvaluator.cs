using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23011556_035
{
    internal class GradeEvaluator
    {
        class Grade
        {
            public static void Run()
            {
                Console.Write("Enter your marks (0–100): ");
                int marks = Convert.ToInt32(Console.ReadLine());
                char grade;

                if (marks >= 85) grade = 'A';
                else if (marks >= 70) grade = 'B';
                else if (marks >= 55) grade = 'C';
                else if (marks >= 40) grade = 'D';
                else grade = 'F';

                Console.WriteLine($"Your grade is: {grade}");
            }
        }


    }
}
