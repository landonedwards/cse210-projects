using System;
using System.Xml.Serialization;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int choice = -99;

        Journal journal = new();

        PromptGenerator promptGenerator = new();
        promptGenerator._prompts = new()
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What are some interesting thoughts I had today?",
            "What word did I use most today?"
        };

        do
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.Write("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit\n");

            string stringChoice = Console.ReadLine();
            choice = int.Parse(stringChoice);

            if (choice == 1)
            {
                string prompt = promptGenerator.GeneratePrompt();
                Console.WriteLine(prompt);

                Console.Write("> ");
                string entry = Console.ReadLine();

                DateTime theCurrentTime = DateTime.Now;
                string date = theCurrentTime.ToShortDateString();

                journal.AddEntry(date, prompt, entry);
            }

            else if (choice == 2)
            {
                journal.DisplayEntries();
            }

            else if (choice == 3)
            {
                Console.WriteLine("Enter the name of the file you want to load:");
                string fileName = Console.ReadLine();

                journal.LoadFile(fileName);
            }

            else if (choice == 4)
            {
                Console.WriteLine("Enter the name of the file you want to save to:");
                string fileName = Console.ReadLine();

                journal.SaveToFile(fileName);
            }
        }
        while (choice != 5);
    }
}