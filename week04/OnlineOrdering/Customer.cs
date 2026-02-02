public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
 
    
    public bool ValidateUsa()
    {
        return _address.GetUsa();
    }
    
    public void SetCustomeName(string name)
    {
        _name = name;
    }
    public string GetCustomerName()
    {
        return _name;
    }
    public string GetAddress()
    {
       return _address.DisplayAddress();
    }
    public void SetAddress(Address newAddress)
    {
        _address = newAddress;
    }
    
}