using System;

class Program
{
    static void Main(string[] args)
    {
        Reference ref1 = new("1 Nephi", 3, 7);
        Console.WriteLine(ref1.GetDisplayText());

        Scripture scr1 = new("I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them");
        Console.WriteLine(scr1.GetDisplayText());
        
    }
}