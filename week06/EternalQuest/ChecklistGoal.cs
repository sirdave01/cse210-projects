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
    //creating the ChecklistGoal class that inherits from the Goal class
    // This class represents a goal that consists of multiple sub-goals, which must all be completed to achieve the main goal.
    // It overrides methods from the Goal class to handle the checklist functionality.

    public class ChecklistGoal : Goal
    {
        //properties

        private int _amountCompleted;

        private int _targetAmount;

        private int _bonusPoints;

        //constructor to initialize the properties of the ChecklistGoal class

        public ChecklistGoal(string name, string description, int points, int targetAmount, int bonusPoints)
            : base(name, description, points)
        {
            name = "Checklist Goal"; // setting the name of the goal to "Checklist Goal"
            description = "A goal that consists of multiple sub-goals to be completed.";
            points = 10; // setting a default point value for the goal
            
            _amountCompleted = 0; // initializing the amount completed to 0
            _targetAmount = targetAmount; // setting the target amount for the checklist goal
            _bonusPoints = bonusPoints; // setting the bonus points for completing the checklist goal
        }

        // overriding the RecordEvent method from the Goal class
        // This method marks a sub-goal as complete, increments the amount completed,
        // and adds points to the player's score if the target amount is reached.

        public override void RecordEvent()
        {
            _amountCompleted++;
            Console.WriteLine($"Sub-goal '{ShortName}' completed! Amount completed: {_amountCompleted}/{_targetAmount}");
            if (_amountCompleted >= _targetAmount)
            {
                Console.WriteLine($"Checklist goal '{ShortName}' completed! You earned {Points + _bonusPoints} points (including bonus points).");
            }
            else
            {
                Console.WriteLine($"You earned {Points} points for completing a sub-goal.");
            }
        }

        // overriding the IsComplete method from the Goal class
        // This method checks if the checklist goal is complete by comparing the amount completed with the target amount.

        public override bool IsComplete()
        {
            return _amountCompleted >= _targetAmount; // returns true if the amount completed is greater than or equal to the target amount
        }

        // overriding the GetStringRepresentation method from the Goal class
        // This method returns a string representation of the ChecklistGoal object,
        // including its name, description, points, target amount, bonus points, and completion status.

        public override string GetStringRepresentation()
        {
            string status = IsComplete() ? "X" : " ";
            return $"{status} {ShortName} ({Description}) -- Points: {Points}, Target: {_targetAmount}/ Completed: {_amountCompleted}, Bonus: {_bonusPoints}";
        }

        // overriding the ToString method to provide a string representation of the ChecklistGoal object
        public override string ToString()
        {
            return $"{ShortName} ({Description}) -- Points: {Points}, Target: {_targetAmount}/ Completed: {_amountCompleted}, Bonus: {_bonusPoints}";
        }
    }
}