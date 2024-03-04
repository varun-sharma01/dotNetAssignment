using System;

namespace StopwatchApp
{
    // Class to simulate a stopwatch
    class Stopwatch
    {
        private DateTime? _startTime;  // Nullable DateTime to store the start time
        private TimeSpan _duration;   // TimeSpan to store the total duration

        // Method to start the stopwatch
        public void Start()
        {
            // Throw an exception if the stopwatch is already running
            if (_startTime != null)
            {
                throw new InvalidOperationException("Stopwatch is already running. Stop it first.");
            }

            _startTime = DateTime.Now; // Record the start time
        }

        // Method to stop the stopwatch
        public void Stop()
        {
            // Throw an exception if the stopwatch is not running
            if (_startTime == null)
            {
                throw new InvalidOperationException("Stopwatch is not running. Start it first.");
            }

            // Calculate the duration and add it to the total duration
            _duration += DateTime.Now - _startTime.Value;
            _startTime = null; // Reset the start time
        }

        // Method to get the total duration of the stopwatch
        public TimeSpan GetDuration()
        {
            return _duration; // Return the total duration
        }
    }

    // Main program class
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch(); // Create a new instance of the Stopwatch class

            while (true)
            {
                // Ask the user to enter a command
                Console.WriteLine("Enter 'start' to start the stopwatch, 'stop' to stop it, or 'quit' to exit:");
                var input = Console.ReadLine(); // Read user input

                // Process the user input
                if (input.ToLower() == "start")
                {
                    try
                    {
                        stopwatch.Start(); // Start the stopwatch
                        Console.WriteLine("Stopwatch started.");
                    }
                    catch (InvalidOperationException e)
                    {
                        Console.WriteLine(e.Message); // Display error message if already started
                    }
                }
                else if (input.ToLower() == "stop")
                {
                    try
                    {
                        stopwatch.Stop(); // Stop the stopwatch
                        Console.WriteLine($"Stopwatch stopped. Duration: {stopwatch.GetDuration()}"); // Display the duration
                    }
                    catch (InvalidOperationException e)
                    {
                        Console.WriteLine(e.Message); // Display error message if not started
                    }
                }
                else if (input.ToLower() == "quit")
                {
                    break; // Exit the loop if user wants to quit
                }
                else
                {
                    Console.WriteLine("Invalid command. Please enter 'start', 'stop', or 'quit'."); // Display message for invalid command
                }
            }
        }
    }
}
