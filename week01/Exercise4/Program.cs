using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int userInputNumber = -1;

        while (userInputNumber != 0)
        {
            Console.Write("Enter a list of numbers, type 0 when finished: ");
            userInputNumber = int.Parse(Console.ReadLine());
            if (userInputNumber != 0)
            {
                numbers.Add(userInputNumber);
            }
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        
        int average = sum / numbers.Count;
        int max = numbers.Max();
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
    }
}