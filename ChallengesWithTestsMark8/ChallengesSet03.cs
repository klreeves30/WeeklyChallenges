using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            bool containsFalse = false;
            for (int i = 0; i < vals.Length; i++)
            {
                if (vals[i] == false)
                {
                    containsFalse = true;
                    
                }

               
            }
            return containsFalse;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if(numbers == null)
            {
                return false;
            }
            if (numbers.Sum() % 2 != 0)
            {
                return true;
            }
            return false;
        }


        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            var isLower = false;
            var isUpper = false;
            var isNumber = false;

            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsLower(password[i]))
                {
                    isLower = true;
                }
                if (char.IsUpper(password[i]))
                {
                    isLower = true;
                }
                if (char.IsNumber(password[i]))
                {
                    isLower = true;
                }
            }
            if(isLower == true && isUpper == true && isNumber == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public char GetFirstLetterOfString(string val)
        {
            //return val[0]; -- either on will work

            var first = val.FirstOrDefault();
            return first;
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];

            ///return val.Last(); --- refactored
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if(divisor == 0)
            {
                return 0;
            }

            return dividend / divisor;
            
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];

            ///return nums.Last() - nums.First(); -- refactor
        }

        public int[] GetOddsBelow100()
        {
            var oddList = new List<int>();

            for (int i = 0; i < 100; i++)
            {
                if(i % 2 != 0)
                {
                    oddList.Add(i);
                }
            }

            return oddList.ToArray();
            
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();

            }
        }
    }
}
