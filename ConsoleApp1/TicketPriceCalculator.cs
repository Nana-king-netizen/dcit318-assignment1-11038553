using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class TicketPriceCalculator
    {
        public void CalculateTicketPrice()
        {
            Console.WriteLine("Enter your age: ");
            int age = int.Parse(Console.ReadLine());
            if (age < 0)
            {
                Console.WriteLine("Invalid age entered. Please enter a non-negative number.");
                return;
            }
            double ticketPrice = 10.0;
            if (age <= 12 || age >= 65)
            {
                ticketPrice = ticketPrice - 7.0;
                if (age <= 12)
                {
                    Console.WriteLine($"Child discount applied, the discounted ticket costs {ticketPrice} cedis");
                }
                else if (age >= 65)
                {
                    Console.WriteLine($"Senior discount applied, the discounted ticket costs {ticketPrice} cedis");
                }
                else
                { 
                    Console.WriteLine($"The ticket price is {ticketPrice} cedis");
                }

            }
        }
    }
}
               
        
    

