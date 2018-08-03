using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            //All variables declared at the top
            string userInputOne, userInputTwo;
            int[] inputArrayOne, inputArrayTwo;
            bool equalCheck;

            //Prompts the user for input.
            Console.WriteLine("Please enter a positive whole number: ");
            userInputOne = Console.ReadLine();
            //Calls the method to check for correct formatting.
            while (WholePositiveNumberCheck(userInputOne) == false)
            {
                //if the format it incorrect, the variable is reassigned to the new input.
                Console.WriteLine("Please make sure the number is a positive whole number. Try again: ");
                userInputOne = Console.ReadLine();
            }
            //Converts string value directly to an integer array.
            inputArrayOne = ToNumberArray(userInputOne);

            //Asks for second input, specifying number of digits to provide
            Console.WriteLine("Please enter another number with the same number of digits (in this case, {0} digits): ", inputArrayOne.Length);
            userInputTwo = Console.ReadLine();
            //Again, checks that 2nd input is in the correct format.
            while (WholePositiveNumberCheck(userInputTwo) == false)
            {
                //if incorrect, continues to loop until correct format is provided. Reassigns variable.
                Console.WriteLine("That format was incorrect, please try again: ");
                userInputTwo = Console.ReadLine();
            }
            //Converts second input from a string directly to an integer array.
            inputArrayTwo = ToNumberArray(userInputTwo);
            //Checks that the number of digits in each number is equal.
            while (inputArrayOne.Length != inputArrayTwo.Length)
            {
                //While they are not equal, user is prompted to try again. Variable and array are reassigned.
                Console.WriteLine("The second number must have {0} digits, please try again: ", inputArrayOne.Length);
                userInputTwo = Console.ReadLine();
                inputArrayTwo = ToNumberArray(userInputTwo);
            }
            //Calls method to check the sum of each digit, prints result.
            equalCheck = AddDigits(inputArrayOne, inputArrayTwo);
            if (equalCheck == true)
            {
                    Console.WriteLine("True, the sum each digit is equal.");
                    Console.ReadLine();
            }
            else
            {
                    Console.WriteLine("False, the sum each digit is not equal.");
                    Console.ReadLine();
            }


            

        }
        //Checks that a string input is a whole, integer with a value greater than 0.
        private static bool WholePositiveNumberCheck(string userInput)
        {
            if (Int32.TryParse(userInput, out int result) == true && (Int32.Parse(userInput) > 0) == true)
            {
                //This is a whole positive number
                return true;
            }
            else
            {
                //This is not a whole positive number
                return false;
            }

        }
        //Separates each digit from the string input directly into an integer array.
        public static int[] ToNumberArray(string input)
        {

            int[] digits = input.ToString().ToCharArray().Select(Convert.ToInt32).ToArray();
            return digits;

        }
        //Cycles through the array, testing the sum of each digit at the one's place.
        public static bool AddDigits(int[] array1, int[] array2)
        {
            int onesDigit = array1[0] + array2[0];
            for (int i = 1; i < array1.Length; i++)
            {

                if (array1[i] + array2[i] != onesDigit)
                {
                    return false;

                }
            }
            return true;
       
        }
        //I really wanted to experiment with more user options!!!! But it made my code messy
        //and the application became cluttered with options :(.

        //public static string YesOrNo(string yOrN)
         //{
         //    yOrN = Console.ReadLine();
         //    if (yOrN.ToLower() == "y" || yOrN.ToLower() == "yes")
         //    {
         //        //returns yes
         //        Console.WriteLine("Dope! Try another number: ");
         //        return Console.ReadLine();
         //    }
         //    else
         //    {
         //        //exits the app
         //        Environment.Exit(0);
         //    }

    }
}
    