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

    public ScriptureLibrary()
    {
        _scriptures = new List<Scripture>();
    }

    public void LoadScripturesFromFile(string filePath)
    {
        try
        {
            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                var parts = line.Split(new[] { ':' }, 2);
                var referenceParts = parts[0].Split(' ');
                var book = referenceParts[0];
                var chapterVerse = referenceParts[1].Split(':');
                var chapter = int.Parse(chapterVerse[0]);
                var verseParts = chapterVerse[1].Split('-');

                Reference reference;

                if (verseParts.Length == 1)
                {
                    reference = new Reference(book, chapter, int.Parse(verseParts[0]));
                }
                else
                {
                    reference = new Reference(book, chapter, int.Parse(verseParts[0]), int.Parse(verseParts[1]));
                }

                var scripture = new Scripture(reference, parts[1].Trim());
                _scriptures.Add(scripture);
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"Error: The file '{filePath}' was not found.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: The file format is incorrect. Please check the scripture entries.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }

    }

    public Scripture GetRandomScripture()
    {
        var random = new Random();

        return _scriptures[random.Next(0, _scriptures.Count)];
    }
}