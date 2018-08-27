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
            while (!int.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Please enter a valid numerical value!");
                Console.WriteLine("Please enter a number: ");
            }
            //Same loop down here that validates user input
            Console.WriteLine("Enter the second number to compare: ");
            while (!int.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Please enter a valid numerical value!");
                Console.WriteLine("Please enter another number to compare: ");
            }


            //Loop to determine sum of numbers added together
            for (; num1 > 0; num1 = num1 / 10)
            {
                sum1 = sum1 + num1 % 10;
            }

            for (; num2 > 0; num2 = num2 / 10)
            {
                sum2 = sum2 + num2 % 10;
            }

            //Comparative operator to determine if the sum of each entered number is true or false
            if (sum1 == sum2)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            //Console.ReadLine();
        }
      
    }
}
