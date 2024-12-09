using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new();

        Running running = new("", 0, 0);
        activities.Add(running);

        Cycling cycling = new("", 0, 0);
        activities.Add(cycling);

        Swimming swimming = new("", 0, 0);
        activities.Add(swimming);

        foreach (Activity activity in activities)
        {
            activity.GetSummary();
        }
    }
}