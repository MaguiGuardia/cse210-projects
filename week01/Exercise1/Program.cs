using System;

class Program
{
    static void Main(string[] args)
    { 
        Console.Write("What is your first name?"); 
        string name = Console.ReadLine ();

        Console.WriteLine(name);

        Console.Write("What is your last name? ");
        string lastname = Console.ReadLine ();

        Console.Write(lastname);
    }
}