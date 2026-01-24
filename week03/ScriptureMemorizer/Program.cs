// I made a new class called 'ScriptureDatabase' that gets randoms scriptures out of a list.
using System;

class Program
{
    static void Main(string[] args)
    {
        ScriptureDatabase scriptureDatabase = new ScriptureDatabase();
        Scripture scripture = scriptureDatabase.GetRandomScripture();
        string answer = "";
        int wordsToHide = 3;

        bool fullyHidden = false;
        while (answer != "quit" && !fullyHidden)
        {
            Console.Clear();
            Console.WriteLine($"{scripture.GetDisplayText()}");
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            answer = Console.ReadLine();
            if (answer == "")
            {
                fullyHidden = scripture.IsCompletelyHidden();
                scripture.HideRandomWords(wordsToHide);
                
            }
        }

    }
}