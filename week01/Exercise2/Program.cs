using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();

        int numberUserInput = int.Parse(userInput);
        string letter = "";


        if (numberUserInput >= 90)
        {
            letter = "A";
        }
        else if (numberUserInput >= 80)
        {
            letter = "B";
        }
        else if (numberUserInput >= 70)
        {
            letter = "C";
        }
        else if (numberUserInput >= 60)
        {
            letter = "D";
        }
        else if (numberUserInput < 60)
        {
            letter = "F";
        }

        Console.WriteLine($"Your Grade is: {letter}");

        if (numberUserInput >= 70)
        {
            Console.WriteLine("Congratulations, You Have passed the course!");
        }
        else if (numberUserInput < 70)
        {
            Console.WriteLine("You have not passed the course. Better luck next time!");
        }


    }
}