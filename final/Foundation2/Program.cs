using System;

class Program
{
    static void Main(string[] args)
    {
        // for order 1
        Address address1 = new("", "", "", "");

        Customer customer1 = new("", address1);

        Product o1product1 = new("", 0, 0, 0);
        Product o1product2 = new("", 0, 0, 0);

        Order order1 = new(customer1);
        order1.AddProduct(o1product1, o1product2);

        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine(order1.CalculateTotalCost());

        // for order 2
        Address address2 = new("", "", "", "");

        Customer customer2 = new("", address1);

        Product o2product1 = new("", 0, 0, 0);
        Product o2product2 = new("", 0, 0, 0);

        Order order2 = new(customer2);
        order2.AddProduct(o2product1, o2product2);

        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine(order2.CalculateTotalCost());
    }
}