using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public double CalculateTotalCost()
    {
        double total = 0;

        foreach (Product product in _products)
        {
            total += product.TotalCost();
        }

        if (_customer.LiveInUsa() == true)
        {
            total += 5;
        }

        else
        {
            total += 35;
        }

        return total;
    }

    public string PackingLabel()
    {
        string packingLabel = "Packing Label: \n";
        foreach (Product product in _products)
        {
            packingLabel += $"Product: {product.GetProductName()} \n";
            packingLabel += $"ID: {product.GetProductId()}\n";
        }

        return packingLabel;
    }

    public string ShippingLabel()
    {
        return $"Name: {_customer.GetName()} \nAddress: {_customer.GetAddress()}";
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
}