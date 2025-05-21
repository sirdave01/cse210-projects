using System;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;

public class Fraction
{

    // This method is used to create the objects of the class

    private int _top;
    private int _bottom;

    // This method is used to create the constructor of the class without arguments/parameters

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // This method is used to create the constructor of the class with WholeNumber argument/parameter

    public Fraction(int WholeNumber)
    {
        _top = WholeNumber;
        _bottom = 1;
    }

    // This method is used to create the constructor of the class with Top and Bottom arguments/parameters

    public Fraction(int Top, int Bottom)
    {
        _top = Top;
        _bottom = Bottom;
    }

    // This method is used to get the Top value of the fraction

    public int GetTop()
    {
        return _top;
    }

    // this method is used to set the Top value of the fraction

    public void SetTop(int Top)
    {
        _top = Top;
    }

    // This method is used to get the bottom value of the fraction

    public int GetBottom()
    {
        return _bottom;
    }

    // this method is used to set the bottom value of the fraction

    public void SetBottom(int Bottom)
    {
        _bottom = Bottom;
    }

    // This method is used to get the fraction value of the fraction

    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    // This method is used to get the decimal value of the fraction
    public double GetDecimalValue()
    {
        if (_bottom == 0)
        {
            throw new DivideByZeroException("Bottom cannot be zero.");
        }
        return (double)_top / _bottom;
    }

    static void Main(string[] args)
    {
        // This method is used to create the objects of the class
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(5);
        Fraction fraction3 = new Fraction(3, 4);

        // This method is used to display the values of the fractions
        Console.WriteLine($"Fraction 1: {fraction1.GetFractionString()}");
        Console.WriteLine($"Fraction 2: {fraction2.GetFractionString()}");
        Console.WriteLine($"Fraction 3: {fraction3.GetFractionString()}");

        // This method is used to display the decimal values of the fractions
        Console.WriteLine($"Decimal value of Fraction 1: {fraction1.GetDecimalValue()}");
        Console.WriteLine($"Decimal value of Fraction 2: {fraction2.GetDecimalValue()}");
        Console.WriteLine($"Decimal value of Fraction 3: {fraction3.GetDecimalValue()}");
    }



}