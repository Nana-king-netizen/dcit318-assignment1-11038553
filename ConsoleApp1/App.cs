using System;

namespace ConsoleApp1
{
    internal class App
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Console Application! Please choose an option:");
            Console.WriteLine("1. Calculate Ticket Price");
            Console.WriteLine("2. Determine Triangle Type");
            Console.WriteLine("3. Grade Calculator");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    new TicketPriceCalculator().CalculateTicketPrice();
                    break;
                case "2":
                    new TriangleType().DetermineTriangleType();
                    break;
                case "3":
                    new GradeCalculator().Calculator();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;
            }
        }
    }
}