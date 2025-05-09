using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.Assignments
{
    /*
     * 4- Write a program and ask the user to continuously enter a number or type "Quit" to exit.
     * The list of numbers may include duplicates. Display the unique numbers that the user has entered.
     */
    public class AskNumbers
    {
        public static void runAskNumbersProgram()
        {
            List<int> numbers = new List<int>();
            Console.WriteLine("Please enter a number or type 'Quit' to exit");
            while (true)
            {
                var userInput = Console.ReadLine();
                if (userInput.ToLower() != "quit")
                {
                    numbers.Add(Convert.ToInt32(userInput.Trim()));

                }
                else
                {
                    break;
                }

                Console.WriteLine("Your unique numbers are: ");
                foreach (var n in numbers.Distinct())
                {
                    
                    Console.Write($"{Convert.ToString(n)} ");
                }
                Console.WriteLine();
            }


        }
    }
}
