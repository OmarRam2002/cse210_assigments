using System;

class Program
{
    static void Main(string[] args)
    {
        
        int randomNumber = new Random().Next(1, 101);
        int userGuessInput;
        int guessCount = 0;

        do
        {
            Console.Write("What is your guess? ");
            userGuessInput = int.Parse(Console.ReadLine());
            guessCount++;
            if (randomNumber == userGuessInput)
            {
                Console.WriteLine("You guessed it.");
            }
            else if (userGuessInput < randomNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("Lower");
            }
        } while (randomNumber != userGuessInput);

        Console.WriteLine($"It took you {guessCount} guesses.");
    }
}