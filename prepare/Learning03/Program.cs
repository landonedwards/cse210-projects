using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction = new(4);

        // fraction.SetNumerator(2);
        fraction.SetDenominator(7);

        Console.WriteLine(fraction.GetFractionString());
        Console.WriteLine(fraction.GetDecimalValue());

        Fraction fraction2 = new(5,23);

        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimalValue());
    }
}