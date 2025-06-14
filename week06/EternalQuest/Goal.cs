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
    //creating the Goal class as an abstract base class for different types of goals
    //that can override its methods and properties

    public abstract class Goal
    {
        // Properties

        private string _shortName;

        private string _description;

        private int _points;

        //constructor to initialize the properties

        public Goal(string name, string description, int points)
        {
            _shortName = name;
            _description = description;
            _points = points;
        }

        //getters and setters for the properties

        public string ShortName
        {
            get { return _shortName; }
            set { _shortName = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public int Points
        {
            get { return _points; }
            set { _points = value; }
        }

        // Abstract methods to be implemented by derived classes

        public abstract void RecordEvent();

        public abstract bool IsComplete();

        public abstract string GetStringRepresentation();

        // Method to return a string representation of the goal
        public override string ToString()
        {
            return $"{ShortName} ({Description}) - {Points} points";
        }
    }
}