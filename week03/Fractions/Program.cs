using System;

class Program
{
    static void Main(string[] args)
    {
        Fractions fraction1 = new Fractions();
        Fractions fraction2 = new Fractions(5);
        Fractions fraction3 = new Fractions(3, 4);
        Fractions fraction4 = new Fractions(1, 3);
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.getDecimalValue());
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.getDecimalValue());
        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.getDecimalValue());
        Console.WriteLine(fraction4.GetFractionString());
        Console.WriteLine(fraction4.getDecimalValue());

    }
}