using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        //Order 1
        Address address1 = new Address("184 S 6th St", "St. Helens", "Oregon", "USA");
        Customer customer1 = new Customer("Bella Swan", address1);
        Order order1 = new Order(customer1);

        Product product1 = new Product(1, "Brown Contact Lenses", 5.99, 7);
        Product product2 = new Product(2, "Black Layers", 3.99, 2);
        Product product3 = new Product(3, "Sunglasses", 10.20, 5);

        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        //Order 2
        Address address2 = new Address("Batallon de atacama 55", "Copiapo", "Atacama", "Chile");
        Customer customer2 = new Customer("Ivana Sanchez", address2);
        Order order2 = new Order(customer2);

        Product product4 = new Product(4, "Completo", 0.99, 2);
        Product product5 = new Product(5, "Black Short", 10.34, 1);


        order2.AddProduct(product4);
        order2.AddProduct(product5);

        List<Order> orders = new List<Order>
        {
            order1, order2
        };

        foreach (Order order in orders)
        {
            Console.WriteLine("------------- New Order -----------");
            Console.WriteLine(order.PackingLabel());
            Console.WriteLine(order.ShippingLabel());
            Console.WriteLine("");
            Console.WriteLine($"Total: {order.CalculateTotalCost():C2}");
            Console.WriteLine("");
        }

    }
}