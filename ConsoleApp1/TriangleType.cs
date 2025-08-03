using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class TriangleType
    {
        public void DetermineTriangleType()
        {
            Console.WriteLine("Enter the lengths of the three sides of the triangle: ");
            Console.Write("Side A: ");
            double sideA = double.Parse(Console.ReadLine());
            Console.Write("Side B: ");
            double sideB = double.Parse(Console.ReadLine());
            Console.Write("Side C: ");
            double sideC = double.Parse(Console.ReadLine());
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                Console.WriteLine("Invalid input. Side lengths must be positive numbers.");
                return;
            }
            if (sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA)
            {
                if (sideA == sideB && sideB == sideC)
                {
                    Console.WriteLine("The triangle is Equilateral.");
                }
                else if (sideA == sideB || sideB == sideC || sideA == sideC)
                {
                    Console.WriteLine("The triangle is Isosceles.");
                }
                else
                {
                    Console.WriteLine("The triangle is Scalene.");
                }
            }
            else
            {
                Console.WriteLine("The lengths do not form a valid triangle.");
            }
        }
    }
}
