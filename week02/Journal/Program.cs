using System;

class Program
{
    static void Main(string[] args)
    {
       Journal journal1 = new(); 

        while(true)
        {
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. save");
            Console.WriteLine("4. load");
            Console.WriteLine("5. quit");

            Console.Write("enter selection: ");
            string userImput = Console.ReadLine();

            Console.WriteLine($"user selected {userImput}");

            if (userImput == "1")
            {
                journal1.CreateNewEntry();

            }
            else if (userImput == "2")
            {
                Console.WriteLine("Display Journal");
            }
            else if (userImput == "3")
            {
                Console.WriteLine("Save Journal");
            }
            else if (userImput == "4")
            {
             
                Console.WriteLine("Write New Entry");
            }
            else if (userImput == "5")
            {
                
            }
            else 
            {
                Console.WriteLine("Please try again!");
            }
        }
        
    }
}