using System;

class Program
{
    static void Main(string[] args)
    {
        List<Order> orders = new List<Order>();
        List<Product> products = new List<Product>();
        Product product = new Product("Drain Cleaner", "12345", 12, 1);
        products.Add(product);
        product = new Product("Banana", "54321", 2, 5);
        products.Add(product);
        
        Address address = new Address("1825 17th St", "Cody", "WY", "USA");
        Customer customer = new Customer("Bob Tommater", address);
        Order order = new Order(products, customer);

        Console.Clear();
        Console.WriteLine(order.DisplayPackingLabel());
        Console.WriteLine(order.DisplayShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"${order.CalculateTotal()}.00");
        
        products.Clear();
        
        Console.WriteLine("-------------------------------------------------");

        product = new Product("Oatmeal", "09876", 5, 3);
        products.Add(product);
        product = new Product("Hairbrush", "67890", 11, 10);
        products.Add(product);
        product = new Product("Freezer Pizza", "56789", 13, 2);
        products.Add(product);
        
        address = new Address("8882 170 St NW", "Edmonton", "AB", "CAN");
        customer = new Customer("Larry Cucumbi", address);
        order = new Order(products, customer);

        Console.WriteLine(order.DisplayPackingLabel());
        Console.WriteLine(order.DisplayShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"${order.CalculateTotal()}.00");


    }
}