using System;

class TriangleTypeIdentifier
{
    static void Main()
    {
        // Prompt the user to enter the lengths of the three sides of the triangle
        Console.Write("Enter the length of the first side: ");
        string input1 = Console.ReadLine();

        Console.Write("Enter the length of the second side: ");
        string input2 = Console.ReadLine();

        Console.Write("Enter the length of the third side: ");
        string input3 = Console.ReadLine();

        // Try to parse the inputs to integers
        if (int.TryParse(input1, out int side1) && 
            int.TryParse(input2, out int side2) && 
            int.TryParse(input3, out int side3))
        {
            // Check if the sides form a valid triangle
            if (side1 > 0 && side2 > 0 && side3 > 0)
            {
                // Determine the type of the triangle
                string triangleType;
                if (side1 == side2 && side2 == side3)
                {
                    triangleType = "Equilateral";
                }
                else if (side1 == side2 || side1 == side3 || side2 == side3)
                {
                    triangleType = "Isosceles";
                }
                else
                {
                    triangleType = "Scalene";
                }

                // Display the type of the triangle
                Console.WriteLine($"The triangle with sides {side1}, {side2}, and {side3} is: {triangleType}");
            }
            else
            {
                Console.WriteLine("Error: The lengths entered do not form a valid triangle.");
            }
        }
        else
        {
            Console.WriteLine("Error: Invalid input. Please enter valid lengths for the sides of the triangle.");
        }
    }
}
