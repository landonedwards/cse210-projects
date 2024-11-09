public class ReflectingActivity : Activity
{
    // attributes
    private List<string> _prompts;
    private List<string> _questions;

    // methods
    public ReflectingActivity(): base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.\n\nHow long, in seconds, would you like for your session? ", 20)
    {
        _prompts = new() 
        
        {"Think of a time when you stood up for someone else.", 
        "Think of a time when you did something really difficult.", 
        "Think of a time when you helped someone in need.", 
        "Think of a time when did something truly selfless."};

        _questions = new() 
        
        {"Why was this experience meaningful to you?", 
        "Have you ever done anything like this before?", 
        "How did you get started?", 
        "How did you feel when it was complete?", 
        "What made this time different than other times when you were not as successful?", 
        "What is your favorite thing about this experience?", 
        "What could you learn from this experience that applies to other situations?", 
        "What did you learn about yourself through this experience", 
        "How can you keep this experience in mind in the future?"};
    }

    public void RunReflecting()
    {
        DisplayStart();
        
        string strDuration = Console.ReadLine();
        int duration = int.Parse(strDuration);

        Console.Clear();

        Console.WriteLine("Get ready...");
        Spinner();

        Console.WriteLine("\nConsider the following prompt:");
        Console.WriteLine(GetPrompt());
        Console.WriteLine("\nWhen you have something in mind, please enter to continue.");

        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in:");
        Countdown(5);

        DateTime currentTime = DateTime.Now;
        DateTime futureTime = currentTime.AddSeconds(duration);

        while (currentTime < futureTime)
        {
            Console.Write(GetPromptQuestion());
            Spinner();
            Console.ReadLine();
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

    public string GetPromptQuestion()
    {
        Random questionGenerator = new();
        int questionIndex = questionGenerator.Next(0, _questions.Count);

        string randomQuestion = ">" + _questions[questionIndex];
        return randomQuestion;
    }
}