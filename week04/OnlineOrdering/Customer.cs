using System.Net.Sockets;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;    
    }
    public bool CheckCountry()
    {
        return _address.CheckCountry();
    }
    public string GetCustomer()
    {
        return $"{_name}\n{_address.CombineAddress()}";
    }
}