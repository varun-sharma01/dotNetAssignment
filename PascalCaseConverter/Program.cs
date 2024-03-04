using System;

namespace PascalCaseVariableName
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user to enter a words separated by a space
            Console.WriteLine("Enter a words separated by a space:");
            string inputVar = Console.ReadLine();

            // Convert the input to lowercase and split it into an array of words
            string[] words = inputVar.ToLower().Split(' ');

            // Convert the words to PascalCase
            string variableName = ToPascalCase(words);

            // Display the variable name in PascalCase
            Console.WriteLine($"PascalCase Variable: {variableName}");
        }

        // Method to convert an array of words to PascalCase
        static string ToPascalCase(string[] words)
        {
            // Initialize an empty string to hold the result
            string result = "";

            // Iterate through each word in the array
            foreach (string word in words)
            {
                // Capitalize the first letter of the word and append the rest of the word
                result += char.ToUpper(word[0]) + word.Substring(1);
            }

            // Return the final variable name in PascalCase
            return result;
        }
    }
}
