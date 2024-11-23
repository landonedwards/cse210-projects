using System.Diagnostics.Tracing;

public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;

    // methods

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public abstract int RecordEvent();

    // public abstract Goal CreateGoal(string goalDescription, int goalPoints);

    public virtual string DisplayGoal()
    {
        return $"{_name} ({_description})";
    }

    public abstract bool IsComplete();

    public abstract string FormatGoal();
}