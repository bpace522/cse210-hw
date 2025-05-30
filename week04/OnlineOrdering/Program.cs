using System;

class Program
{
    static void Main(string[] args)
    {
        var address1 = new Address("123 Maple St", "Springfield", "IL", "USA");
        var customer1 = new Customer("Alice Johnson", address1);

        var address2 = new Address("456 Rue de Paris", "Paris", "Île-de-France", "France");
        var customer2 = new Customer("Jean Dupont", address2);

        var order1 = new Order(customer1);
        order1.AddProduct(new Product("Notebook", "N001", 3.50, 5));
        order1.AddProduct(new Product("Pen", "P045", 1.20, 10));

        var order2 = new Order(customer2);
        order2.AddProduct(new Product("Tablet", "T100", 199.99, 1));
        order2.AddProduct(new Product("Stylus", "S200", 29.99, 2));

        List<Order> orders = new List<Order> { order1, order2 };

        foreach (var order in orders)
        {
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total Cost: ${order.CalculateTotalCost():0.00}");
            Console.WriteLine(new string('-', 50));
        }
    }
}