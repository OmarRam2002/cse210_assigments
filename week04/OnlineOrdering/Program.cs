using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        //ORDER #1
        Address address1 = new Address("162 wood ave","SLC","Utah","Guatemala");
        Costumer costumer1 = new Costumer("Omar Ramirez", address1);
        Order order1 = new Order(costumer1);
        Product product1 = new Product("Apple","C4F4F", 0.50, 10);
        Product product2 = new Product("Watermelon","T45Y4", 8.9, 5);
        order1.AddProducts(product1);
        order1.AddProducts(product2);

        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine($"Total: {order1.TotalCost()}");

        //ORDER #2
        Console.WriteLine();
        Address address2 = new Address("1077 Wilson","PC","Utah","Usa");
        Costumer costumer2 = new Costumer("Bianca Moreno", address2);
        Order order2 = new Order(costumer2);
        Product product11 = new Product("Cow","C344F", 100, 10);
        Product product22 = new Product("Chicken","T4HY4", 18.9, 5);
        order2.AddProducts(product11);
        order2.AddProducts(product22);

        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine($"Total: {order2.TotalCost()}");

    }
}