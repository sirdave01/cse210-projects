using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

public class Customer
{
    // This line of code stores the name of the customer

    private string _name;

    private Address _address;

    // constructors to call the private variables

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
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

    public Address GetAddress()
    {
        return _address;
    }

    public void SetAddress(Address address)
    {
        _address = address;
    }

    // to determine if the customer country is USA

    public bool IsInUSA()
    {
        return _address.GetCountry().Equals("USA", StringComparison.OrdinalIgnoreCase);
    }

    // this line of code returns the details of the customer as a string

    public override string ToString()
    {
        return $"Customer Name: {_name}, Address: {_address.GetStreet()}, {_address.GetCity()}, {_address.GetState()}, {_address.GetZipCode()}, {_address.GetCountry()}";
    }
}