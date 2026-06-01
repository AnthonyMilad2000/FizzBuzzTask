namespace FizzBuzz
{
    /// <summary>
    /// Entry point of the application.
    /// Responsible for reading user input and displaying the FizzBuzz result.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Main method: reads multiple lines from the user,
        /// combines them into a single input string,
        /// then processes it using FizzBuzzDetector.
        /// </summary>
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number Of Lines:");

            int numberOfLines = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter each line separately (press Enter after each line):");
            string input = "";

            // Read multiple lines from user input
            for (int i = 0; i < numberOfLines; i++)
            {
                input += Console.ReadLine();

                // Add newline between lines except last one
                if (i < numberOfLines - 1)
                {
                    input += "\n";
                }
            }

            // Create detector instance
            FizzBuzzDetector detector = new FizzBuzzDetector();

            // Process input
            FizzBuzzResult result = detector.GetOverlappings(input);

            Console.WriteLine();
            Console.WriteLine("===== Output String =====");
            Console.WriteLine(result.OutputString);

            Console.WriteLine();
            Console.WriteLine($"Count: {result.Count}");
        }
    }
}