using System;

// this line of code is used to import the system generic library

using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        // this line of code is used to create a list of integers

        List<int> numbers = new List<int>();

        // this line of code is used to request for user's input and store it in a variable

        int userInput = -1;
        string input = ""; // Initialize input to an empty string

        // this line of code is used to loop the program until the user enters 0
        while (userInput != 0)
        {
            Console.Write("Enter a number (0 to stop): ");
            input = Console.ReadLine();
            userInput = int.Parse(input);

            // this line of code is used to add the user's input to the list

            if (userInput != 0)
            {
                numbers.Add(userInput);
            }
        }
        // this line of code is used to display the numbers in the list
        Console.WriteLine("You entered the following numbers:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        // this line of code is used to calculate the sum of the numbers in the list

        int sum = 0;

        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum of the numbers is: {sum}");

        // this line of code is used to calculate the average of the numbers in the list
        double average = (double)sum / numbers.Count;
        Console.WriteLine($"The average of the numbers is: {average}");

        // this line of code is used to find the maximum number in the list
        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The maximum number is: {max}");

        // this line of code is used to find the minimum number in the list
        int min = numbers[0];
        foreach (int number in numbers)
        {
            if (number < min)
            {
                min = number;
            }
        }
        Console.WriteLine($"The minimum number is: {min}");

        // this line of code is used to find the count of numbers in the list
        int count = numbers.Count;
        Console.WriteLine($"The count of numbers is: {count}");
    }
}