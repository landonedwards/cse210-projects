public class Activity
{
    // attributes
    private string _activityName;
    private string _activityDescription;
    private int _duration;

    // methods
    public Activity(string activityName, string activityDescription, int duration)
    {
        _activityName = activityName;
        _activityDescription = activityDescription;
        _duration = duration;
    }

    public void DisplayStart()
    {
        Console.Write($"Welcome to the {_activityName}.\n\n{_activityDescription}");
    }

    public void DisplayEnd(int _duration)
    {
        Console.WriteLine("Well done!!");
        Spinner(300);
        Console.WriteLine($"\nYou have completed {_duration} seconds of the {_activityName}.");
        Spinner(300);
    }

    public void Spinner(int milliseconds)
    {
        List<string> animationList = new() { "|", "/", "-", "\\" };

        for (int i = 3; i > 0; i--)
        {
            foreach (string s in animationList)
            {
                Console.Write(s);
                Thread.Sleep(milliseconds);
                Console.Write("\b \b");
            }
        }

    }

    public void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    // public void CompleteActivity()
    // {
    //     _timesCompleted ++;
    // }

    // public int GetTimesCompleted()
    // {
    //     return _timesCompleted;
    // }
}