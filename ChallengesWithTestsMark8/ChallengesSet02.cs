using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return c >= 'a' && c <= 'z' || c >= 'A' && c <= 'Z';
        }

        public bool CountOfElementsIsEven(string[] vals) /// for arrays use for loops, for arrays use Length
        {
            string str = "";
            Console.WriteLine(str.Length);
            bool returnValue = true;
            if (vals.Length % 2 != 0)
            {
                returnValue = false;
            }
            return returnValue;
        }

        public bool IsNumberEven(int number)
        {
            bool returnValue = true;
            if (number % 2 != 0)
            {
                returnValue = false;
            }
            return returnValue;
        }

        public bool IsNumberOdd(int num)
        {
            bool returnValue = false;
            if (num % 2 != 0)
            {
                returnValue = true;
            }
            return returnValue;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)/// use for loop
        {
           if (numbers == null || numbers.Count() == 0)
            {
                return 0;
            }
            return numbers.Min() + numbers.Max();


        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length < str2.Length)
            {
                return str1.Length;
            }
            else
            {
                return str2.Length;
            }
        }

        public int Sum(int[] numbers)
        {
            int returnNum = 0;

            if (numbers == null)
            {
                return 0;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                returnNum += numbers[i];
            }

            return returnNum;

        }

        public int SumEvens(int[] numbers)
        {
            int resultNum = 0;

            if (numbers == null)
            {
                return 0;
            }

            foreach (int i in numbers)
                if (i % 2 == 0)
                {
                    resultNum += i;

                }
            return resultNum;

        }

        public bool IsSumOdd(List<int> numbers)
        {
            int resultNum = 0;

            if (numbers == null || numbers.Count() == 0)
            {
                return false;
            }
            
            foreach (int i in numbers)
            {
                resultNum += i;
            }

            if (resultNum % 2 != 0)
            {
                return true;
            }
            return false;

        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            long returnNumber = 0;

            for (long i = number; i > 0; i--)
            {
                if (i % 2==0)
                {
                    returnNumber++;
                } 
            }
            return returnNumber;
        }
    }
}
