using System;

using system.Collections.Generic;

// this line of code creates the entry class

public class Entry;
{
    // theese lines of code creates the prompts string, entry text string, and entry date
    public string Prompts { get; set; }

    public string EntryText { get; set; }

    public DateTime EntryDate { get; set; }

    // these lines of code creates the entry constructor that initializes the prompts, entry text

    public Entry(string prompts, string entryText)
    {
        Prompts = prompts;
        EntryText = entryText;
        EntryDate = DateTime.Now;
    }

    // these lines of code creates the entry constructor that initializes the prompts, entry text, and entry date

    public Entry(string prompts, string entryText, DateTime entryDate)
    {
        Prompts = prompts;
        EntryText = entryText;
        EntryDate = entryDate;
    }

// this line of code creates the entry method that overrides the ToString method to display the entry information

public override string ToString()
{
    return $"{EntryDate.ToShortDateString()} - {Prompts}: {EntryText}";
}


}