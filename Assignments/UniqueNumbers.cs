using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.Assignments
{
    internal class UniqueNumbers
    {
        /*
         * 3- Write a program and ask the user to enter 5 numbers.
         * If a number has been previously entered, display an error message and ask the user to re-try.
         * Once the user successfully enters 5 unique numbers, sort them and display the result on the console.
         */
        public static void runUniqueNumbersProgram()
        {
            List<int> numbersList = new List<int>();
            int uniqueNumbers = 5;
            int count = 0;
            Console.WriteLine($"Provide {uniqueNumbers} unique numbers.");

            while (count < uniqueNumbers)
            {
                int userNumber = Convert.ToInt32(Console.ReadLine());
                if (numbersList.IndexOf(userNumber) == -1)
                {
                    numbersList.Add(userNumber);
                }
                else
                {
                    Console.WriteLine("Number already entered. Try again");
                    count--;
                }

                count++;
            }

            numbersList.Sort();
            foreach (var n in numbersList)
            {
                Console.Write($"{n} ");
            }
        }
    }
}
