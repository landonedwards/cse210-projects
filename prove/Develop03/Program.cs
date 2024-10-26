using System;
using System.Runtime.CompilerServices;

// I added functionality in the Scripture class's HideWords() behavior so that the program would hide different words each time the user pressed enter. 

class Program
{
    static void Main(string[] args)
    {
        Reference ref1 = new("Matthew", 11, 28, 30);

        Scripture scrip1 = new(ref1, "Come unto me, all ye that labour and are heavy laden, and I will give you rest.\nTake my yoke upon you, and learn of me; for I am meek and lowly in heart: and ye shall find rest unto your souls.\nFor my yoke is easy, and my burden is light.");

        Console.WriteLine(scrip1.GetRenderedText());

        string userInput = "";

        do
        {
            Console.WriteLine("\nPlease enter to continue or type 'quit' to finish:");
            userInput = Console.ReadLine();

            if (userInput != "quit")
            {
                scrip1.HideWords();
                Console.Clear();
                Console.WriteLine(scrip1.GetRenderedText());
            }

            if (scrip1.IsCompletelyHidden())
            {
                Console.WriteLine("All words have been hidden.");
                userInput = "quit";
            }
        }
        while (userInput != "quit");
    }
}