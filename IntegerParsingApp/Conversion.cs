using System.Collections.Generic;
using System.Linq;

namespace IntegerParsingApp
{
    public class Conversion
    {
        public static List<int> ConvertToRange(int firstValue, int secondValue)
        {
            var upperBound = GetMax(firstValue, secondValue);
            var lowerBound = GetMin(firstValue, secondValue);
            var range = new List<int>();
            return range = Enumerable.Range(lowerBound, upperBound).ToList();
        }

        public static int GetMax(int first, int second)
        {
            return first > second ? first : second;
        }

        public static int GetMin(int first, int second)
        {
            return first < second ? first : second;
        }

        public static string ConvertNumberToWord(int number)
        {
            /**
             * In the future if requirements changed to need to handle a different range of input values,
             * for example; 0 and negative values, or larger than 999, 
             * it would be valuable to update this function to include the commented out portions
             **/

            //if (number == 0)
            //    return "zero";

            //if (number < 0)
            //    return "minus " + ConvertNumberToWord(Math.Abs(number));

            string word = "";

            //if ((number / 1000000) > 0)
            //{
            //    word += ConvertNumberToWord(number / 1000000) + " million ";
            //    number %= 1000000;
            //}

            //if ((number / 1000) > 0)
            //{
            //    word += ConvertNumberToWord(number / 1000) + " thousand ";
            //    number %= 1000;
            //}

            if ((number / 100) > 0)
            {
                word += ConvertNumberToWord(number / 100) + " hundred ";
                number %= 100;
            }

            if (number > 0)
            {
                if (word != "")
                    word += "and ";

                var unitsMap = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
                var tensMap = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

                if (number < 20)
                    word += unitsMap[number];
                else
                {
                    word += tensMap[number / 10];
                    if ((number % 10) > 0)
                        word += "-" + unitsMap[number % 10];
                }
            }
            return word;
        }
    }
}
