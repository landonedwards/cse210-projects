using System.Diagnostics;

public class Lecture : Event
{
    private string _speaker;
    private int _maxCapacity;

    // methods

    public Lecture(string title, string type, string description, string date, string time, Address address, string speaker, int maxCapacity) : base(title, type, description, date, time, address)
    {
        _speaker = speaker;
        _maxCapacity = maxCapacity;
    }

    public override string FullMessage()
    {
        return base.FullMessage() + $"\nSpeaker: {_speaker}\nCapacity: {_maxCapacity} attendees";
    }
}