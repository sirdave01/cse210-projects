using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Mindfulness
{
    // Class representing a breathing activity in the mindfulness program
    public class BreathingActivity : Activity
    {
        public BreathingActivity(string name, string description, int duration)
            : base("Breathing Activity", "This Activity will help you relax your mind by walking you through breathing in and out", 30)
        {
        }

        //method to display the start message for the breathing activity

        public void StartBreathingActivity()
        {
            Console.WriteLine("Let's begin the breathing exercise.");
            // Additional logic for the breathing activity can be added here
        }

        //method to run the breathing activity

        public void RunBreathingActivity()
        {
            StartBreathingActivity();
            // Simulate the breathing activity for the specified duration
            System.Threading.Thread.Sleep(GetDuration() * 1000);
            EndBreathingActivity();
        }

        //method to display breathing animation

        public void DisplayBreathingAnimation()
        {
            Console.WriteLine("Breathe in... (4 seconds)");
            System.Threading.Thread.Sleep(4000);
            Console.WriteLine("Hold... (4 seconds)");
            System.Threading.Thread.Sleep(4000);
            Console.WriteLine("Breathe out... (4 seconds)");
            System.Threading.Thread.Sleep(4000);
            Console.WriteLine("Hold... (4 seconds)");
            System.Threading.Thread.Sleep(4000);
            Console.WriteLine("Repeat the cycle as needed.");
        }

        //method to display the end message for the breathing activity

        public void EndBreathingActivity()
        {
            Console.WriteLine("Thank you for participating in the breathing activity.");
            Console.WriteLine("Remember to take deep breaths throughout your day.");
            Console.WriteLine($"You completed the {GetActivityName()} activity for {GetDuration()} seconds.");
        }
    }
}
