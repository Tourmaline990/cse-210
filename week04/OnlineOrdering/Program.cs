using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        Address address = new Address("Jakande","Ajah","Lagos","Nigeria");

        Customer customer = new Customer("Aliya",address);

        Product product = new Product("Gas","A152",320, 2);
        Product product1 = new Product("Water","A134",320.00m, 2);
        Product product2 = new Product("Matchstick","A157",214.32m, 2);

        Order order = new Order(customer);
        order.Addproduct(product);
        order.Addproduct(product1);
        order.Addproduct(product2);
        
        Console.WriteLine("Total Order Cost.....");
        Console.WriteLine($"${order.OrderCost()}");
        Console.WriteLine("Packing Label.....");
        Console.WriteLine($"{order.GetPackingLabel()}");
         Console.WriteLine("Shipping Label.....");
        Console.WriteLine($"{order.GetShippingLabel()}");


    }
}