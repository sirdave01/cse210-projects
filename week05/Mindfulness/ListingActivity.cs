using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Mindfulness
{
    public class ListingActivity : Activity
    {
        private int _itemCount;

        private List<string> _items;

        public ListingActivity(string name, string description, int duration)
            : base("Listing Activity", "This activity will help youn reflect on the good things life has given and things to improve on", 30)
        {
            _itemCount = 0;
            _items = new List<string>();
        }

        //method to for the start and end messages for the listing activity
        public void StartListingActivity()
        {
            Console.WriteLine("Let's begin listing items.");
        }

        public void EndListingActivity()
        {
            Console.WriteLine("Thank you for participating in the listing activity.");
            Console.WriteLine($"You listed {_itemCount} items during the {GetActivityName()} activity.");
            Console.WriteLine("Remember to keep a positive mindset and reflect on your accomplishments.");
        }

        //method to add to the list of the listing activity

        public void AddItem(string item)
        {
            _items.Add(item);
            _itemCount++;
            Console.WriteLine($"Item added: {item}");
        }

        //method to display random prompts for the listing activity

        public void DisplayRandomPrompt()
        {
            string[] prompts = new string[]
            {
                "List three things you are grateful for today.",
                "List five achievements you are proud of.",
                "List ten things that make you happy.",
                "List three goals you want to achieve this month.",
                "Who are three people who inspire you?",
                "When did you last feel proud of yourself? List the reasons why.",
                "What are your top five favorite books or movies?",
                "List five skills you want to improve or learn.",
            };

            Random random = new Random();
            int index = random.Next(prompts.Length);
            Console.WriteLine(prompts[index]);
        }

        //method to run the listing activity

        public void RunListingActivity()
        {
            StartListingActivity();
            DisplayRandomPrompt();

            // Simulate the listing activity for the specified duration
            DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
            while (DateTime.Now < endTime)
            {
                Console.Write("Enter an item (or type 'done' to finish): ");
                string input = Console.ReadLine();
                if (input.ToLower() == "done")
                {
                    break;
                }
                AddItem(input);
            }

            EndListingActivity();
        }

        // Method to get the list of items added during the activity

        public List<string> GetItems()
        {
            return _items;
        }

        // Method to get the count of items added during the activity

        public int GetItemCount()
        {
            return _itemCount;
        }

        // Method to clear the items list and reset the item count

        public void ClearItems()
        {
            _items.Clear();
            _itemCount = 0;
            Console.WriteLine("Items cleared.");
        }

        // Method to display all items added during the activity

        public void DisplayItems()
        {
            if (_items.Count == 0)
            {
                Console.WriteLine("No items have been added yet.");
                return;
            }

            Console.WriteLine("Items added during the activity:");
            foreach (var item in _items)
            {
                Console.WriteLine($"- {item}");
            }
        }

        // Method to display the total number of items added during the activity

        public void DisplayItemCount()
        {
            Console.WriteLine($"Total items added: {_itemCount}");
        }

    }
}