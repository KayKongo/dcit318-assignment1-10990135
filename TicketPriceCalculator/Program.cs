using System;

class TicketPriceCalculator
{
    static void Main()
    {
        // Prompt the user to enter their age
        Console.Write("Enter your age: ");
        string input = Console.ReadLine();

        // Try to parse the input to an integer
        if (int.TryParse(input, out int age))
        {
            // Determine the ticket price based on the age
            int ticketPrice;
            if (age >= 65 || age <= 12)
            {
                ticketPrice = 7; // Discounted price
            }
            else
            {
                ticketPrice = 10; // Regular price
            }

            // Display the ticket price
            Console.WriteLine($"The ticket price for age {age} is: GHC{ticketPrice}");
        }
        else
        {
            Console.WriteLine("Error: Invalid input. Please enter a valid age.");
        }
    }
}
