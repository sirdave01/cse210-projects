using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

// declaring the derived class Rectangle that inherits from Shape

public class Rectangle : Shape
{

    // declaring the width and height fields as private to encapsulate them
    // and providing public methods to get and set the width and height

    private double _width;

    private double _height;

    // declaring the constructor to initialize the color, width, and height fields

    public Rectangle(string color, double width, double height) : base(color)
    {
        _width = width;
        _height = height;
    }

    // declaring the getter and setter methods for the width field

    public double GetWidth()
    {
        return _width;
    }

    public void SetWidth(double width)
    {
        _width = width;
    }

    public double GetHeight()
    {
        return _height;
    }

    public void SetHeight(double height)
    {
        _height = height;
    }

    // overriding the GetArea method to return the area of the rectangle

    public override double GetArea()
    {
        return _width * _height;
    }
}