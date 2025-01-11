using System;

class Program
{
    static void main(string[] args)
    {
        Console.WriteLine("Welcome to the program");
    
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = squaredNumber (userNumber);

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

    }
    static int DisplayResult (int userNumber)
    {
        int 
    }
}
