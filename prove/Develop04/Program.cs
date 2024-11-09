using System;
// I added the default case in my main program to ensure the program would continue if the user input a number not associated with any of the menu options. 
class Program
{
    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start reflecting activity");
            Console.WriteLine(" 3. Start listing activity");
            Console.WriteLine(" 4. Quit");

            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.Clear();
                    BreathingActivity breathingActivity = new();
                    breathingActivity.RunBreathing();
                    Console.Clear();
                    break;

                case "2":
                    Console.Clear();
                    ReflectingActivity reflectingActivity = new();
                    reflectingActivity.RunReflecting();
                    Console.Clear();
                    break;

                case "3":
                    Console.Clear();
                    ListingActivity listingActivity = new();
                    listingActivity.RunListing();
                    Console.Clear();
                    break;

                case "4":
                    Console.Clear();
                    Console.WriteLine("Thank you for using the Mindfulness Program.");
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid option. Please choose one of the options included in the menu.\n");
                    break;
            }
        }

    }
}