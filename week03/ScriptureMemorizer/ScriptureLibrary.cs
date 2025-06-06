using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

// Public class scripture library to manage a collection of scriptures

public class ScriptureLibrary
{

    private List<Scripture> _scriptures;

    private Random _random;

    public ScriptureLibrary()
    {
        _scriptures = new List<Scripture>();

        _random = new Random();
    }

    public void LoadScripturesFromFile(string filePath)
    {
        Console.WriteLine($"Loading scriptures from file: {filePath}");
        try
        {
            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {

                try
                {
                    string[] parts = line.Split(new[] { ':' }, 2);

                    if (parts.Length == 2)
                    {
                        string reference = parts[0].Trim();

                        string text = parts[1].Trim();

                        string[] referenceParts = reference.Split(' ');

                        if (referenceParts.Length >= 2)
                        {
                            string book = referenceParts[0];
                            string chapterAndVerse = string.Join(" ", referenceParts, 1, referenceParts.Length - 1);

                            // Assuming chapterAndVerse is in the format "chapter:verse" or "chapter:verse-endVerse"

                            Reference scriptureReference = new Reference(book, chapterAndVerse);

                            Scripture scripture = new Scripture(scriptureReference, text);

                            _scriptures.Add(scripture);
                        }

                    }
                }

                catch (Exception ex)
                {
                    Console.WriteLine($"Error processing line '{line}': {ex.Message}");
                }
            }
        }

        catch (FileNotFoundException)
        {
            Console.WriteLine($"Error: The file '{filePath}' was not found.");
        }

        catch (Exception ex)
        {
            Console.WriteLine($"An unexpected error occurred while loading scriptures: {ex.Message}");
        }
    }

    public Scripture GetRandomScripture()
    {
        if (_scriptures.Count == 0)
        {
            Console.WriteLine("No scriptures available in the library.");
        }

        return _scriptures[_random.Next(0, _scriptures.Count)];
    }

    // public ScriptureLibrary()
    // {
    //     _scriptures = new List<Scripture>();



    //     LoadScripturesFromFile("Scriptures.txt"); //this line to load scriptures from a file at initialization
    // }

    // public void LoadScripturesFromFile(string filePath)
    // {
    //     try
    //     {
    //         var lines = File.ReadAllLines(filePath);
    //         foreach (var line in lines)
    //         {
    //             var parts = line.Split(new[] { ':' }, 2);
    //             var referenceParts = parts[0].Split(' ');
    //             var book = referenceParts[0];
    //             var chapterVerse = referenceParts[1].Split(':');
    //             var chapter = int.Parse(chapterVerse[0]);
    //             var verseParts = chapterVerse[1].Split('-');

    //             Reference reference;

    //             if (verseParts.Length == 2)
    //             {
    //                 reference = new Reference(book, chapter, int.Parse(verseParts[0]));
    //             }
    //             else
    //             {
    //                 reference = new Reference(book, chapter, int.Parse(verseParts[0]), int.Parse(verseParts[1]));
    //             }

    //             var scripture = new Scripture(reference, parts[1].Trim());
    //             _scriptures.Add(scripture);
    //         }
    //     }
    //     catch (FileNotFoundException)
    //     {
    //         Console.WriteLine($"Error: The file '{filePath}' was not found.");
    //     }
    //     catch (FormatException)
    //     {
    //         Console.WriteLine("Error: The file format is incorrect. Please check the scripture entries.");
    //     }
    //     catch (Exception ex)
    //     {
    //         Console.WriteLine($"An unexpected error occurred: {ex.Message}");
    //     }

    // }

    // public Scripture GetRandomScripture()
    // {
    //     var random = new Random();

    //     return _scriptures[random.Next(0, _scriptures.Count)];
    // }
}