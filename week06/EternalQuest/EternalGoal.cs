using System;
using System.ComponentModel;
using System.Drawing;
using System.Formats.Asn1;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;

// This code snippet is part of a C# project that defines a namespace for an application called EternalQuest.
// The namespace encapsulates various classes related to goals in the game, such as Goal, ChecklistGoal, EternalGoal, and SimpleGoal.
// Each class is likely to represent different types of goals that players can achieve in the game.

// creating the namespace
//EternalQuest
// using the namespace keyword to define a namespace

namespace EternalQuest
{
    //calling the eternal goal class that inherits from the Goal class
    // This class represents a goal that can be completed multiple times, earning points each time.

    public class EternalGoal : Goal
    {
        //constructor to initialize the properties of the EternalGoal class
        public EternalGoal(string name, string description, int points) : base(name, description, points)
        {
        }

        // overriding the RecordEvent method from the Goal class
        // This method marks the goal as complete and adds points to the player's score.

        public override void RecordEvent()
        {
            Console.WriteLine($"Goal '{ShortName}' completed! You earned {Points} points.");
        }

        // overriding the IsComplete method from the Goal class
        // This method always returns false for EternalGoal, as it can be completed multiple times.

        public override bool IsComplete()
        {
            return false; // Eternal goals are never complete, they can be completed multiple times.
        }

        // overriding the GetStringRepresentation method from the Goal class
        // This method returns a string representation of the EternalGoal object,
        // including its name, description, points, and completion status.

        public override string GetStringRepresentation()
        {
            return $"{ShortName} ({Description}) -- Points: {Points} (Eternal Goal)";
        }

        // overriding the ToString method from the Goal class
        // This method returns a string representation of the EternalGoal object.

        public override string ToString()
        {
            return $"EternalGoal: {ShortName}, Description: {Description}, Points: {Points}";
        }
    }
}