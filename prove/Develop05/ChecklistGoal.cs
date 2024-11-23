using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

public class ChecklistGoal : Goal
{
    private int _completionCount;
    private int _targetCount;
    private int _bonusPoints;
    private bool _bonusAwarded;

    // methods
    
    public ChecklistGoal(string name, string description, int points, int bonusPoints, int targetCount, int completionCount = 0) : base(name, description, points)
    {
        // _completionCount = completionCount;
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
        _bonusAwarded = false;
    }

    public override int RecordEvent()
    {
        _completionCount ++;

        if (!_bonusAwarded && _completionCount >= _targetCount)
        {
            _bonusAwarded = true;
            Console.WriteLine($"Congratulations! You have earned {_bonusPoints} points!");
            return _points + _bonusPoints;
        }

        return _points;
    }

    public override string DisplayGoal()
    {
        return $"{_name} ({_description}) -- Currently completed: {_completionCount}/{_targetCount}";
    }

    // public override Goal CreateGoal(string goalType, string goalDescription, int goalPoints, int completionCount, int targetCount, int bonusPoints)
    // {
    //     return new ChecklistGoal(goalType, goalDescription, goalPoints, completionCount, targetCount, bonusPoints);
    // }

    public override bool IsComplete()
    {
        return _completionCount >= _targetCount;
    }

    public override string FormatGoal()
    {
        return $"ChecklistGoal:{_name},{_description},{_points},{_bonusPoints},{_targetCount},{_completionCount}"; 
    }
}