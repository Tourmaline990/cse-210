public class Product
{
    private string _name;
    private string _productId;
    private decimal _price;
    private int _quantity;

    public Product(string name, string Productid, decimal price,int quantity)
    {
        _name = name;
        _productId = Productid;
        _price = price;
        _quantity = quantity;
    }
    public string GetProductName()
    {
        return _name;
    }
    public void SetProductName(string name)
    {
        _name = name;
    }
    public string GetProductId()
    {
        return _productId;
    }
    public void SetProductId(string id)
    {
       _productId = id; 
    }
    public decimal GetProductPrice()
    {
        return _price;
    }
    public void SetProductPrice(decimal price)
    {
        _price = price;
    }
    public int GetQuantity()
    {
        return _quantity;
    }
    public void SetQuantity(int q)
    {
        _quantity = q;
    }
    
    public decimal TotalCost()
    {
        return _price * _quantity;
    }
    

}