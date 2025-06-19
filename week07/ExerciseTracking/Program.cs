using System;

//calling the namespace

namespace ExerciseTracking
{
    // creating a class Program to run the application

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! This is the ExerciseTracking Project.");

            // creating the list to hold instances of cycling, running, and swimming activities

            List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2023, 10, 1), 30, 5.0), // 5 km in 30 minutes
            new Cycling(new DateTime(2023, 10, 2), 45, 20.0), // 20 km in 45 minutes
            new Swimming(new DateTime(2023, 10, 3), 60, 40) // 40 laps in 60 minutes
        };

            // iterating through the list of activities and printing their details

            foreach (var activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
            }


        }
    }
}