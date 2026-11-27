using System;


class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Rexburg", "ID", "USA");
        Customer customer1 = new Customer("Jane Smith", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Wireless Mouse", "P1001", 25.50m, 2));
        order1.AddProduct(new Product("USB-C Cable", "P1002", 9.99m, 3));
        order1.AddProduct(new Product("Laptop Stand", "P1003", 34.00m, 1));
    
        Address address2 = new Address("12 Nicolas street", "Aba", "Abia state", "Nigeria");
        Customer customer2 = new Customer("Peterson Ima", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Clipper", "N1001", 34.98m, 1));
        order2.AddProduct(new Product("Notebook", "N1002", 3.24m,10));
        order2.AddProduct(new Product("Desk Lamp", "N1003", 42.00m, 1));

      
        
        DisplayOrder(order1, 1);
        DisplayOrder(order2, 2);
    }

    static void DisplayOrder(Order order, int number)
    {
        Console.WriteLine($"==== ORDER {number} ====");
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Price: {order.GetTotalPrice():C}");
        Console.WriteLine();
    }
}