using System;



    public class GradeEvaluator
    {
        public class Grade()
        
            
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


    


