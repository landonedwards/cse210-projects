using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");

        Console.Write("What is your favorite color? ");
        string color = Console.ReadLine();

        if (color == "purple" || color == "Purple")
        {
            Console.WriteLine("Purple is my favorite color too.");
        }

        else
        {
            Console.WriteLine($"{color} is not my favorite.");
        }

    }
}