using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Mindfulness
{
    public class ReflectingActivity : Activity
    {
        private List<string> prompt = new List<string>
        {
            "Think about a time when you felt truly happy.",
            "Reflect on a moment when you overcame a challenge.",
            "Consider a person who has had a significant impact on your life.",
            "Recall a time when you learned something valuable about yourself."
        };

        private List<string> _reflectionQuestions = new List<string>
        {
            "What did you learn from this experience?",
            "How did this moment shape your perspective?",
            "What emotions did you feel during this time?",
            "How can you apply what you've learned to your current life?"
        };

        public ReflectingActivity(string name, string description, int duration)
            : base("Reflecting Activity", "This activity will help you reflect on the good things you've had in life", 45)
        {

        }

        public void StartReflectingActivity()
        {
            Console.WriteLine($"Prompt: {GetRandomPrompt()}");
            Console.WriteLine("Let's begin the reflection exercise.");
        }

        public void EndReflectingActivity()
        {
            Console.WriteLine("Thank you for participating in the reflecting activity.");
            Console.WriteLine("Remember to take time to reflect on your thoughts and feelings.");
            Console.WriteLine($"You completed the {GetActivityName()} activity for {GetDuration()} seconds.");
        }

        //method to list the questions for the reflection activity


        public void RunReflectingActivity()
        {
            StartReflectingActivity();
            GetDuration();
            GetReflectingSpinner();
            // Simulate the reflection activity for the specified duration
            System.Threading.Thread.Sleep(GetDuration() * 250);
            Console.WriteLine();
            DisplayReflectionQuestion();
            EndReflectingActivity();
        }

        //method to get random reflection question

        public string GetRandomReflectionQuestion()
        {
            Random random = new Random();
            int index = random.Next(_reflectionQuestions.Count);
            return _reflectionQuestions[index];
        }

        //method to display the reflection question

        public void DisplayReflectionQuestion()
        {
            string question = GetRandomReflectionQuestion();
            Console.WriteLine($"Reflection Question: {question}");
            Console.WriteLine("Take a moment to think about your answer.");
            Console.ReadLine();
        }

        //method to get random prompt

        public string GetRandomPrompt()
        {
            return prompt[new Random().Next(prompt.Count)];
        }

        //method to display the prompt

        public void DisplayPrompt()
        {
            Console.WriteLine($"Prompt: {GetRandomPrompt()}");
            Console.WriteLine("Reflect on this prompt and think about your thoughts and feelings.");
        }

        public void GetReflectingSpinner()
        {
            Console.Write(".");
            System.Threading.Thread.Sleep(250); // Sleep for 0.25 second
            Console.Write("\b"); // Backspace to overwrite the dot
            Console.Write("-"); // Print a space to clear the dot
            System.Threading.Thread.Sleep(250); // Sleep for 0.25 second
            Console.Write("\b"); // Backspace again to return to the same position
            Console.Write("|"); // Print the spinner character
            System.Threading.Thread.Sleep(250); // Sleep for 0.25 second
            Console.Write("\b"); // Backspace to overwrite the spinner character
            Console.Write("//"); // Print the next spinner character
            System.Threading.Thread.Sleep(250); // Sleep for 0.25 second
        }
    }
}