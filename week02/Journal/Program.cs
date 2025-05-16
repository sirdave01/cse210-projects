using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");

        // this line of code creates a new instance of the Journal class

        Journal journal = new Journal();
        Prompts prompts = new Prompts();

        // These lines of code creates the journal menu as a list to choose from
        while (true)
        {
            console.WriteLine("Welcome to the Journal Menu!");
            Console.WriteLine("1. Add Entry");
            Console.WriteLine("2. Remove Entry");
            Console.WriteLine("3. Display Entries");
            Console.WriteLine("4. Load Journal");
            Console.WriteLine("5. Save Journal to CSV");
            Console.WriteLine("6. Save Journal to JSON");
            Console.WriteLine("7. Save Journal to Database");
            Console.WriteLine("8. Exit");

            Console.WriteLine("Please select an option from the menu: ");
            string userInput = Console.ReadLine();
            int option;
            if (int.TryParse(userInput, out option))


            {
                // these lines of codes uses the switch statement to determine which option the user selected
                // and performs the corresponding action

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter your entry text: ");
                        string entryText = Console.ReadLine();
                        Entry entry = new Entry(prompts.GetRandomPrompt(), entryText);
                        journal.AddEntry(entry);
                        break;
                    case 2:
                        Console.WriteLine("Enter the index of the entry to remove: ");
                        int indexToRemove = int.Parse(Console.ReadLine());
                        journal.RemoveEntry(journal.Entries[indexToRemove]);
                        break;
                    case 3:
                        journal.DisplayEntries();
                        break;
                    case 4:
                        Console.WriteLine("Enter the file name to load the journal from: ");
                        Console.WriteLine("1. cSV");
                        Console.WriteLine("2. JSON");
                        Console.WriteLine("3. Database");
                        Console.WriteLine("Please select an option from the menu: ");
                        string loadSelection = Console.ReadLine();

                        switch (loadSelection)
                        {
                            case "1"
                                journal.LoadEntriesFromCSV("journal.csv");
                                break;
                            case "2":
                                journal.LoadEntriesFromJSON("journal.json");
                                break;
                            case "3":
                                journal.LoadEntriesFromDatabase("connectionString");
                                break;
                        }
                        break;
                    case 5:
                        Console.WriteLine("Enter the file name to save the journal to: ");
                        string saveFileName = Console.ReadLine();
                        journal.SaveJournal(saveFileName);
                        break;
                    case 6:
                        Console.WriteLine("Enter the file name to save the journal to JSON: ");
                        string saveJsonFileName = Console.ReadLine();
                        journal.SaveJournalToJson(saveJsonFileName);
                        break;
                    case 7:
                        Console.WriteLine("Enter the database connection string: ");
                        string connectionString = Console.ReadLine();
                        journal.SaveJournalToDatabase(connectionString);
                        break;
                    case 8:
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

    }
}
