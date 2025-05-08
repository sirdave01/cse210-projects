// This statement is Used to indicate that we are using the system files
using System;

// This statement is used to indicate that we are using the program class
class Program
{

    // this statement is used to indicate that we are using the main method
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise1 Project.");

        // this statement is my first program that requests for a user's name and last name

        Console.Write("What is your name? ");
        string firstName = Console.ReadLine();

        Console.Write("what is your last name? ");
        string lastName = Console.ReadLine();

        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}