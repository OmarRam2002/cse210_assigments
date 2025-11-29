public class ReflectingActivity: Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions= new List<string>();
    private List<string> _usedquestions = new List<string>();
    public ReflectingActivity()
    {
        _name = "Reflecting Activity";
        _description = "This activty will help you on hard times";
        _duration = 50;
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");

    }
    public void run(int seconds)
    {
        Console.Clear();
        Console.WriteLine("Get Ready...");
        ShowSpinner(1);
        Console.WriteLine("\nConsider the following prompt:");
        Console.WriteLine($"---{GetRandomPrompt()}---");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("\nNow ponder on each of the following questions as they realate to this experience");
        Console.Write("You may being: ");
        ShowCountDown(1);
        Console.Clear();

        DateTime starttime = DateTime.Now;
        DateTime futureime = starttime.AddSeconds(seconds);

         while (starttime < futureime)
        {

            string randomquestion;
            //This loops makes sure we promt questions once
            do
            {
                randomquestion = GetRandomquestion();
            } while (_usedquestions.Contains(randomquestion));
            _usedquestions.Add(randomquestion);
            Console.Write($"\n>{randomquestion}");
            ShowSpinner(1);
            starttime = DateTime.Now;     
        }

    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int randomindex = random.Next(_prompts.Count);
        string randompromt = _prompts[randomindex];
        return randompromt;
    }
    public string GetRandomquestion()
    {
        Random random = new Random();
        int randomindex = random.Next(_questions.Count);
        string randompromt = _questions[randomindex];
        return randompromt;
    }

    public void DisplayQuestion()
    {
        Console.WriteLine(GetRandomquestion());
    }
    public void DisplayPrompt()
    {
        Console.WriteLine(GetRandomPrompt());
    }

}