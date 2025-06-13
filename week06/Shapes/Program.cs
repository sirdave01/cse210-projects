using System;
using System.ComponentModel;
using System.Drawing;
using System.Formats.Asn1;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.\n");

        // Create a new Square object with color "Red" and side length 5

        Square square = new Square("Red", 5);

        // Display the color and area of the square

        // Console.WriteLine($"Square Color: {square.GetColor()}");
        // Console.WriteLine($"Square Area: {square.GetArea()}");

        // Create a new Rectangle object with color "Blue", width 4, and height 6

        Rectangle rectangle = new Rectangle("Blue", 4, 6);

        // Display the color and area of the rectangle
        // Console.WriteLine($"\nRectangle Color: {rectangle.GetColor()}");
        // Console.WriteLine($"Rectangle Area: {rectangle.GetArea()}");

        // Create a new Circle object with color "Green" and radius 3

        Circle circle = new Circle("Green", 3);

        // Display the color and area of the circle
        // Console.WriteLine($"\nCircle Color: {circle.GetColor()}");
        // Console.WriteLine($"Circle Area: {circle.GetArea()}\n");

        //create a new list to hold the shapes

        List<Shape> shapes = new List<Shape>();

        //adding circle, rectacngle, square in the shapes list

        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();

            double area = shape.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}\n");
        }

    }
}