using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntegerParsingApp
{
    public class Program
    {
        // Prompt for input like "6, 10" which represents the inclusive range
        // Validate input

        private const int UpperBound = 999;
        private const int LowerBound = 1;

        static void Main(string[] args)
        {
            string userInput1;
            int value1 = -1;
            string userInput2;
            int value2 = -1;
            bool isValid = false;


            while (!isValid)
            {
                Console.Write("Enter a number between 1 and 999.");
                userInput1 = Console.ReadLine();
                isValid = ValidateInput(userInput1);
                if (isValid)
                    value1 = int.Parse(userInput1);
            }
            isValid = false;
            while(!isValid)
            { 
                Console.Write("Enter a second number between 1 and 999.");
                userInput2 = Console.ReadLine();
                isValid = ValidateInput(userInput2);
                if (isValid)
                    value2 = int.Parse(userInput2);
            }

            Process(value1, value2);
        }

        private static bool ValidateInput(string input)
        {
            bool isValid;
            int value = -1;
            isValid = int.TryParse(input, out value);

            if (isValid && (UpperBound < value || value < LowerBound))
            {
                isValid = false;
            }
            return isValid;
        }

        private static Dictionary<int, int> Process(int value1, int value2)
        {
            var range = new List<int>();
            string word = "";
            var numberToWord = new Dictionary<int, string>();
            // function to take in two integers and convert integer pair into the full range - array of values returned
            range = Conversion.ConvertToRange(value1, value2);

            foreach (int value in range)
            {
                // function to convert each of the values in an array of integers into it's string representation. 
                word = Conversion.ConvertNumberToWord(value);
                numberToWord.Add(value, word);
            }

            throw new NotImplementedException();
        }
        
        private static int Count(string word)
        {
            throw new NotImplementedException();
        }

        // function to take the dictionary of int and string pairs, and parse out the number of occurrences of 'e' in each string representation.
        // Return a dictionary of int and occurrence count pairs like [6,0], [7,2], [8,1], [9,1], [10,1]

        // Unit tests?
    }
}
