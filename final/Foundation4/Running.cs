using System.Reflection;

public class Running : Activity
{
    private double _distance;

    // methods

    public Running(string date, int duration, double distance, string activityName = "Running") : base(activityName, date, duration)
    {
        _distance = distance;
    }

    public override double CalculateDistance()
    {
        return _distance;
    }
    public override double CalculateSpeed()
    {
        return (_distance / GetDuration()) * 60;
    }
    public override double CalculatePace()
    {
        return GetDuration() / _distance;
    }
}