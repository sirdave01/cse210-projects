using System;

class Program
{
    static void Main(string[] args)
    {
        // these lines of code are used to declare the variables as global variables to be used anywhere in the program

        DisplayWelcome(); // Call the method to display the message

        string UserName = PromptUserName(); // Call the method to get the user's name

        int UserNumber = PromptUserNumber(); // Call the method to get the user's number

        int SquaresNumber = SquareNumber(UserNumber); // Call the method to square the number

        DisplayResult(UserName, SquaresNumber); // Call the method to display the result


        // this line of code is used to create a method that displays a message

    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
    }
    // this line of code is used to create a method that prompts the user for their name 
    static string PromptUserName()
    {
        Console.Write("What is your name? ");
        string fName = Console.ReadLine();
        return fName;
    }
    // this line of code is used to create a method that prompts the user for their number
    static int PromptUserNumber()
    {
        Console.Write("What is your number? ");
        string number = Console.ReadLine();
        int userNumber = int.Parse(number);
        return userNumber;
    }
    // this line of code is used to create a method that squares the user's number
    static int SquareNumber(int number)
    {
        return number * number;
    }
    // this line of code is used to create a method that displays the result
    static void DisplayResult(string fName, int result)
    {
        Console.WriteLine($"Your name is {fName} and the result is {result}");
    }
}