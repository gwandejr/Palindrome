using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string userExitYn = "";
            string userPalinValue = "";
            string userPalinValueRvrs = "";
           
            do
            {
                Console.Write("Welcome to the Palindrome Program: Type 'Y' to continue, or 'N' to exit: ");
                userExitYn = Console.ReadLine();

                if ( userExitYn == "Y" )
                {
                    try
                    {
                        Console.Write("Enter text to see if it’s a palindrome: ");
                        userPalinValue = Console.ReadLine();

                        /* Checks the user input to make sure it's of an acceptable
                        character length*/
                        if ((userPalinValue.Length >= 26) || (userPalinValue.Length < 1))
                        {
                            /* Error handling for missing input or input that's too long */
                            Console.WriteLine("Must input 1 to 25 characters");
                            throw new Exception();
                        }
                    
                        /* Creates a new instance of the Palindrome class */
                        Palindrome clPalin = new Palindrome();

                        /* Calls the string method in the Palindrome class to reverse the user input string */
                        userPalinValueRvrs = clPalin.GetRvrsString(userPalinValue);

                        /* Calls the boolean method in the Palindrome class to compare the user input string
                        with the user input string in reverse.  Based on if the strings match, a message
                        is displayed to the user indicating if their input is a palindrome. */
                        if (clPalin.IsPalindrome(userPalinValue, userPalinValueRvrs) == true)
                        {
                            Console.Write($"{userPalinValue} is a Palindrome");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            continue;
                        }

                        else
                        {
                            Console.Write($"{userPalinValue} is not a Palindrome");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            continue;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("An error has occurred. Start over below.");
                        Console.WriteLine("");
                    }
                }

            } while (userExitYn != "N");

        }
    }
}
