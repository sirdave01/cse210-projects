using system;
using System.Collections.Generic;

// this line of code creates the Prompts class

public class Prompts
{
    // this line of code creates the prompts list
    public List<string> prompts = new List<string>
    {
        "What was the best part of your day?",
        "What are you grateful for?",
        "What did you learn today?",
        "What was the most challenging part of your day?",
        "What are your goals for tomorrow?"
        "Is there anything you would like to change about your day?",
        "What is something you are looking forward to?",
        "What is something you wish you could do differently?",
    };

    // // this line of code creates the prompts constructor that initializes the prompts list
    // public Prompts()
    // {
    //     PromptList = new List<string>
    //     {
    //         "What was the best part of your day?",
    //         "What are you grateful for?",
    //         "What did you learn today?",
    //         "What was the most challenging part of your day?",
    //         "What are your goals for tomorrow?"
    //     };
    // }
    // // this line of code creates the prompts method that displays the prompts information
    // public void DisplayPrompts()
    // {
    //     Console.WriteLine("Prompts:");
    //     foreach (var prompt in PromptList)
    //     {
    //         Console.WriteLine($"- {prompt}");
    //     }
    // }
}