internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("what is the magic number? ");
        int magicNumber = int.Parse(Console.ReadLine());


        int userNumber = -1;

        while (userNumber != magicNumber)
        {
            Console.Write("Whats your guess? ");
            userNumber = int.Parse(Console.ReadLine());

            if (userNumber == magicNumber)
            {
                Console.Write("you guessed it");
            }
            else if (userNumber > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Higher");
            }
        }
    }
}