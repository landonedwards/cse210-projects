public class Swimming : Activity
{
    private int _numOfLaps;

    // methods

    public Swimming(string date, int duration, int numOfLaps, string activityName = "Swimming") : base(activityName, date, duration)
    {
        _numOfLaps = numOfLaps;
    }

    public override double CalculateDistance()
    {
        return _numOfLaps * 50 / 1000 * 0.62;
    }
    public override double CalculateSpeed()
    {
        return (CalculateDistance() / GetDuration()) * 60;
    }
    public override double CalculatePace()
    {
        return GetDuration() / CalculateDistance();
    }
}