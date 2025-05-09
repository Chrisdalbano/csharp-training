using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.Assignments
/*
 *2- Write a program and ask the user to enter their name.
 * Use an array to reverse the name and then store the result in a new string.
 * Display the reversed name on the console.
 *
 *
 */
{
    public class ReverseName
    {
        public static void runReverseNameProgram()
        {
            Console.WriteLine("Whats ya' name?");
            string nameInput = Console.ReadLine();

            char[] nameCharacters = nameInput.ToCharArray();
            Array.Reverse(nameCharacters);

            string reversedName = new string(nameCharacters);

            Console.WriteLine($"Reversed name: {reversedName}");

        }
    }
}
