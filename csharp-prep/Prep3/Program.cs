using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        string response = "yes";
        while (response == "yes")
        {
            Random randomGenerator = new Random();
            int myrandom = randomGenerator.Next(1,11);

            Console.Write("What is the magic number? ");
            int magicNumber = int.Parse(Console.ReadLine());
            int increment = 0;
            int userGuess = 0;
            while(userGuess != myrandom)
            {
                Console.Write("What is your guess? ");
                userGuess = int.Parse(Console.ReadLine());
                increment++;

                if (userGuess< myrandom)
                {
                    Console.WriteLine("Higher");
                }
                else if (userGuess>myrandom)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"It took you {increment} guesses to guess it right.");
                    
                }

            }

            Console.Write("Do you wish to play again? ");
            response = Console.ReadLine().ToLower();
           
        }
       
    }

}