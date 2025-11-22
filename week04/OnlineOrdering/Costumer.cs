public class Costumer
{
    private string _name;
    private Address _address;

    public Costumer(string name, Address address)
    {   
        _name = name;
        _address = address;
    }

    public bool LiveUsa()
    {
        return _address.IsUsa();
    }

    public string GetCostumerInfo()
    {
        return $"{_name} {_address.FullAddress()}\n";
    }
}