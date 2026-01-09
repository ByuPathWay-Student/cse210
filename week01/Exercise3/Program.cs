using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your guess? ");
        string guess = Console.ReadLine();

        int numGuess = int.Parse(guess);

        Random randomNum = new Random();
        int magicNum = randomNum.Next(1, 101);

        while (numGuess != magicNum)
        {
            if (numGuess > magicNum)
            {
                Console.WriteLine("Lower");
            }
            if (numGuess < magicNum)
            {
                Console.WriteLine("Higher");
            }

            Console.Write("What is your guess? ");
            guess = Console.ReadLine();
            numGuess = int.Parse(guess);
            
            if (numGuess == magicNum)
            {
                Console.WriteLine("You Guessed it!");
            }
        }
    }
}