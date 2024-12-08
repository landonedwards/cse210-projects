using System;

class Program
{
    static void Main(string[] args)
    {
        // for order 1
        Address address1 = new("10048 Laurel Street", "Figglehorn", "Nebraska", "USA");

        Customer customer1 = new("Fred", address1);

        Product o1product1 = new("Yellow suspenders", 34, 12, 7);
        Product o1product2 = new("Striped yellow shirt", 67, 18, 7);

        Order order1 = new(customer1);
        order1.AddProduct(o1product1, o1product2);

        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost():F2}");
        Console.WriteLine("===============================================\n");

        // // for order 2
        // I know that Wales isn't technically a state or province.
        Address address2 = new("342 Round Table Way", "Camelot", "Wales", "UK");

        Customer customer2 = new("Arthur", address2);

        Product o2product1 = new("Whetstone sword sharpener", 12, 61, 1);
        Product o2product2 = new("White pauldrons", 98, 80, 2);

        Order order2 = new(customer2);
        order2.AddProduct(o2product1, o2product2);

        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine(order2.PackingLabel());

        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost():F2}");
        Console.WriteLine("===============================================");
    }
}