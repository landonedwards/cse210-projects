public class Reception : Event
{
    private string _rsvpEmail;

    // methods
    
    public Reception(string title, string type, string description, string date, string time, Address address, string rsvpEmail) : base(title, type, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }

    public override string FullMessage()
    {
        return base.FullMessage() + $"\nRSVP Email: {_rsvpEmail}";
    }
}