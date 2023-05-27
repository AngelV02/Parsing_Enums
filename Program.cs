using System;

namespace Parsing_Enums
{
    class Program
    {
        // Enum for the days of the week
        enum DaysOfWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {
            try
            {
                // Prompt the user to enter the current day of the week
                Console.WriteLine("Enter the current day of the week:");

                // Read the user input
                string userInput = Console.ReadLine();

                // Parse the user input to the enum type
                DaysOfWeek currentDay;
                bool isValidDay = Enum.TryParse(userInput, out currentDay);

                if (isValidDay)
                {
                    // Assign the value to a variable of the enum data type
                    Console.WriteLine("Current day: " + currentDay);
                }
                else
                {
                    // Handle invalid input
                    Console.WriteLine("Please enter an actual day of the week.");
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            // Wait for user input before closing the console window
            Console.ReadLine();
        }
    }
}
