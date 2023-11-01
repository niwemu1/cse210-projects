using System;

class Program
{
    static void Main(string[] args)
    {
        
        Random randomGenerator = new Random();
        
        int magicNumber = randomGenerator.Next(1, 101);
        Console.WriteLine("What is the magic number? ");
        magicNumber = int.Parse(Console.ReadLine());

        int guess = -1;

        // We could also use a do-while loop here...
        while (guess != magicNumber)
        {
          
            Console.WriteLine("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }

        }                    
    }
}