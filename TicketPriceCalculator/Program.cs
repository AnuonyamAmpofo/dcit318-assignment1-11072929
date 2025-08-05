using System;

namespace TicketPriceCalculator
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());

            double ticketPrice;

            if (age < 12 || age >= 65)
                ticketPrice = 7.00;
            
            else
                ticketPrice = 10.00;

            Console.WriteLine($"The ticket price is: ${ticketPrice}");
        }
    }
}
