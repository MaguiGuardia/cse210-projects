        Console.Write("what is the magic number?");
        int magicNumber = int.Parse(Console.ReadLine());
        Console.Write("Whats your guess? ");
        int userNumber = int.Parse(Console.ReadLine());
        
        if (userNumber == magicNumber)
        {
                Console.Write("you guessed it");
        }
        else if (userNumber > magicNumber)
        {
                Console.Write("Lower");
        }
        else 
        {
                Console.Write("Higher");
        }
