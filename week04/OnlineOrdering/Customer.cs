public class Customer
{
    string _firstName;
    string _lastName;
    Address _address;
    bool _inUsa;

    public Customer(string first, string last, Address address)
    {
        _firstName = first;
        _lastName = last;
        _address = address;

    }

    public string GetShippingInfo()
    {
        return $"{_firstName} {_lastName}\n{_address.GetShippingAddress()}";
    }

    public bool LiveInUsa()
    {
        _inUsa = _address.InUSA();
        return _inUsa;

    }
}