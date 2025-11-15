using System;

class Program
{
    static void Main(string[] args)
    {
        
        Reference reference = new Reference("Proverbs", 3, 5,6);
        Scripture scripture1 = new Scripture(reference, "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways ackowledge him, and he shall direct thy paths.");
        string userInput = "";

        Console.WriteLine(scripture1.GetDisplayText());

        while (!scripture1.isCompleteHidden())
        {

            Console.WriteLine("\nPress enter to continue or type 'quit' to finish: ");
            userInput = Console.ReadLine();
            Console.Clear();
            if (userInput == "quit")
            {
                break;
            }
            scripture1.HideRandomWords(2);
            Console.WriteLine(scripture1.GetDisplayText());
            
        } 
        
    }
}