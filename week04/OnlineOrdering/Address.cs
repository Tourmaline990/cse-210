public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;
    private bool _isUsa;


    public Address(string city,string state,string country)
    {
        _street = "";
        _city = city;
        _state = state;
        _country = country;
        if (country.ToUpper() == "USA")
        {
            _isUsa = true;
        }
        else
        {
            _isUsa = false;
        }
    }


    public Address(string street,string city,string state,string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
         if (country.ToUpper() == "USA")
        {
            _isUsa = true;
        }
        else
        {
            _isUsa = false;
        }
    }

    public void SetAsIsUsa()
    {
        _isUsa = true;
    }
    public void SetAsIsNotUsa()
    {
        _isUsa = false;
    }
    public bool GetUsa()
    {
        return _isUsa;
    }
    public string DisplayAddress()
    {
        return  $"{_street} {_city}\n {_state} {_country}";
    }
}
