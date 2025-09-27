using System;

public class Product
{
    private int _productId;
    private string _productName;
    private double _price;
    private int _quantity;

    public Product(int productId, string productName, double price, int quantity)
    {
        _productId = productId;
        _productName = productName;
        _price = price;
        _quantity = quantity;
    }

    public double TotalCost()
    {
        return _price * _quantity; ;
    }

    public int GetProductId()
    {
        return _productId;
    }

    public string GetProductName()
    {
        return _productName;
    }
}