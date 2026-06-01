namespace FizzBuzz
{
    /// <summary>
    /// Represents the result of FizzBuzz processing.
    /// Contains the final output string and count of replacements.
    /// </summary>
    public class FizzBuzzResult
    {
        /// <summary>
        /// Final processed output string after applying FizzBuzz rules.
        /// </summary>
        public string OutputString { get; set; }

        /// <summary>
        /// Number of times Fizz, Buzz, or FizzBuzz replacements occurred.
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// Initializes a new instance of FizzBuzzResult.
        /// </summary>
        public FizzBuzzResult(string outputString, int overlapCount)
        {
            OutputString = outputString;
            Count = overlapCount;
        }
    }
}