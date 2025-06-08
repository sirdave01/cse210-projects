using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Mindfulness
{
    // Class representing an activity in the mindfulness program
    public class Activity
    {
        private string _activityName;
        private string _activityDescription;

        private int _duration; // Duration of the activity in seconds

        // Constructor to initialize the activity name and description

        public Activity(string name, string description, int duration)
        {
            _activityName = name;
            _activityDescription = description;
            _duration = duration;
        }

        // getters and setters for the private variables

        public string GetActivityName()
        {
            return _activityName;
        }

        public void SetActivityName(string name)
        {
            _activityName = name;
        }

        public string GetActivityDescription()
        {
            return _activityDescription;
        }

        public void SetActivityDescription(string description)
        {
            _activityDescription = description;
        }

        public int GetDuration()
        {
            return _duration;
        }

        public void SetDuration(int duration)
        {
            _duration = duration;
        }

        //method to display the activity start message

        public void DisplayStartMessage()
        {
            Console.WriteLine($"Starting activity: {_activityName}");
            Console.WriteLine(_activityDescription);
            Console.WriteLine($"Duration: {_duration} seconds");
            Console.WriteLine("Get ready to begin!");
        }

        // Method to display the activity end message

        public void DisplayEndMessage()
        {
            Console.WriteLine($"Activity '{_activityName}' completed!");
            Console.WriteLine($"You spent {_duration} seconds on this activity.");
            Console.WriteLine("Well done!");
        }

        //method to show spinner animation in seconds

        public void ShowSpinner(int seconds)
        {
            Console.Write("Starting in ");
            for (int i = 0; i < seconds; i++)
            {
                Console.Write(".");
                System.Threading.Thread.Sleep(1000); // Sleep for 1 second
            }
            Console.WriteLine();
        }

        // Method to pause the program for a specified duration

        public void Pause(int seconds)
        {
            Console.WriteLine($"Pausing for {seconds} seconds...");
            System.Threading.Thread.Sleep(seconds * 1000); // Sleep for the specified duration in milliseconds
            Console.WriteLine("Resuming activity.");
        }

        // Method to display a countdown timer

        public void Countdown(int seconds)
        {
            Console.WriteLine("Countdown:");
            for (int i = seconds; i > 0; i--)
            {
                Console.Write($"{i} ");
                System.Threading.Thread.Sleep(1000); // Sleep for 1 second
            }
            Console.WriteLine("\nTime's up!");
        }
    }
}