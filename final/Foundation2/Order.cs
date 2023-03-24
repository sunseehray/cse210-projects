using System;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    public double CalculateTotalPrice()
    {
        double totalprice = 0;

        // calculate price of products
        foreach (Product p in _products) {
            double price = p.CalculatePrice();
            totalprice += price;
        }

        // calculate shipping cost
        double shippingCost = 0;
        if (_customer.isFromUSA() == true) {
            shippingCost = 5;
        } else {
            shippingCost = 35;
        }

        // calculate total price with shipping cost
        totalprice += shippingCost;

        return totalprice;
    }

    public string GeneratePackingLabel()
    {
        string packingLabel = "PACKING LABEL\n";

        foreach (Product p in _products) {
            packingLabel += p.GetName() + " - " + p.GetProductID() + "\n";
        }

        return packingLabel;
    }

    public string GenerateShippingLabel()
    {
        string shippingLabel = "SHIPPING LABEL\n";

        shippingLabel += _customer.GetName() + "\n" + _customer.GenerateAddress();
        
        return shippingLabel;
    }

    public void DisplayResults()
    {
        Console.WriteLine("*");

        string packingLabel = GeneratePackingLabel();
        string shippingLabel = GenerateShippingLabel();
        double totalPrice = CalculateTotalPrice();

        Console.WriteLine(packingLabel);
        Console.WriteLine(shippingLabel);
        Console.WriteLine();
        Console.WriteLine($"Total Cost = ${totalPrice}");

        Console.WriteLine("*");
        Console.WriteLine();

    }
}