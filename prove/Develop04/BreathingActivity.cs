using System.Runtime.CompilerServices;

public class BreathingActivity : Activity
{
    // attributes

    // methods

    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.\n\nHow long, in seconds, would you like your session (please enter at least 10)? ", 20)
    {
    }

    public void RunBreathing()
    {
        DisplayStart();

        string strDuration = Console.ReadLine();
        int duration = int.Parse(strDuration);

        int fullCycles = duration / 10;
        int remainingTime = duration % 10;

        int inhale = 4;
        int exhale = 6;

        int remainingInhale = 0;
        int remainingExhale = 0;

        if (remainingTime > 0)
        {
            remainingInhale = (int)Math.Round(remainingTime * 0.4);
            remainingExhale = (int)Math.Round(remainingTime * 0.6);
        }

        Console.Clear();

        Console.WriteLine("Get ready...");
        Spinner(300);
        Console.WriteLine();

        for (int i = 0; i < fullCycles; i++)
        {
            Console.Write("Breathe in...");
            Countdown(inhale);
            Console.WriteLine();

            Console.Write("Now breathe out...");
            Countdown(exhale);

            Console.WriteLine("\n");
        }

        if (remainingTime > 0)
        {
            Console.Write("Breathe in...");
            Countdown(remainingInhale);
            Console.WriteLine();

            Console.Write("Now breathe out...");
            Countdown(remainingExhale);

            Console.WriteLine("\n");
        }

        DisplayEnd(duration);
    }
}