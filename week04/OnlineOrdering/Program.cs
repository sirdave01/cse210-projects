using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.\n");

        // This line of code calls the address, product list, customers name, email, phone number, order date, and order id

        Address address1 = new Address("123 Main St", "Springfield", "IL", "62701", "USA");
        Customer customer1 = new Customer("John Doe", address1);
        Order order1 = new Order(customer1, DateTime.Now, "ORD12345");
        order1.AddProduct(new Product("Laptop", "High performance laptop", 999.99m, 2));
        order1.AddProduct(new Product("Mouse", "Wireless mouse", 25.99m, 1));
        order1.AddProduct(new Product("Keyboard", "Mechanical keyboard", 49.99m, 1));

        Console.WriteLine($"Order: {order1}");
        Console.WriteLine($"Customer: {customer1}");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: {order1.GetTotalPrice():C}");

        Address address2 = new Address("456 Elm St", "Shelbyville", "IL", "62565", "Canada");
        Customer customer2 = new Customer("Jane Smith", address2);
        Order order2 = new Order(customer2, DateTime.Now, "ORD67890");
        order2.AddProduct(new Product("Smartphone", "Latest model smartphone", 799.99m, 1));
        order2.AddProduct(new Product("Charger", "Fast charging adapter", 19.99m, 1));
        order2.AddProduct(new Product("Case", "Protective phone case", 15.99m, 1));

        Console.WriteLine($"\nOrder: {order2}");
        Console.WriteLine($"Customer: {customer2}");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: {order2.GetTotalPrice():C}");
        Console.WriteLine("Thank you for using the Online Ordering System!");

    }
}
