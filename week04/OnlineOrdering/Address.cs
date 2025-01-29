using System.Net.Sockets;

public class Adress()
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country)
    {

    }

    public string DisplayLocation()
    {
        return _street;
        return _city;
        return _state;
        return _country;
    }

    public string GetCountry()
    {
        return _country;
    }

    public bool UsaOrNot()
    {
        if (GetCountry() == "USA")
        {
            return true;
        } 

        else 
        {
            return false;
        }
    }
}