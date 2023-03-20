using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("ENCAPSULATION");

        // Order 1

        // get address
        Address address1 = new Address("123 Street", "New York City", "New York", "USA");
        
        // create customer with address
        Customer customer1 = new Customer("Alice N. Wonderland", address1);
        
        // create list for products
        List<Product> productsList1 = new List<Product>();

        // create products
        Product p1001 = new Product("Steel Tape", "ST200", 22.50, 1);
        Product p1002 = new Product("18-inch Ruler", "RUL18", 10.00, 3);
        Product p1003 = new Product("PVC Glue 200ml", "PVCG200", 20, 5);

        // save products in productsList
        productsList1.Add(p1001);
        productsList1.Add(p1002);
        productsList1.Add(p1003);
        
        Order order1 = new Order(productsList1, customer1);
        string packingLabel = order1.GeneratePackingLabel();
        string shippingLabel = order1.GenerateShippingLabel();
        double totalPrice = order1.CalculateTotalPrice();

        Console.WriteLine(packingLabel);
        Console.WriteLine(shippingLabel);
        Console.WriteLine($"Total Cost = ${totalPrice}");

    }
}