using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class GradeCalculator
    {
        public void Calculator() { 
        Console.WriteLine("Enter your grade(0-100): ");
            int grade = int.Parse(Console.ReadLine());
            if(grade >= 90 && grade <= 100)
            {
                Console.WriteLine("Your grade is A");
            }
            else if (grade >= 80 && grade < 90)
            {
                Console.WriteLine("Your grade is B");
            }
            else if (grade >= 70 && grade < 80)
            {
                Console.WriteLine("Your grade is C");
            }
            else if (grade >= 60 && grade < 70)
            {
                Console.WriteLine("Your grade is D");
            }
            else if (grade >= 0 && grade < 60)
            {
                Console.WriteLine("Your grade is F");
            }
            else
            {
                Console.WriteLine("Invalid grade entered. Please enter a number between 0 and 100.");
            }
        }
    }
}
