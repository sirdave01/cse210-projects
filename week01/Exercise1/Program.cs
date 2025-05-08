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
        // this statement used console.write to avoid breaking into a newline for response
        // We also use camel casing for the variable names
        // you don't write the question in a readline method, you write it in a write method

        Console.Write("What is your name? ");
        string firstName = Console.ReadLine();

        Console.Write("what is your last name? ");
        string lastName = Console.ReadLine();

        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}