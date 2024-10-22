using System;

namespace Parallelogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of rows for the parallelogram:");
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

            // Print the parallelogram
            for (int row = 0; row < numberOfRows; row++)
            {
                // Print spaces for the parallelogram shape
                for (int i = 0; i < currentRowSpaces; i++)
                {
                    Console.Write(" ");
                }

                // Print stars
                currentRowStars = numberOfRows; // Set the number of stars to the total number of rows
                for (int i = 0; i < currentRowStars; i++)
                {
                    Console.Write("*");
                }

                Console.WriteLine(); // Move to the next line

                // Decrease the number of spaces for the next row
                currentRowSpaces--;
            }
        }
    }
}
