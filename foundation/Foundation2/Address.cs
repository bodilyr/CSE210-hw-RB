public class Address
{
    //member variables
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _country;

    //constructor to assign parameter values
    public Address(string streetAddress, string city, string stateProvince, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }

    //method to return true/false whether address is located in the USA or not
    public bool IsInUSA()
    {
        return _country.ToUpper() == "USA";
    }
    
    //method to return a string of all fields together (use newline characters where appropriate)
    public string GetAddress()
    {
        return $"{_streetAddress}\n{_city}, {_stateProvince}\n{_country}";
    }
}