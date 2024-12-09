public class OutdoorGathering : Event
{
    private string _weatherConditions;

    // methods

    public OutdoorGathering(string title, string type, string description, string date, string time, Address address, string weatherConditions) : base(title, type, description, date, time, address)
    {
        _weatherConditions = weatherConditions;
    }

    public override string FullMessage()
    {
        return base.StandardMessage() + $"Weather Forecast: {_weatherConditions}";
    }
}