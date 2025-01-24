using System;

class Program
{
    static void Main(string[] args)
    {
        Fractions F1 = new();
        Console.WriteLine(F1.GetFractionString());
        Console.WriteLine(F1.GetDecimalValue());

        Fractions F2 = new(5);
        Console.WriteLine(F2.GetFractionString());
        Console.WriteLine(F2.GetDecimalValue());

        Fractions F3 = new(3, 4);
        Console.WriteLine(F3.GetFractionString());
        Console.WriteLine(F3.GetDecimalValue());

        Fractions F4 = new(1, 3);
        Console.WriteLine(F4.GetFractionString());
        Console.WriteLine(F4.GetDecimalValue());
        
    }


}