// Order.cs
using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetTotalPrice()
    {
        double total = 0;
        foreach (var product in _products)
        {
            total += product.GetTotalCost();
        }
        total += _customer.LivesInUSA() ? 5 : 35; // Shipping cost
        return total;
    }

    public string GetPackingLabel()
    {
        string label = "Packing List:\n";
        foreach (var product in _products)
        {
            label += "- " + product.GetPackingLabel() + "\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return "Shipping To:\n" + _customer.GetShippingLabel();
    }
}
