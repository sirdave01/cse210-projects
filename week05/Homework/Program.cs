using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");

        Assignment assignment1 = new Assignment("Samuel Benneth", "Multiplication");

        Assignment assignment2 = new Assignment("Roberto Rodriguez", "Fractions");
        MathAssignment mathAssignment2 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");

        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(mathAssignment2.GetHomeworkList());
    }
}