using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Tech Corp";

        job1.DisplayMethod();

        Job job2 = new Job();
        job2._jobTitle = "Data Analyst";
        job2._company = "Data Inc.";
        job2.DisplayMethod();

    }
}