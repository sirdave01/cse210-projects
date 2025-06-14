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
    // creating the GoalManager class that will hold the list of goals
    // This class manages the collection of goals and scores, allowing for adding, removing, and displaying goals.
    // It also provides functionality to record events for goals and check their completion status.

    public class GoalManager
    {

        private List<Goal> _goals { get; set; } = new List<Goal>(); // List to hold the goals

        private int _score { get; set; } // Variable to hold the player's score

        // method to start the GoalManager
        // This method initializes the GoalManager, allowing for interaction with the goals.
        public void Start()
        {
            Console.WriteLine("Welcome to the Eternal Quest Goal Manager!");
            Console.WriteLine("You can add, remove, and display goals, as well as record events and check completion status.");
            Console.WriteLine("Your current score is: " + _score);
            Console.WriteLine("Type 'help' to see the list of available commands.");
            Console.WriteLine("Type 'exit' to quit the Goal Manager.");
            Console.WriteLine();
        }

        // method to create a void DisplayPlayerInfo
        // This method displays the player's current score and the list of goals.

        public void DisplayPlayerInfo()
        {
            Console.WriteLine($"Current Score: {_score}");
            Console.WriteLine("Goals:");
            if (_goals.Count == 0)
            {
                Console.WriteLine("No goals available.");
            }
            else
            {
                foreach (var goal in _goals)
                {
                    Console.WriteLine(goal.GetStringRepresentation());
                }
            }
        }

        // method to create a void ListGoalNames
        // This method lists the names of all goals in the GoalManager.

        public void ListGoalNames()
        {
            // Console.WriteLine("List of Goals:");
            // Console.WriteLine("1. Simple Goal");
            // Console.WriteLine("2. Eternal Goal");
            // Console.WriteLine("3. Checklist Goal");
            // Console.WriteLine("4. Exit Goal Creation");
            // Console.WriteLine();
            // Console.Write("Enter the number of the goal type to create: ");
            // string goalType = Console.ReadLine();
            foreach (var goal in _goals)
            {
                Console.WriteLine($"- {goal.ShortName}");
            }
        }

        // method to create a void ListGoalDetails
        // This method lists the details of all goals in the GoalManager.

        public void ListGoalDetails()
        {
            // Console.WriteLine("List of Goal Details:");
            // Console.WriteLine("---------------------");
            // Console.WriteLine("Simple Goal: A goal that can be completed once.");
            // Console.WriteLine("Eternal Goal: A goal that can be completed multiple times.");
            // Console.WriteLine("Checklist Goal: A goal that consists of multiple sub-goals to be completed.");
            foreach (var goal in _goals)
            {
                Console.WriteLine(goal.GetStringRepresentation());
            }
        }

        // method to create a void CreateGoal
        // This method allows the user to create a new goal by specifying its type, name, description, and points.

        public void CreateGoal()
        {
            
        }

        // method to create a void RemoveGoal
        // This method allows the user to remove a goal by specifying its name.

        public void RemoveGoal()
        {
            Console.Write("Enter the name of the goal to remove: ");
            string goalName = Console.ReadLine();
            Goal goalToRemove = _goals.Find(g => g.ShortName.Equals(goalName, StringComparison.OrdinalIgnoreCase));
            if (goalToRemove != null)
            {
                _goals.Remove(goalToRemove);
                Console.WriteLine($"Goal '{goalName}' has been removed.");
            }
            else
            {
                Console.WriteLine($"Goal '{goalName}' not found.");
            }
        }

        // method to create a void RecordEvent
        // This method allows the user to record an event for a specific goal by specifying its name

        public void RecordEvent()
        {
            Console.Write("Enter the name of the goal to record an event for: \n");
            string goalName = Console.ReadLine();
            Goal goalToRecord = _goals.Find(g => g.ShortName.Equals(goalName, StringComparison.OrdinalIgnoreCase));
            if (goalToRecord != null)
            {
                goalToRecord.RecordEvent();
                _score += goalToRecord.Points;
                Console.WriteLine($"You earned {goalToRecord.Points} points for completing the goal '{goalName}'.");
            }
            else
            {
                Console.WriteLine($"Goal '{goalName}' not found.");
            }
        }

        // method to create a void CheckGoalCompletion
        // This method allows the user to check if a specific goal is complete by specifying its name.

        public void CheckGoalCompletion()
        {
            Console.Write("Enter the name of the goal to check completion: \n");
            string goalName = Console.ReadLine();
            Goal goalToCheck = _goals.Find(g => g.ShortName.Equals(goalName, StringComparison.OrdinalIgnoreCase));
            if (goalToCheck != null)
            {
                if (goalToCheck.IsComplete())
                {
                    Console.WriteLine($"Goal '{goalName}' is complete!");
                }
                else
                {
                    Console.WriteLine($"Goal '{goalName}' is not complete yet.");
                }
            }
            else
            {
                Console.WriteLine($"Goal '{goalName}' not found.");
            }
        }

        // method to create a void SaveGoals
        // This method saves the current goals and score to a file.

        public void SaveGoals()
        {
            Console.WriteLine("Saving goals and score...");
            if (_goals.Count == 0)
            {
                Console.WriteLine("No goals to save.");
                return;
            }
            using (System.IO.StreamWriter file = new System.IO.StreamWriter("goals.txt"))
            {
                file.WriteLine($"Score: {_score}");
                foreach (var goal in _goals)
                {
                    file.WriteLine(goal.GetStringRepresentation());
                }
            }
            Console.WriteLine("Goals and score saved to 'goals.txt'.");
        }

        // method to create a void LoadGoals
        // This method loads goals and score from a file.

        public void LoadGoals()
        {
            Console.WriteLine("Loading goals and score...");
            if (!System.IO.File.Exists("goals.txt"))
            {
                Console.WriteLine("No saved goals found.");
                return;
            }
            using (System.IO.StreamReader file = new System.IO.StreamReader("goals.txt"))
            {
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    if (line.StartsWith("Score:"))
                    {
                        string scoreLine = line.Substring(6).Trim();
                        if (int.TryParse(scoreLine, out int loadedScore))
                        {
                            _score = loadedScore;
                        }
                        else
                        {
                            Console.WriteLine("Invalid score format in saved file.");
                        }
                    }
                    else
                    {
                        // Assuming the line is a goal representation
                        string[] parts = line.Split(new[] { " -- " }, StringSplitOptions.None);
                        if (parts.Length >= 3)
                        {
                            string goalType = parts[0].Trim();
                            string name = parts[1].Trim();
                            string description = parts[2].Trim();
                            int points = 0;
                            if (parts.Length > 3 && int.TryParse(parts[3].Trim(), out int parsedPoints))
                            {
                                points = parsedPoints;
                            }
                            // Create the appropriate goal based on the type
                            if (goalType.Contains("SimpleGoal"))
                            {
                                _goals.Add(new SimpleGoal(name, description, points));
                            }
                            else if (goalType.Contains("EternalGoal"))
                            {
                                _goals.Add(new EternalGoal(name, description, points));
                            }
                            else if (goalType.Contains("ChecklistGoal"))
                            {
                                int targetAmount = 0;
                                int bonusPoints = 0;
                                if (parts.Length > 4 && int.TryParse(parts[4].Trim(), out int parsedTargetAmount))
                                {
                                    targetAmount = parsedTargetAmount;
                                }
                                if (parts.Length > 5 && int.TryParse(parts[5].Trim(), out int parsedBonusPoints))
                                {
                                    bonusPoints = parsedBonusPoints;
                                }
                                _goals.Add(new ChecklistGoal(name, description, points, targetAmount, bonusPoints));
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid goal format in saved file: " + line);
                        }
                    }
                }
            }
        }

        // method to create a void Exit
        // This method exits the GoalManager, saving goals and score before quitting.

        public void Exit()
        {
            Console.WriteLine("Exiting the Goal Manager...");
            SaveGoals();
            Console.WriteLine("Goals and score saved. Goodbye!");
            Environment.Exit(0); // Exits the application
        }

        // method to create a void Help
        // This method displays the list of available commands and their descriptions.

        public void Help()
        {
            Console.WriteLine("Available Commands:");
            Console.WriteLine("1. display - Display the player's current score and goals.");
            Console.WriteLine("2. list - List the names of all goals.");
            Console.WriteLine("3. details - List the details of all goals.");
            Console.WriteLine("4. create - Create a new goal.");
            Console.WriteLine("5. remove - Remove a goal by name.");
            Console.WriteLine("6. record - Record an event for a specific goal.");
            Console.WriteLine("7. check - Check if a specific goal is complete.");
            Console.WriteLine("8. save - Save the current goals and score to a file.");
            Console.WriteLine("9. load - Load goals and score from a file.");
            Console.WriteLine("10. exit - Exit the Goal Manager, saving goals and score.");
            Console.WriteLine("11. help - Display this list of commands.");
            Console.WriteLine();
        }

        // method to create a void Run
        // This method runs the GoalManager, allowing the user to interact with it through commands.
        public void Run()
        {
            Start();
            while (true)
            {
                Console.Write("\nEnter a command (type 'help' for available commands): ");
                string command = Console.ReadLine()?.ToLower();
                switch (command)
                {
                    case "display":
                        DisplayPlayerInfo();
                        break;
                    case "list":
                        ListGoalNames();
                        Console.WriteLine();
                        Console.WriteLine("1. Simple Goal");
                        Console.WriteLine("2. Eternal Goal");
                        Console.WriteLine("3. Checklist Goal");
                        Console.WriteLine("4. Exit Goal Creation");
                        Console.WriteLine();
                        break;
                    case "details":
                        ListGoalDetails();
                        Console.WriteLine();
                        Console.WriteLine("List of Goal Details:");
                        Console.WriteLine("---------------------");
                        Console.WriteLine("Simple Goal: A goal that can be completed once.");
                        Console.WriteLine("Eternal Goal: A goal that can be completed multiple times.");
                        Console.WriteLine("Checklist Goal: A goal that consists of multiple sub-goals to be completed.");
                        break;
                    case "create":
                        CreateGoal();
                        Console.WriteLine();
                        Console.WriteLine("Choose the type of goal to create:");
                        Console.WriteLine("\nAvailable Goal Types:");
                        Console.WriteLine("\n---------------------");
                        Console.WriteLine("0. Exit Goal Creation\n");
                        Console.WriteLine("1. Simple Goal\n");
                        Console.WriteLine("2. Eternal Goal\n");
                        Console.WriteLine("3. Checklist Goal\n");
                        Console.Write("Enter the number of the goal type to create: ");
                        string choice = Console.ReadLine();
                        switch (choice)
                        {
                            case "1":
                                Console.Write("Enter the name of the Simple Goal: ");
                                string simpleGoalName = Console.ReadLine();
                                Console.Write("Enter the description of the Simple Goal: ");
                                string simpleGoalDescription = Console.ReadLine();
                                Console.Write("Enter the points for the Simple Goal: ");
                                int simpleGoalPoints;
                                while (!int.TryParse(Console.ReadLine(), out simpleGoalPoints) || simpleGoalPoints < 0)
                                {
                                    Console.Write("Invalid input. Please enter a valid number for points: ");
                                }
                                _goals.Add(new SimpleGoal(simpleGoalName, simpleGoalDescription, simpleGoalPoints));
                                Console.WriteLine($"Simple Goal '{simpleGoalName}' created successfully!");
                                break;
                            case "2":
                                Console.Write("Enter the name of the Eternal Goal: ");
                                string eternalGoalName = Console.ReadLine();
                                Console.Write("Enter the description of the Eternal Goal: ");
                                string eternalGoalDescription = Console.ReadLine();
                                Console.Write("Enter the points for the Eternal Goal: ");
                                int eternalGoalPoints;
                                while (!int.TryParse(Console.ReadLine(), out eternalGoalPoints) || eternalGoalPoints < 0)
                                {
                                    Console.Write("Invalid input. Please enter a valid number for points: ");
                                }
                                _goals.Add(new EternalGoal(eternalGoalName, eternalGoalDescription, eternalGoalPoints));
                                Console.WriteLine($"Eternal Goal '{eternalGoalName}' created successfully!");
                                break;
                            case "3":
                                Console.Write("Enter the name of the Checklist Goal: ");
                                string checklistGoalName = Console.ReadLine();
                                Console.Write("Enter the description of the Checklist Goal: ");
                                string checklistGoalDescription = Console.ReadLine();
                                Console.Write("Enter the points for the Checklist Goal: ");
                                int checklistGoalPoints;
                                while (!int.TryParse(Console.ReadLine(), out checklistGoalPoints) || checklistGoalPoints < 0)
                                {
                                    Console.Write("Invalid input. Please enter a valid number for points: ");
                                }
                                Console.Write("Enter the target amount for the Checklist Goal: ");
                                int targetAmount;
                                while (!int.TryParse(Console.ReadLine(), out targetAmount) || targetAmount <= 0)
                                {
                                    Console.Write("Invalid input. Please enter a valid positive number for target amount: ");
                                }
                                Console.Write("Enter the bonus points for completing the Checklist Goal: ");
                                int bonusPoints;
                                while (!int.TryParse(Console.ReadLine(), out bonusPoints) || bonusPoints < 0)
                                {
                                    Console.Write("Invalid input. Please enter a valid number for bonus points: ");
                                }
                                _goals.Add(new ChecklistGoal(checklistGoalName, checklistGoalDescription, checklistGoalPoints, targetAmount, bonusPoints));
                                Console.WriteLine($"Checklist Goal '{checklistGoalName}' created successfully!");
                                break;
                            case "0":
                                Console.WriteLine("Exiting goal creation.");
                                break;
                        }
                        break;
                    case "remove":
                        RemoveGoal();
                        break;
                    case "record":
                        RecordEvent();
                        break;
                    case "check":
                        CheckGoalCompletion();
                        break;
                    case "save":
                        SaveGoals();
                        break;
                    case "load":
                        LoadGoals();
                        break;
                    case "exit":
                        Exit();
                        break;
                    case "help":
                        Help();
                        break;
                    default:
                        Console.WriteLine("Unknown command. Type 'help' for a list of available commands.");
                        break;
                }
            }
        }
    }
}