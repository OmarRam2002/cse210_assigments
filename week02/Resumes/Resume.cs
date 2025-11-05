using System.Security.Authentication.ExtendedProtection;
using System.Security.Cryptography.X509Certificates;

public class Resume
{
    public string _name;

    public List<Job> _jobs = new List<Job>();

    public void DisplayMethod()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        foreach (Job jobb in _jobs)
        {
            jobb.DisplayMethod();
        }


    }

}