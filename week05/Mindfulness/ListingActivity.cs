public class listingActivity: Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();

    public listingActivity()
    {
         _name = "Listing Activity";
        _description = "This activty will help you reflect on the good things in your life";
        _duration = 30;
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
    }

    public void run(int seconds)
    {
        Console.Clear();
        Console.WriteLine("Get Ready...");
        ShowSpinner(1);
        Console.WriteLine("\nList as many responses as you can to the following promt:");
        Console.WriteLine($"---{GetRandomPrompt()}---");
        Console.Write("You may being: ");
        ShowCountDown(1);
        DateTime starttime = DateTime.Now;
        DateTime futureime = starttime.AddSeconds(seconds);
        Console.WriteLine();

        while (starttime < futureime)
        {
            Console.Write(">");
            Console.ReadLine();
            starttime = DateTime.Now;
            _count += 1;
        }
        Console.WriteLine($"You listed {_count} items!");

    
    }
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int randomindex = random.Next(_prompts.Count);
        string randompromt = _prompts[randomindex];
        return randompromt;
    }
}