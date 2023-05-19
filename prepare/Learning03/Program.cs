using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction = new Fraction(5);

        Console.WriteLine(fraction.GetFractionString());
        Console.WriteLine(fraction.GetDecimalValue());

        fraction.SetTop(2);
        fraction.SetBottom(7);

        Console.WriteLine(fraction.GetFractionString());
        Console.WriteLine(fraction.GetDecimalValue());

        fraction.SetTop(12);
        fraction.SetBottom(3);

        Console.WriteLine(fraction.GetFractionString());
        Console.WriteLine(fraction.GetDecimalValue());
    }
}