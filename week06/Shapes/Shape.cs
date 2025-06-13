using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

// declaring the base class
public class Shape
{

    // declaring the color field as private to encapsulate it
    // and providing public methods to get and set the color
    private string _color;

    // declaring the constructor to initialize the color field

    public Shape(string color)
    {
        _color = color;
    }

    // declaring the getter and setter methods for the color field
    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    // declaring the virtual method GetArea to be implemented by derived classes
    // this method will return the area of the shape

    public virtual double GetArea()
    {
        return 0.0; // Default implementation, can be overridden by derived classes
    }
}