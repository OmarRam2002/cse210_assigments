using System;

class Program
{
    static void Main(string[] args)
    {
        string date = DateOnly.FromDateTime(DateTime.Now).ToString();
        List<Activity> activities = new List<Activity>();

        RunningActivity runningActivity = new RunningActivity(date, 30,3.0);
        
        CyclingActivity cyclingActivity = new CyclingActivity(date, 30, 10.0);
    
        SwimmingActivity swimmingActivity = new SwimmingActivity(date, 30, 10);
        activities.Add(runningActivity);
        activities.Add(cyclingActivity);
        activities.Add(swimmingActivity);

        foreach(Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }

    }

}