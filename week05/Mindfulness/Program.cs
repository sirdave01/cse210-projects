using System;
using Mindfulness;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");

        BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity", "This Activity will help you relax your mind by walking you through breathing in and out", 30);

        ListingActivity listingActivity = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things life has given and things to improve on", 30);

        ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting Activity", "This activity will help you reflect on the good things you've had in life", 45);

        while (true)
        {
            Console.WriteLine("Welcome to Mindfulness Activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Listing Activity");
            Console.WriteLine("3. Reflecting Activity");
            Console.WriteLine("4. Exit");

            Console.WriteLine("Please, choose an activity:");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("How long would you like to do the breathing activity? (in seconds)");
                    Console.ReadLine();
                    breathingActivity.RunBreathingActivity();
                    breathingActivity.DisplayBreathingAnimation();
                    break;
                case "2":
                    listingActivity.StartListingActivity();
                    listingActivity.DisplayRandomPrompt();
                    // Simulate adding items
                    listingActivity.AddItem("Item 1");
                    listingActivity.AddItem("Item 2");
                    listingActivity.EndListingActivity();
                    break;
                case "3":
                    reflectingActivity.StartReflectingActivity();
                    reflectingActivity.DisplayReflectionQuestion();
                    // Simulate reflection
                    System.Threading.Thread.Sleep(reflectingActivity.GetDuration() * 1000);
                    reflectingActivity.EndReflectingActivity();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }
    }
}