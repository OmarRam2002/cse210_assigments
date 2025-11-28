using System;

class Program
{
    static void Main(string[] args)
    {
        
        MathAssignment mathAssignment = new MathAssignment("Section 7.3","Problems 8-19","Omar Ramirez","Fractions");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworklist());

        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History","The causes of World War");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingIformation());


    }
}