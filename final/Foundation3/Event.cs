using System.Net.Sockets;

public class Event
{
    private string _title;
    private string _type;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    // methods

    public Event(string title, string type, string description, string date, string time, Address address)
    {
        _title = title;
        _type = type;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string StandardMessage()
    {
        return $"Title: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {_address.GetAddress()}";
    }

    public virtual string FullMessage()
    {
        return $"Type: {_type}\nTitle: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {_address.GetAddress()}";
    }

    public string ShortMessage()
    {
        return $"Type: {_type}\nTitle: {_title}\nDate: {_date}";
    }
}