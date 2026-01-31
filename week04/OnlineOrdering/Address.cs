public class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    public Address(string streetAdress, string city, string stateOrProvince, string country)
    {
        _streetAddress = streetAdress;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
    }

    public bool CheckCountry()
    {
        if(_country == "USA")
        {
            return true;
        }
        return false; 
    }

    public string CombineAddress()
    {
        return $"{_streetAddress}\n{_city}, {_stateOrProvince}, {_country}";
    }
}