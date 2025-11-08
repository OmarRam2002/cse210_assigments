using System;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        string choice;
        Journal journal = new Journal();
        do
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Add ");
            Console.WriteLine("2. Display ");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Exit");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                PromptGenerator promptGenerator = new PromptGenerator();
                string prompt = promptGenerator.getrandomPrompt();
                Console.WriteLine(prompt);
                string userEntry = Console.ReadLine();


                Entry entry = new Entry();
                entry._date = DateTime.Now.ToShortDateString();
                entry._promptText = prompt;
                entry._entryText = userEntry;
                journal.AddEntry(entry);

            }
            else if (choice == "2")
            {
                journal.DisplayAll();
            }

            else if (choice == "3")
            {
                Console.WriteLine("What is the filename?");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
            }
            else if (choice == "4")
            {
                Console.WriteLine("What is the filename?");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }
           
        } while (choice != "5");

    }
}