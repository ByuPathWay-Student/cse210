//I added so that it will get the time you started your entry and save that time to view later when you display or load.
using System;

class Program
{
    static void Main(string[] args)
    {
        DateTime currentDate = DateTime.Now;
        string dateText = currentDate.ToShortDateString();
        
        Journal userJournal = new Journal();
        Entry anEntry = new Entry();
        anEntry._date = dateText;
        PromptGenerator randomPrompt = new PromptGenerator();

        string userChoice = "0";
        while (userChoice != "5")
        {
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            userChoice = Console.ReadLine();
            if (userChoice == "1")
            {
                anEntry = new Entry();
                anEntry._promptText = randomPrompt.GetRandomPrompt();
                Console.WriteLine(anEntry._promptText);
                Console.Write(">");
                anEntry._entryText = Console.ReadLine();
                anEntry._date = currentDate.ToShortDateString();
                anEntry._entryTime = DateTime.Now.ToString("HH:mm");

                userJournal.AddEntry(anEntry);
            }
            else if (userChoice == "2")
            {
                userJournal.DisplayAll();
            }
            else if (userChoice == "3")
            {
                Console.WriteLine("What is the filename?");
                string filename = Console.ReadLine();
                userJournal.LoadFromFile(filename);
            }
            else if (userChoice == "4")
            {
                Console.WriteLine("What is the filename?");
                string filename = Console.ReadLine();
                userJournal.SaveToFile(filename);
            }
        }
    }
}