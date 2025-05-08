using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        // this line of code is my first program that requests for a user's grade percentage

        Console.Write("What is your grade percentage?");

        // this line of code is used to get the user's input and store it in a variable called userInput

        string userInput = Console.ReadLine();

        // this line of code changes a string to an integer

        int studentGrade = int.Parse(userInput);

        // this line of code  is to create a variable called letter to store the letter grade

        string letter = "";

        // this line of code is used to check the user's grade percentage and print the corresponding letter grade

        // this line of code is the core part of the assignment, it checks the user's grade percentage and prints the corresponding letter grade

        if (studentGrade >= 90)
        {
            letter = "A";
            // Console.WriteLine("You got an A.");
        }
        else if (studentGrade >= 80)
        {
            letter = "B";
            // Console.WriteLine("You got a B.");
        }
        else if (studentGrade >= 70)
        {
            letter = "C";
            // Console.WriteLine("You got a C.");
        }
        else if (studentGrade >= 60)
        {
            letter = "D";
            // Console.WriteLine("You got a D.");
        }
        else
        {
            letter = "F";
            // Console.WriteLine("You got an F.");
        }

        // this line of code is used to print the user's letter grade only

        Console.WriteLine($"Your letter grade is {letter}.");

        // this line of code is used to check if the user passed or failed the course
        // this line of code is the core part of the assignment bullet 2, it checks the user's grade percentage and prints if they passed or failed the course

        if (studentGrade >= 70)
        {
            Console.WriteLine("You passed the course.");
        }
        else
        {
            Console.WriteLine("You failed the course.");
        }

    }
}