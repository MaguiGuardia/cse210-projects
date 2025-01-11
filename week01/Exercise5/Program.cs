using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the program");
    
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquaredNumber(userNumber);

        DisplayResult(userName, squaredNumber);

    }

    static string PromptUserName()
    {
        Console.Write("Please Enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;

    }

    static int SquaredNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, te square of your number is {square}");
    }
}
