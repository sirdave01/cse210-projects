using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

public class Product
{
    private string _name;

    private decimal _price;

    private int _quantity;

    private string _productId;

    // constructors to call the private variables

    public Product(string name, string productId, decimal price, int quantity)
    {
        _name = name;
        _price = price;
        _quantity = quantity;
        _productId = productId;
    }

    // getters and setters for the private variables

    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public decimal GetPrice()
    {
        return _price;
    }

    public void SetPrice(decimal price)
    {
        _price = price;
    }

    public int GetQuantity()
    {
        return _quantity;
    }

    public void SetQuantity(int quantity)
    {
        _quantity = quantity;
    }

    public string GetProductId()
    {
        return _productId;
    }

    public void SetProductId(string productId)
    {
        _productId = productId;
    }

    // this line of code computes the total price of the product byt the quantity

    public decimal CalculateTotalPrice()
    {
        return _price * _quantity;
    }

    // this line of code returns a string representation of the product
    public override string ToString()
    {
        return $"{_name} (ID: {_productId}) - Price: {_price:C}, Quantity: {_quantity}, Total: {CalculateTotalPrice():C}";
    }
}