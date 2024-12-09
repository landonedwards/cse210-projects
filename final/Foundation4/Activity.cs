public class Activity
{
    private string _activityName;
    private string _date;
    private int _duration;

    // methods

    public Activity(string activityName, string date, int duration)
    {
        _activityName = activityName;
        _date = date;
        _duration = duration;
    }

    public int GetDuration()
    {
        return _duration;
    }
    public virtual double CalculateDistance()
    {
        return 0;
    }
    public virtual double CalculateSpeed()
    {
        return 0;
    }
    public virtual double CalculatePace()
    {
        return 0;
    }
    public string GetSummary()
    {
        return $"{_date} {_activityName} ({_duration} min) - Distance: {CalculateDistance():F2} mile(s), Speed: {CalculateSpeed():F2} mph, Pace: {CalculatePace():F2} min per mile";
    }
}