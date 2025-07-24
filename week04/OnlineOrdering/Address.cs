public class Address
{
    string _street;
    string _city;
    string _state;
    string _country;


    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public string GetShippingAddress()
    {
        return "string";
    }

    public bool InUSA()
    {
        if (_country == "USA")
        {
            return true;

        }

        else
        {
            return false;
        }


    }
}