using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Scripture Memorizer!");

        var library = new ScriptureLibrary();
        library.LoadScripturesFromFile("Scriptures.txt"); // Path to the scripture file
        var scripture = library.GetRandomScripture();

        Console.WriteLine(scripture.GetScriptureText());

        while (true)
        {
            Console.WriteLine("\nPress Enter to hide a word, type 'quit' to exit:");
            var input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            Console.Clear();

            scripture.HideRandomWord(3); // Hide three random words

            Console.WriteLine(scripture.GetScriptureText());

            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("Congratulations! You have memorized the scripture.");
                break;
            }
        }

        Console.WriteLine("Thank you for using the Scripture Memorizer!");
    }

}
