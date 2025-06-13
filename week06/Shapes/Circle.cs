using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

// declaring the derived class Circle that inherits from Shape

public class Circle : Shape
{

    // declaring the radius field as private to encapsulate it
    // and providing public methods to get and set the radius

    private double _radius;

    // declaring the constructor to initialize the color and radius fields

    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }

    // declaring the getter and setter methods for the radius field

    public double GetRadius()
    {
        return _radius;
    }

    public void SetRadius(double radius)
    {
        _radius = radius;
    }

    // overriding the GetArea method to return the area of the circle

    public override double GetArea()
    {
        return Math.PI * _radius * _radius; // Area = πr²
    }
}