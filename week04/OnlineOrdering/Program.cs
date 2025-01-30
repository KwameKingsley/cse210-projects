using System;

class Program
{
    static void Main()
    {
        // Create Addresses
        Address address1 = new Address("123 Elm St", "New York", "NY", "USA");
        Address address2 = new Address("435 Maple Rd", "Toronto", "ON", "Canada");

        // Create Customers
        Customer customer1 = new Customer("Kingsley Kwarteng", address1);
        Customer customer2 = new Customer("Grace Fowah", address2);

        // Create Orders
        Order order1 = new Order(customer1);
        Order order2 = new Order(customer2);

        // Create Products
        Product product1 = new Product("Laptop", "L123", 800, 1);
        Product product2 = new Product("Mouse", "M456", 20, 2);
        Product product3 = new Product("Keyboard", "K789", 50, 1);

        Product product4 = new Product("Book", "B101", 15, 3);
        Product product5 = new Product("Pen", "P202", 2, 10);

        // Add products to orders
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        order2.AddProduct(product4);
        order2.AddProduct(product5);

        // Display order details
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():0.00}\n");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():0.00}");
    }
}