public class EternalGoal : Goal
{
    // no unique variables

    // methods
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    public override int RecordEvent()
    {
        Console.WriteLine($"Congratulations! You have earned {_points} points!");
        return _points;
    }

    // public override Goal CreateGoal(string goalType, string goalDescription, int goalPoints)
    // {
    //     return new EternalGoal(goalType, goalDescription, goalPoints);
    // }

    public override bool IsComplete()
    {
        return false;
    }

    public override string FormatGoal()
    {
        return $"EternalGoal:{_name},{_description},{_points},{IsComplete()}";
    }

}