public class BreathingActivity: Activity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activty will help you breath";
        _duration = 30;
    }

    public void run(int duration)
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(1);
        for (int i = duration; i > 0; i -=10)
        {
            Console.WriteLine();
            Console.Write("Breath in.." );
            ShowCountDown(1);
            Console.WriteLine();
            Console.Write("Now Breath out.." );
            ShowCountDown(1);
            Console.WriteLine();
        }
       
    }
}