using System;
using System.Diagnostics.Tracing;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        // Console.Write("What is the magic number? ");
        // string mNumber = Console.ReadLine();
        // int magicNumber = int.Parse(mNumber);

        int userGuess = -1;

        while (userGuess != magicNumber)
        {
            Console.Write("What is your guess? ");
            string mGuess = Console.ReadLine();
            userGuess = int.Parse(mGuess);

            if (userGuess > magicNumber)
            {
                Console.WriteLine("Try lower");
            }

            else if (userGuess < magicNumber)
            {
                Console.WriteLine("Try higher");
            }

            else
            {
                Console.WriteLine("You guessed it!");
            }
        }

    }
}