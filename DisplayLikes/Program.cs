using System;
using System.Collections.Generic;

namespace FacebookLikes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();

            // Continuously ask the user to enter names until Enter is pressed
            while (true)
            {
                Console.WriteLine("Enter a name (or press Enter to finish):");
                string input = Console.ReadLine();

                // If user presses Enter without entering a name, break the loop
                if (string.IsNullOrWhiteSpace(input))
                {
                    break;
                }

                names.Add(input);
            }

            // Display message based on the number of names entered
            DisplayMessage(names);
        }

        static void DisplayMessage(List<string> names)
        {
            switch (names.Count)
            {
                case 0:
                    // If no names are entered, do nothing
                    break;
                case 1:
                    Console.WriteLine($"{names[0]} likes your post.");
                    break;
                case 2:
                    Console.WriteLine($"{names[0]} and {names[1]} like your post.");
                    break;
                default:
                    int otherCount = names.Count - 2;
                    Console.WriteLine($"{names[0]}, {names[1]} and {otherCount} others like your post.");
                    break;
            }
        }
    }
}
