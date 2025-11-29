using System;


// For extra credits I added a feature for the reflectin activity that allows the program to print difrent quesions everytime. 
class Program
{
    static void Main(string[] args)
    {

    string userinput = "0";
        while (userinput!= "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options");
            Console.WriteLine("\t1. Start breathing acitivty");
            Console.WriteLine("\t2. Start reflecting acitivty");
            Console.WriteLine("\t3. Start listing acitivty");
            Console.WriteLine("\t4. Quit");
            Console.Write("Select a choice form the menu: ");
            userinput = Console.ReadLine();
            if (userinput == "1")
            {
                Console.Clear();
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.DisplayStartingMessage();
                Console.Write("How long would you like your session? ");
                int seconds = int.Parse(Console.ReadLine());
                breathingActivity.run(seconds);
                breathingActivity.DisplayEndingMessage();
            } 
            if (userinput == "2")
            {
                Console.Clear();
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.DisplayStartingMessage();
                Console.Write("How long would you like your session? ");
                int seconds = int.Parse(Console.ReadLine());
                reflectingActivity.run(seconds);
                reflectingActivity.DisplayEndingMessage();

            }
            if(userinput == "3")
            {
                Console.Clear();
                listingActivity listingActivity = new listingActivity();
                listingActivity.DisplayStartingMessage();
                Console.Write("How long would you like your session? ");
                int seconds = int.Parse(Console.ReadLine());
                listingActivity.run(seconds);
                listingActivity.DisplayEndingMessage();

            }
        }
        


        
    }
}