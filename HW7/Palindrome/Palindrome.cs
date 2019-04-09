using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    public class Palindrome
    {
        /* Method takes a string and returns the string in reverse
        e.g., ball results in llab */
        public string GetRvrsString(string inputString)
        {
            try
            {
                string userStr = inputString;

                /* Takes a string and converts it into a character array
                e.g., "ball" results in [b, a, l, l] */
                char[] userStrChars = userStr.ToCharArray();

                char[] resultChar = new char[userStrChars.Length];
                string charString = "";
                int arrayIndex = 0;

                /* Takes a character array and iterates one character at a time in reverse
                into a new character array e.g, [b, a, l, l] results in [l, l, a, b] */
                for (int counter = userStrChars.Length - 1; counter > -1; counter--)
                {
                    resultChar[arrayIndex] = userStrChars[counter];
                    arrayIndex++;
                }
                /* Takes the new reverse character array and converts it to a string
                e.g, [l, l, a, b] results in "llab" */
                charString = new string(resultChar);
                return charString;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error has occurred. Please contact the System Administrator.");
                return null;
            }
        }

        /* Method compares two strings and returns a boolean if they match */
        public bool IsPalindrome(string string1, string string2)
        {
            try
            {
                string userString1 = string1;
                string userString2 = string2;

            
                if (userString1 == userString2)
                {
                    return true;
                }

                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error has occurred. Please contact the System Administrator.");
                return false;
            }
        }
    }
}
