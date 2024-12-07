public class Customer
{
    //member variables
    private string _name;
    private Address _address;

    //constructor to assign parameter values
    public Customer(string name, Address address)
    {
        _name = name;
       _address = address;
    }

    //method that returns true/false if they live in USA or not
    public bool IsInUSA()
    {
        return _address.IsInUSA();
    }

    //getters for name and address variables
    public Address GetAddress()
    {
        return _address;
    }

    public string GetName()
    {
        return _name;
    }
}