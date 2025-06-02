using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");

        Assignment assignment1 = new Assignment("Samuel Benneth", "Multiplication");

        Console.WriteLine(assignment1.GetSummary());
    }
}