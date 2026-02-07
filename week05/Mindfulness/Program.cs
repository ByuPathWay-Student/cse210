using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity bActivity = new BreathingActivity();
        ReflectingActivity rActivity = new ReflectingActivity();
        ListingActivity lActivity = new ListingActivity();
        
        string input = "";
        while (input != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            input = Console.ReadLine();
            if (input == "1")
            {
                bActivity.Run();
            }
            else if (input == "2")
            {
                rActivity.Run();
            }
            else if (input == "3")
            {
                lActivity.Run();
            }
        }
    }
}