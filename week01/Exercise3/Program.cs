using System;

class Program
{
    static void Main(string[] args)

    // this line of code requests for a user's guess and the magic number
    {

        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        Console.Write("What is the magic number?: ");
        string magicNumber = Console.ReadLine();

        Console.Write("What is your guess?: ");
        string guess = Console.ReadLine();

        int magic = int.Parse(magicNumber);
        int gues = int.Parse(guess);

        // this line of code is used to loop the program until the user guesses the magic number
        while (gues != magic)
        {
            Console.WriteLine("Try again! What is your guess?: ");
            guess = Console.ReadLine();
            gues = int.Parse(guess);
        }

        if (gues == magic)
        {
            Console.WriteLine("You guessed the magic number!");
        }
        else if (gues < magic)
        {
            Console.WriteLine("Your guess is too low.");
        }
        else
        {
            Console.WriteLine("Your guess is too high.");
        }
    }
}