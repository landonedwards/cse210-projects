public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private int _zipCode;

    // methods

    public Address(string streetAddress, string city, string state, int zipCode)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _zipCode = zipCode;
    }

    public string GetAddress()
    {
        return $"{_streetAddress}, {_city}, {_state} {_zipCode}";
    }
}