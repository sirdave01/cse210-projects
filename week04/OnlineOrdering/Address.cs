using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

public class Address
{
    // This line of code stores the street address
    private string _street;

    // This line of code stores the city
    private string _city;

    private string _country;

    // This line of code stores the state
    private string _state;

    // This line of code stores the zip code
    private string _zipCode;

    // constructors to call the private variables

    public Address(string street, string city, string state, string zipCode, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _zipCode = zipCode;
        _country = country;
    }

    public Address GetFullAddress()
    {
        return new Address(_street, _city, _state, _zipCode, _country);
    }

    // getters and setters for the private variables

    public string GetStreet()
    {
        return _street;
    }

    public void SetStreet(string street)
    {
        _street = street;
    }

    public string GetCity()
    {
        return _city;
    }

    public void SetCity(string city)
    {
        _city = city;
    }

    public string GetState()
    {
        return _state;
    }

    public void SetState(string state)
    {
        _state = state;
    }

    public string GetZipCode()
    {
        return _zipCode;
    }

    public void SetZipCode(string zipCode)
    {
        _zipCode = zipCode;
    }

    public string GetCountry()
    {
        return _country;
    }

    public void SetCountry(string country)
    {
        _country = country;
    }

    // to identify if country is USA or not

    public bool IsUSA()
    {
        return _country.Equals("USA", StringComparison.OrdinalIgnoreCase);
    }

    // to return the address in a formatted string

    public override string ToString()
    {
        return $"{_street}, {_city}, {_state} {_zipCode}, {_country}";
    }

    // this line of code returns the full address as a string
    public string GetFullAddressString()
    {
        return $"{_street}, {_city}, {_state} {_zipCode}, {_country}";
    }
}