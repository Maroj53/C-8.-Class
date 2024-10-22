namespace ConsoleParallelogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Print message asking for input
            Console.WriteLine("Enter the number of stars for the parallelogram's base:");

            // Read user input and convert it to an integer
            string numberOfStarsUnconverted = Console.ReadLine();
            int numberOfStars = Convert.ToInt32(numberOfStarsUnconverted);

            // Initialize variables for tracking star count and space count
            int numberOfStarsForCurrentRow = 0;
            int spacesBeforeStars = numberOfStars;

            // Flag for direction change, not currently used
            bool reverse = false;

            // Loop for drawing the top half of the triangle
            for (int a = 0; a < numberOfStars; a++)
            {
                // Increase the number of stars by 2 for each row
                numberOfStarsForCurrentRow = numberOfStarsForCurrentRow + 2;

                // Decrease the number of leading spaces for each row
                spacesBeforeStars = spacesBeforeStars - 1;

                // Print spaces before the stars to center-align the triangle
                for (int i = spacesBeforeStars; i > 0; i--)
                {
                    Console.Write(" ");
                }

                // Print the stars
                for (int i = 0; i < numberOfStarsForCurrentRow; i++)
                {
                    Console.Write("*");
                }

                // Move to the next line after printing the stars
                Console.WriteLine("");
            }

            // Loop for drawing the bottom half of the triangle
            for (int a = numberOfStars; a > 0; a--)
            {
                // Decrease the number of stars by 2 for each row
                numberOfStarsForCurrentRow = numberOfStarsForCurrentRow - 2;

                // Increase the number of leading spaces for each row
                spacesBeforeStars = spacesBeforeStars + 1;

                // Print spaces before the stars to center-align the triangle
                for (int i = 0; i < spacesBeforeStars; i++)
                {
                    Console.Write(" ");
                }

                // Print the stars
                for (int i = numberOfStarsForCurrentRow; i > 0; i--)
                {
                    Console.Write("*");
                }

                // Move to the next line after printing the stars
                Console.WriteLine("");
            }
        }
    }
}
