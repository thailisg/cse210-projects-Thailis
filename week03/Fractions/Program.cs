using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        Fractions fraction1 = new Fractions();
        Fractions fraction2 = new Fractions(5);
        Fractions fraction3 = new Fractions(3, 4);
        Fractions fraction4 = new Fractions(1, 3);

        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());

        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimalValue());

        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());

        Console.WriteLine(fraction4.GetFractionString());
        Console.WriteLine(fraction4.GetDecimalValue());

    }
}