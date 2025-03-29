using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("John Doe", address1);
        Order order1 = new Order(customer1);

        Product product1 = new Product("Laptop", 101, 1050.25m, 1);
        Product product2 = new Product("Mouse", 102, 25.50m, 2);
        order1.GetProducts().Add(product1);
        order1.GetProducts().Add(product2);

        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: {order1.GetTotalCost()}");

        Address address2 = new Address("15C Douglas Alexander Parade", "Rosedale", "Auckland", "NZ");
        Customer customer2 = new Customer("Jack Johnson", address2);
        Order order2 = new Order(customer2);

        Product product3 = new Product("Smartphone", 201, 799.99m, 1);
        Product product4 = new Product("Headphones", 202, 150.50m, 2);
        Product product5 = new Product("Smartwatch", 204, 199.99m, 1);
        order2.GetProducts().Add(product3);
        order2.GetProducts().Add(product4);
        order2.GetProducts().Add(product5);

        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: {order2.GetTotalCost()}");
    }
}