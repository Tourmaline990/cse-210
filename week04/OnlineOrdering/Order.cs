public class Order
{
    private  Customer _customer;
    private List<Product> _products = new List<Product>();

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void Addproduct(Product product)
    {
        _products.Add(product);
    }
    
    public decimal OrderCost()
    {
        
        decimal amount = 0;
        if (_customer.ValidateUsa())
        {
            amount = 5;
        }
        else
        {
            amount = 35;
        }
        foreach (Product item in _products)
        {
            amount += item.TotalCost();
        }
        return amount;
    }
    public string GetPackingLabel()
    {
        string label = "";
        foreach (Product item in _products)
        {
           label += $"{item.GetProductName()} - {item.GetProductId()}\n" ;
            
        }
        return label;
    }
    public string GetShippingLabel()
    {
       
        return $"{_customer.GetCustomerName()} - {_customer.GetAddress()}";
    }
    
}