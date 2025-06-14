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
    // creating the SimpleGoal class that inherits from the Goal class
    // This class represents a simple goal that can be achieved in the game.
    // It overrides the ToString method to provide a string representation of the goal.

    public class SimpleGoal : Goal
    {
        // calling the _isComplete field from the Goal class
        private bool _isComplete;

        // constructor to initialize the properties of the SimpleGoal class

        public SimpleGoal(string name, string description, int points) : base(name, description, points)
        {
            _isComplete = false; // initializing the _isComplete field to false
        }

        // overriding the void RecordEvent method from the Goal class
        // This method marks the goal as complete and adds points to the player's score.

        public override void RecordEvent()
        {
            _isComplete = true;
            Console.WriteLine($"Goal '{ShortName}' completed! You earned {Points} points.");
        }

        // overriding the bool IsComplete method from the Goal class
        // This method returns whether the goal is complete or not.

        public override bool IsComplete()
        {
            return _isComplete;
        }

        // overriding the getstringrepresentation method from the Goal class
        // This method returns a string representation of the SimpleGoal object,
        // including its name, description, points, and completion status.

        public override string GetStringRepresentation()
        {
            string status = _isComplete ? "X" : " ";
            return $"{status} {ShortName} ({Description}) -- Points: {Points}";
        }

        // overriding the ToString method to provide a string representation of the SimpleGoal object
        public override string ToString()
        {
            return $"{ShortName} ({Description}) -- Points: {Points} -- Complete: {_isComplete}";
        }
    }
}