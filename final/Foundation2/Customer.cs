using System.Net.Sockets;

public class Customer
{
    private string _name;
    private Address _address;

    // methods

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetAddress()
    {
        return _address.GetAddress();
    }

    public bool LivesInUsa()
    {
        return _address.LivesInUsa();
    }
}