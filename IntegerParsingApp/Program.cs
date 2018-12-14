using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

namespace IntegerParsingApp
{
    public class Program
    {
        private const int UpperBound = 999;
        private const int LowerBound = 1;

        static void Main(string[] args)
        {
            string userInput1;
            int value1 = -1;
            string userInput2;
            int value2 = -1;
            bool isValid = false;
            var result = new Dictionary<int, int>();

            while (!isValid)
            {
                Console.Write("Enter a number between 1 and 999: ");
                userInput1 = Console.ReadLine();
                isValid = ValidateInput(userInput1);
                if (isValid)
                    value1 = int.Parse(userInput1);
            }
            isValid = false;
            while(!isValid)
            { 
                Console.Write("Enter a second number between 1 and 999: ");
                userInput2 = Console.ReadLine();
                isValid = ValidateInput(userInput2);
                if (isValid)
                    value2 = int.Parse(userInput2);
            }

            result = Process(value1, value2);
            PrintDictionary(result);
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
            var numbersAndCounts = new Dictionary<int, int>();
            int eCount = 0;

            range = Conversion.ConvertToRange(value1, value2);

            foreach (int value in range)
            {
                word = Conversion.ConvertNumberToWord(value);
                numberToWord.Add(value, word);
            }

            foreach (KeyValuePair<int, string> entry in numberToWord)
            {
                eCount = Count(entry.Value);
                numbersAndCounts.Add(entry.Key, eCount);
            }

            return numbersAndCounts;
        }
        
        private static int Count(string word)
        {
            return word.Count(f => f == 'e');
        }

        private static void PrintDictionary(Dictionary<int, int> numbersAndCounts)
        {
            foreach (KeyValuePair<int, int> entry in numbersAndCounts)
                Debug.WriteLine("Integer: " + entry.Key + ". Number of e's in string representation: " + entry.Value);
        }
    }
}
