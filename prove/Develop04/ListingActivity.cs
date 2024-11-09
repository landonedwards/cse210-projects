using System.Runtime.InteropServices;

public class ListingActivity : Activity
{
    // attributes
    private List<string> _prompts;
    private int _numOfResponses;

    // methods
    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.\n\nHow long, in seconds, would you like for your session? ", 20)
    {
        _prompts = new()

        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        _numOfResponses = 0;
    }

    public void RunListing()
    {
        DisplayStart();

        string strDuration = Console.ReadLine();
        int duration = int.Parse(strDuration);

        Console.Clear();

        Console.WriteLine("Get ready...");
        Spinner(300);
        Console.WriteLine();

        Console.WriteLine("List as many responses as you can to the following prompt:\n");
        Console.WriteLine(GetPrompt());
        Console.Write("\nYou may begin in: ");
        Countdown(5);

        Console.WriteLine();

        DateTime currentTime = DateTime.Now;
        DateTime futureTime = currentTime.AddSeconds(duration);

        while (DateTime.Now < futureTime)
        {
            Console.Write("> ");
            Console.ReadLine();

            _numOfResponses += 1;
        }

        if (_numOfResponses > 10)
        {
            Console.WriteLine("Excellent! You listed more than 10 items!\n");
        }
        else 
        {
            Console.WriteLine($"You listed {_numOfResponses} items!\n");
        }
        
        DisplayEnd(duration);
    }

    public string GetPrompt()
    {
        Random promptGenerator = new();
        int promptIndex = promptGenerator.Next(0, _prompts.Count);

        string randomPrompt = "--- " + _prompts[promptIndex] + " ---";
        return randomPrompt;
    }
}