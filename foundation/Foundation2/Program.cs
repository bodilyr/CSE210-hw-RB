using System;

class Program
{
    static void Main(string[] args)
    {
        
        //creation of addresses
        Address address1 = new Address("911 Emergency Avenue", "Hermosillo", "Sonora", "Mexico");
        Address address2 = new Address("1423 Larsen Rd", "Weiser", "ID", "USA");

        //creation of customers
        Customer customer1 = new Customer("Hugh Adams", address1);
        Customer customer2 = new Customer("Leah Turner", address2);

        //creation of products [had a hard time figuring out the decimal number and how to make it work using the m to identify it as a decimal literal]
        Product product1 = new Product("Timex Watch", "T362x", 56.99m, 1);
        Product product2 = new Product("Dazzle Nail Polish", "D48", 8.75m, 3);
        Product product3 = new Product("Blow Dryer", "S921BD", 87.00m, 1);

        //creation of Order objects
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product3);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

//method to display orders [packing, shipping labels, total price]
    static void DisplayOrderDetails(Order order)
    {
        Console.WriteLine("\nOrder Details:\n");
        Console.WriteLine("Packing List:");
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Total Price: ${order.GetTotalCost()}");
        Console.WriteLine();
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine();
    }

        //display results of methods
        DisplayOrderDetails(order1);
        DisplayOrderDetails(order2);

    }
}