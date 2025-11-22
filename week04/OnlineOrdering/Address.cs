public class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _country;

    public Address(string streetaddress, string city, string stateprovince, string country)
    {   
        _streetAddress = streetaddress;
        _city = city;
        _stateProvince = stateprovince;
        _country = country;
    }
    public bool IsUsa()
    {
        if (_country.ToLower() == "usa")
        {
            return true;
        }
        else
        {
            return false;
        }  
    }

    public string FullAddress()
    {
        return $"{_streetAddress} {_city} {_stateProvince} {_country}";
    }
}