public class SimpleGoal : Goal
{
    private bool _isComplete;

    // methods
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public override int RecordEvent()
    {
        _isComplete = true;
        Console.WriteLine($"Congratulations! You have earned {_points} points!");
        return _points;
    }

    // public override Goal CreateGoal(string goalDescription, int goalPoints)
    // {
    //     return new SimpleGoal("Simple Goal", goalDescription, goalPoints);
    // }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string FormatGoal()
    {
        return $"SimpleGoal:{_name},{_description},{_points},{IsComplete()}";
    }

    public void CompleteGoal()
    {
        _isComplete = true;
    }
}

