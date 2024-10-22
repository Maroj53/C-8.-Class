using System;

namespace Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of rows for the triangle:");
            string inputNumberOfRows = Console.ReadLine();
            int numberOfRows;

            // Validate the input
            if (!int.TryParse(inputNumberOfRows, out numberOfRows) || numberOfRows <= 0)
            {
                Console.WriteLine("Please enter a valid positive integer.");
                return;
            }

            int currentRowStars = 0; // Current number of stars in the row
            int currentRowSpaces = numberOfRows; // Current number of spaces before the stars

            // Print the upper part of the triangle
            for (int row = 0; row < numberOfRows; row++)
            {
                currentRowStars++; // Increase the number of stars
                currentRowSpaces--; // Decrease the number of spaces

                // Print spaces
                for (int i = 0; i < currentRowSpaces; i++)
                {
                    Console.Write(" ");
                }

                // Print stars
                for (int i = 0; i < currentRowStars; i++)
                {
                    Console.Write("*");
                }

                Console.WriteLine(); // Move to the next line
            }

            // Reset values for the lower part of the triangle
            currentRowStars = numberOfRows; // Reset stars to number of rows
            currentRowSpaces = 1; // Start with one space for the lower part

            // Print the lower part of the triangle
            for (int row = numberOfRows; row > 0; row--)
            {
                currentRowStars--; // Decrease the number of stars
                currentRowSpaces++; // Increase the number of spaces

                // Print spaces
                for (int i = 0; i < currentRowSpaces; i++)
                {
                    Console.Write(" ");
                }

                // Print stars
                for (int i = 0; i < currentRowStars; i++)
                {
                    Console.Write("*");
                }

                Console.WriteLine(); // Move to the next line
            }
        }
    }
}
