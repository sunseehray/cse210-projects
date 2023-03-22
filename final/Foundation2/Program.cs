using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("ENCAPSULATION");
        Console.WriteLine();

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

        // save products and customer into order
        Order order1 = new Order(productsList1, customer1);
        
        // display method results
        order1.DisplayResults();
        
        // Order 2

        // get address
        Address address2 = new Address("123 Cavalry Drive", "Makati City", "NCR", "Philippines");
        
        // create customer with address
        Customer customer2 = new Customer("Juanita Dela Cruz", address2);
        
        // create list for products
        List<Product> productsList2 = new List<Product>();

        // create products
        Product p2001 = new Product("A4 Ream", "A4500", 15, 7);
        Product p2002 = new Product("Box of 12 Pens", "PT12", 10.00, 1);
        Product p2003 = new Product("2-inch Masking Tape", "SMT-2", 3, 4);

        // save products in productsList
        productsList2.Add(p2001);
        productsList2.Add(p2002);
        productsList2.Add(p2003);
        
        // save products and customer into order
        Order order2 = new Order(productsList2, customer2);
        
        // display method results
        order2.DisplayResults();
       
        // Order 3

        // get address
        Address address3 = new Address("12 Richmond Ave", "Brooklyn", "New York", "USA");
        
        // create customer with address
        Customer customer3 = new Customer("Flor Castleman", address3);
        
        // create list for products
        List<Product> productsList3 = new List<Product>();

        // create products
        Product p3001 = new Product("A4 Ream", "A4500", 15, 25);
        Product p3002 = new Product("1/4 Illustration Board", "IB25", 3, 25);

        // save products in productsList
        productsList3.Add(p3001);
        productsList3.Add(p3002);

        // save products and customer into order
        Order order3 = new Order(productsList3, customer3);

        // display method results
        order3.DisplayResults();

    }
}