using System.Reflection.Metadata;
using System.Threading.Channels;

public class GoalManager
{
    private int _score;
    private List<Goal> _goals = new List<Goal>();

    public GoalManager()
    {
        _score = 0;
    }
    //Start funtion. This is the main funtion, it will handle all the menu funcionality
    public void start()
    {
        string userinput = "0";
        while (userinput != "6")
        {   
            DisplayPlayerInfo();
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("\t1. Create New Goal");
            Console.WriteLine("\t2. Lists Goals");
            Console.WriteLine("\t3. Save Goals");
            Console.WriteLine("\t4. Load Goals");
            Console.WriteLine("\t5. Record Event");
            Console.WriteLine("\t6. Quit");
            Console.Write("Select a choice from the menu: ");
            userinput = Console.ReadLine();

            if(userinput == "1")
            {
                CreateNewGoal();
            }
            if(userinput == "2")
            {
                ListGoalDetails();
            }
            if(userinput == "3")
            {
                SaveGoals();
            }
            if(userinput == "4")
            {
                LoadGoals();
            }
            if(userinput == "5")
            {
                RecordEvent();
            }
        }
    }
    //Will display the user score
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points");
    }
    // Thsi function will return the name of all the goals
    public void ListGoalsNames()
    {
        int count = 0;    
        foreach (Goal goal in _goals)
        {
            count +=1;
            Console.WriteLine($"{count}. {goal.GetGoalname()}"); 
        }
    }
    //Thiw will list all the details about the goal
    public void ListGoalDetails()
    {
        int count = 0;
        foreach(Goal goal in _goals)
        {
            count +=1;
            Console.WriteLine($"{count}. {goal.GetDetailsString()}");
        }
    }
    public void CreateNewGoal()
    {
        string goaltype ;
        string name ;
        string description;
        string points;
        Console.Clear();
        Console.WriteLine("The types of goals are");
        Console.WriteLine("\t1. Simple Goal");
        Console.WriteLine("\t2. Eternal Goal");
        Console.WriteLine("\t3. Checklist Goal");
        Console.Write("Which type of goal would you like to create?");
        goaltype = Console.ReadLine();
        Console.Write("What is the name of your goal?");
        name = Console.ReadLine();
        Console.Write("What is the description of it?");
        description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal?");
        points = Console.ReadLine();

        if (goaltype == "1")
        {
            SimpleGoal simpleGoal = new SimpleGoal(name,description, points);
            _goals.Add(simpleGoal);
        }
        if (goaltype == "2")
        {
            EternalGoal eternalGoal = new EternalGoal(name,description, points);
            _goals.Add(eternalGoal);
        }
        if (goaltype == "3")
        {   
            int target;
            int bonus;
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            bonus = int.Parse(Console.ReadLine());
            ChecklistGoal checklistGoal = new ChecklistGoal(name,description,points,target,bonus);
            _goals.Add(checklistGoal);
        }
        
    }

    public void RecordEvent()
    {
        int goalCompleted;
        Console.WriteLine("The goals are:");
        ListGoalsNames();
        Console.WriteLine("Which one did you accomplish? ");
        goalCompleted = int.Parse(Console.ReadLine());
        for (int i= 0; i < _goals.Count; i++)
        {
            if (goalCompleted -1 == i)
            {
                _score += _goals[i].RecordEvent();
            }   
        }

    }
    public void SaveGoals()
    {
        string file ="";
        Console.Write("What is the name of the file? ");
        file = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentaion());
            }
        }
    }
    //THis will load all the goals from a file.
    public void LoadGoals()
    {
        string file ="";
        Console.Write("What is the name of the file? ");
        file = Console.ReadLine();
        string [] lines = System.IO.File.ReadAllLines(file);
        _score = int.Parse(lines[0]);

        foreach(string line in lines.Skip(1))
        {
            string[] parts = line.Split(",");
            string typeOfGoal = parts[0];
            string name = parts[1];
            string description = parts[2];
            string points = parts[3];
            if (typeOfGoal == "SimpleGoal")
            {
                SimpleGoal simpleGoal = new SimpleGoal(name,description,points);
                string isComplete = parts[4];
                if (isComplete == "True")
                {
                    simpleGoal.RecordEvent();
                }
                _goals.Add(simpleGoal);

            }
            if (typeOfGoal == "EternalGoal")
            {
                EternalGoal eternalGoal = new EternalGoal(name, description, points);
                _goals.Add(eternalGoal);
            }
            if (typeOfGoal == "ChecklistGoal")
            {
                int bonus = int.Parse(parts[4]);
                int  target= int.Parse(parts[5]);
                int amoutcompleted = int.Parse(parts[6]);
                ChecklistGoal checklistGoal = new ChecklistGoal(name,description,points,target,bonus);
                checklistGoal.SetAmountCompleted(amoutcompleted);
                _goals.Add(checklistGoal);

            }
        }
    }

    


}