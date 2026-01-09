using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string inputName = PromptUserName();
        
        int inputNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(inputNumber);

        DisplayResult(inputName, squaredNumber);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string input = Console.ReadLine();
        int number = int.Parse(input);
        return number;
    }

    static int SquareNumber(int number)
    {
        int squaredNum = number * number;
        return squaredNum;
    }

    static void DisplayResult(string name, int number)
    {
        Console.WriteLine($"{name}, the square of your number is {number}");
    }
}