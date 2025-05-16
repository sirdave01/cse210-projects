// these lines of code create the journal class and calls the entry and prompts classes

using System;

using System.Collections.Generic;

using System.IO;

using System.Text.Json;

// this line of code creates the journal class

public class Journal
{
    // these lines of code creates the journal title, entries, and prompts
    public List<Entry> Entries = new List<Entry>();

    // these lines of code creates the entries encapsulated in a property
    public void AddEntry(Entry entry)
    {
        Entries.Add(entry);
    }

    // these lines of codes allows users to remove an entry from the journal

    public void RemoveEntry(Entry entry)
    {
        Entries.Remove(entry);
    }

    // these lines of code creates the entries method that displays the journal information

    public void DisplayEntries()
    {
        Console.WriteLine("Journal Entries:");

        foreach (Entry entry in Entries)
        {
            Console.WriteLine(entry.ToString());
        }
    }

    // these lines of code creates the save journal method that saves the journal to a csv file

    public void SaveJournal(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (Entry entry in Entries)
            {
                writer.WriteLine(entry.ToString());
            }
        }
    }

    // this line of code creates the load journal method that loads the journal from a csv file

    public void LoadJournalFromCSV(string fileName)
    {
        using (StreamReader reader = new StreamReader(fileName))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split(',');
                string prompts = parts[0];
                string entryText = parts[1];
                DateTime entryDate = DateTime.Parse(parts[2]);

                Entry entry = new Entry(prompts, entryText, entryDate);
                Entries.Add(entry);
            }
        }
    }

    // this line of code creates the save journal method that saves the journal to a json file

    public void SaveJournalToJson(string fileName)
    {
        string json = JsonSerializer.Serialize(Entries);
        File.WriteAllText(fileName, json);
    }

    // this line of code creates the load journal method that loads the journal from a json file

    public void LoadJournalFromJson(string fileName)
    {
        string json = File.ReadAllText(fileName);
        Entries = JsonSerializer.Deserialize<List<Entry>>(json);
    }

    // these lines of code creates the save method that saves the journal to a database

    public void SaveJournalToDatabase(string connectionString)
    {
        // Implement database saving logic here
        // This is a placeholder for the actual database code

        Console.WriteLine("Saving journal to database...");
    }

    // these lines of code creates the load method that loads the journal from a database

    public void LoadJournalFromDatabase(string connectionString)
    {
        // Implement database loading logic here
        // This is a placeholder for the actual database code

        Console.WriteLine("Loading journal from database...");
    }

}