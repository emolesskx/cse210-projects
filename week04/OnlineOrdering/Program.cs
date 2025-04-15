using System;

class Program
{
    static void Main()
    {
        // First order - USA customer
        Address address1 = new Address("100 Elm St", "Phoenix", "AZ", "USA");
        Customer customer1 = new Customer("Tonderayi Tafi", address1);
        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Keyboard", "K100", 49.99, 1));
        order1.AddProduct(new Product("Monitor", "M200", 199.99, 1));
        order1.AddProduct(new Product("USB Cable", "U300", 9.99, 2));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice():0.00}\n");

        // Second order - International customer
        Address address2 = new Address("243 Samora Machel Ave", "Harare", "HRE", "Zimbabwe");
        Customer customer2 = new Customer("Kacey Tafi", address2);
        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("Tablet", "T400", 299.99, 1));
        order2.AddProduct(new Product("Stylus Pen", "S500", 39.99, 1));

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice():0.00}");
    }
}
