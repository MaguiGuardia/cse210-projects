using System;

class Program
{
    static void Main(string[] args)
    {
        Fractions F1 = new();
        Console.WriteLine(F1.GetFractionString());
        Console.WriteLine(F1.GetDecimalValue());

        Fractions F2 = new(6);
        Console.WriteLine(F2.GetFractionString());
        Console.WriteLine(F2.GetDecimalValue());

        Fractions F3 = new(6, 7);
        Console.WriteLine(F3.GetFractionString());
        Console.WriteLine(F3.GetDecimalValue());
    }


}