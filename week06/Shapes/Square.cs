using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

public class Square : Shape
{
    // declaring the side field as private to encapsulate it
    // and providing public methods to get and set the side

    private double _side;

    // declaring the constructor to initialize the color and side fields

    public Square(string color, double side) : base(color)
    {
        _side = side;
    }

    // declaring the getter and setter methods for the side field

    public double GetSide()
    {
        return _side;
    }

    public void SetSide(double side)
    {
        _side = side;
    }

    // overriding the GetArea method to return the area of the square
    public override double GetArea()
    {
        return _side * _side;
    }

    // overriding the ToString method to return a string representation of the square

    public override string ToString()
    {
        return $"Square: Color = {GetColor()}, Side = {_side}, Area = {GetArea()}";
    }
}