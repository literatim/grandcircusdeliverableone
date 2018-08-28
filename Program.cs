using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace deliverable_one
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers to check if their sums at each place are equal (tens, hundreds, thousands, etc.)");
            Console.WriteLine("--------------------------------------------------------------------------------------------------");
            int num1, num2, sum1 = 0, sum2 = 0;

            Console.WriteLine("Enter the first number : ");
            //First while loop for user validation. If the user enters anything but a number it will continue prompting until a number is entered.
            num1 = GetUserInput();
            Console.WriteLine("Enter the second number to compare: ");
            num2 = GetUserInput();

            //Turn numbers into list of individual digits
            var splitNum1 = SplitNumber(num1);
            var splitNum2 = SplitNumber(num2);

            //exit if the digit counts are different
            if (splitNum1.Count() != splitNum2.Count())
            {
                Console.WriteLine("Number of digits need to be the same. Please try again.");
                return;
            }

            var summedList = new List<int>();

            //put this sum of the individual digits into a list
            for (int i = 0; i < splitNum1.Count(); i++)
            {
                summedList.Add(splitNum1[i] + splitNum2[i]);
            }

            //Compare the sums of the digits and determine if they are all the same
            if (summedList.All(o => o == summedList[0]))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

            Console.ReadLine();
        }

        private static int GetUserInput()
        {
            int input;
            while (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Please enter a valid numerical value!");
                Console.WriteLine("Please enter a number: ");
            }

            return input;
        }

        public static List<int> SplitNumber(int num)
        {
            var numberList = new List<int>();

            //get the number of digits in the number
            var numberCharlength = Math.Floor(Math.Log10(num) + 1);

            var denominator = 1;
            var mod = 10;

            for (int i = 0; i < numberCharlength; i++)
            {
                numberList.Add(num % mod / denominator);
                denominator = denominator * 10;
                mod = mod * 10;
            }

            return numberList;
        }
        
    }

}
