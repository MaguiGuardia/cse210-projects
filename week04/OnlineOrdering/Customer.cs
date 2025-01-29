using System.Net.Sockets;

public class Customer()
{
    private string _name;
    private Address _address;

    public Customer(string name, AddressFamily address)
    {

    }
    public bool GetLocation()
    {
        if (_address == "USA")
        {
            return true;
        }
        else 
        {
            return false;
        }
    }
    
}