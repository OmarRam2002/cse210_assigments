using System.Globalization;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity()
    {
        _name = "";
        _description = "";
        _duration = 50;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the  {_name}");
        Console.WriteLine();
        Console.WriteLine(_description);
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done!!");
        Console.WriteLine($"\nYou have completed another {_duration} seconds of {_name}");
        ShowSpinner(1);
        Console.Clear();
    }
    public void ShowSpinner(int seconds)
    {
        List<string> animation = new List<string>();
        animation.Add("|");
        animation.Add("/");
        animation.Add("-");
        animation.Add("\\");
        animation.Add("|");
        animation.Add("/");
        animation.Add("_");
        animation.Add("\\");

        foreach(string s in animation)
        {
            Console.Write(s);
            Thread.Sleep(seconds * 1000);
            Console.Write("\b \b");
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i =5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(seconds * 1000);
            Console.Write("\b \b");
        }
    }
}