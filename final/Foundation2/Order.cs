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

    public double CalculateTotalCost()
    {
        double totalcost = 0;

        foreach (Product p in _products) {
            double price = p.CalculatePrice();
            totalcost += price;
        }

        return totalcost;
    }

    public string GeneratePackingLabel()
    {
        return "";
    }

    public string GenerateShippingLabel()
    {
        return"";
    }
}