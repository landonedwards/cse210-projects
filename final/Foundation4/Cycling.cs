public class Cycling : Activity
{
    private double _speed;

    // methods

    public Cycling(string date, int duration, double speed, string activityName = "Cycling") : base(activityName, date, duration)
    {
        _speed = speed;
    }

    public override double CalculateDistance()
    {
        return _speed * (GetDuration() / 60);
    }
    public override double CalculateSpeed()
    {
        return _speed;
    }
    public override double CalculatePace()
    {
        return 60 / _speed;
    }
}