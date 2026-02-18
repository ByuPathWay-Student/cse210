using System;

class Program
{
    static void Main(string[] args)
    {
       List<Activity> activities = new List<Activity>();
       
       Running running = new Running("17 Feb 2026", 30, 3.5);
       activities.Add(running);
       
       Bicycle bicycle = new Bicycle("18 Feb 2026", 60, 10.5);
       activities.Add(bicycle);

       Swimming swimming = new Swimming("19 Feb 2026", 50, 25);
       activities.Add(swimming);

       Console.Clear();
       
       foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
        }
    }
}