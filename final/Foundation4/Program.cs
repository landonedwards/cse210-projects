using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new();

        Running running = new("06 Dec 2024", 25, 3.1);
        activities.Add(running);

        Cycling cycling = new("07 Dec 2024", 35, 15);
        activities.Add(cycling);

        Swimming swimming = new("08 Dec 2024", 55, 40);
        activities.Add(swimming);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
        }
    }
}