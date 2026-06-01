namespace FizzBuzz
{
    /// <summary>
    /// Responsible for detecting words and applying FizzBuzz rules
    /// based on word position in the input string.
    /// </summary>
    public class FizzBuzzDetector
    {
        /// <summary>
        /// Determines whether a character is part of a valid word.
        /// A valid word character is:
        /// - Letter (A-Z, a-z)
        /// - Digit (0-9)
        /// - Apostrophe (')
        /// </summary>
        private bool IsWordChar(char c)
        {
            bool isLetter =
                (c >= 'A' && c <= 'Z') ||
                (c >= 'a' && c <= 'z');

            bool isNumber =
                (c >= '0' && c <= '9');

            bool isApostrophe = (c == '\'');

            return isLetter || isNumber || isApostrophe;
        }

        /// <summary>
        /// Processes input string, extracts words manually,
        /// applies FizzBuzz rules on word positions,
        /// and counts replacements.
        /// </summary>
        public FizzBuzzResult GetOverlappings(string input)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            string currentWord = "";
            string output = "";

            int wordCounter = 0;
            int overlapCount = 0;

            for (int i = 0; i <= input.Length; i++)
            {
                bool endOfWord = false;

                // End of input
                if (i == input.Length)
                {
                    endOfWord = true;
                }
                else
                {
                    if (!IsWordChar(input[i]))
                        endOfWord = true;
                }

                if (!endOfWord)
                {
                    currentWord += input[i];
                }
                else
                {
                    if (currentWord.Length > 0)
                    {
                        wordCounter++;

                        // FizzBuzz rules
                        if (wordCounter % 15 == 0)
                        {
                            output += "FizzBuzz";
                            overlapCount++;
                        }
                        else if (wordCounter % 3 == 0)
                        {
                            output += "Fizz";
                            overlapCount++;
                        }
                        else if (wordCounter % 5 == 0)
                        {
                            output += "Buzz";
                            overlapCount++;
                        }
                        else
                        {
                            output += currentWord;
                        }

                        currentWord = "";
                    }

                    // Keep original separators (spaces, punctuation, new lines)
                    if (i < input.Length)
                    {
                        output += input[i];
                    }
                }
            }

            return new FizzBuzzResult(output, overlapCount);
        }
    }
}