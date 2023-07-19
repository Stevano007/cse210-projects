using System;

class Program
{
    static void Main(string[] args)
    {
       Address customer1Address = new Address("12 Ocean Drive", "Miami", "Florida", "USA");
       Address customer2Address = new Address("Omojuwa Estate", "Lagos", "Lagos State", "Nigeria");


        // Create customers
        Customer customer1 = new Customer("Mark Angel", customer1Address);
        Customer customer2 = new Customer("Samuel", customer2Address);

        // Create products
        Products product1 = new Products("Chicken Breast", 1101, 10.99, 2);
        Products product2 = new Products("FireCracker", 1104, 9.40, 1);
        Products product3 = new Products("Tampons", 1106, 9.99, 5);
        Products product4 = new Products("Salt", 1105, 0.99, 2);
        Products product5 = new Products("Milk", 1109, 5.34, 2);
        Products product6 = new Products("Tissue Paper", 1129, 3.00, 1);
        
        List<Order> orders = new List<Order>();
      // Create Orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product3);
        order1.AddProduct(product2);
        order1.AddProduct(product1);
        orders.Add(order1);

        Order order2 = new Order(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);
        order2.AddProduct(product6);
        orders.Add(order2);


        foreach(Order order in orders){
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order.PackingLabel());
        Console.WriteLine();

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order.ShippingLabel());
        Console.WriteLine();
        Console.WriteLine("Total Cost:"); 
        Console.WriteLine(order.CalculateTotalCost());
        Console.WriteLine();
        }


    }
}