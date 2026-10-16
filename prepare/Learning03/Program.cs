using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        Fraction testFraction = new Fraction();
        testFraction.FractionOne();
        Console.WriteLine(testFraction.GetFraction());
        Console.WriteLine(testFraction.GetDecimal());

        testFraction.FractionTwo(5);
        Console.WriteLine(testFraction.GetFraction());
        Console.WriteLine(testFraction.GetDecimal());

        testFraction.FractionThree(3, 4);
        Console.WriteLine(testFraction.GetFraction());
        Console.WriteLine(testFraction.GetDecimal());

        testFraction.FractionThree(1, 3);
        Console.WriteLine(testFraction.GetFraction());
        Console.WriteLine(testFraction.GetDecimal());

        testFraction.SetTop(3);
        testFraction.SetBottom(9);

        Console.WriteLine(testFraction.GetFraction());
        Console.WriteLine(testFraction.GetDecimal());
    }
}