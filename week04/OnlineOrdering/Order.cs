using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

public class Order
{
    // This line of code stores the order id

    private List<Product> _products;
    private Customer _customer;
    private DateTime _orderDate;
    private string _orderId;

    // constructors to call the private variables

    public Order(List<Product> products, Customer customer, DateTime orderDate, string orderId)
    {
        _products = products;
        _customer = customer;
        _orderDate = orderDate;
        _orderId = orderId;
    }

    public Order(Customer customer, DateTime orderDate, string orderId)
    {
        _products = new List<Product>();
        _customer = customer;
        _orderDate = orderDate;
        _orderId = orderId;
    }
    public Order(string orderId)
    {
        _products = new List<Product>();
        _customer = null;
        _orderDate = DateTime.Now;
        _orderId = orderId;
    }

    // getters and setters for the private variables

    public string GetOrderId()
    {
        return _orderId;
    }

    public void SetOrderId(string orderId)
    {
        _orderId = orderId;
    }

    public Customer GetCustomer()
    {
        return _customer;
    }

    public void SetCustomer(Customer customer)
    {
        _customer = customer;
    }

    public DateTime GetOrderDate()
    {
        return _orderDate;
    }

    public void SetOrderDate(DateTime orderDate)
    {
        _orderDate = orderDate;
    }


    // this line of code adds a product to the order

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    // this line of code removes a product from the order

    public void RemoveProduct(Product product)
    {
        _products.Remove(product);
    }

    // this line of code computes the total price of the order by summing the total price of each product

    public decimal GetTotalPrice()
    {
        decimal totalPrice = 0;
        foreach (var product in _products)
        {
            totalPrice += product.GetPrice() * product.GetQuantity();
        }

        decimal shippingCost = _customer.GetAddress().GetCountry() == "USA" ? 5.00m : 35.00m;
        return totalPrice += shippingCost;


    }

    // this line of code returns the packinglabel for the order

    public string GetPackingLabel()
    {

        string label = " ";

        foreach (var product in _products)
        {
            label += $"{product.GetName()} - {product.GetProductId}\n";
        }
        return label;
    }

    // This line of code returns the shipping label for the order

    public string GetShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
    }

    // this line of code return the string representation of the order

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Order ID: {_orderId}");
        sb.AppendLine($"Customer: {_customer.GetName()}");
        sb.AppendLine($"Order Date: {_orderDate.ToShortDateString()}");
        sb.AppendLine("Products:");
        foreach (var product in _products)
        {
            sb.AppendLine($"{product.GetName()} - {product.GetProductId()} - {product.GetPrice():C} x {product.GetQuantity()}");
        }
        return sb.ToString();
    }

}