public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity() : base() 
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _prompts = new List<string>(){
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"};
    }
    
    public void Run()
    {
        this.DisplayStartingMessage();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        GetRandomPrompt();
        Console.Write("You may begin in: ");
        this.ShowCountDown(5);
        Console.WriteLine();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;
        _count = 0;
        while (currentTime < endTime)
        {
            GetListFromUser();
            _count += 1;
            currentTime = DateTime.Now;
        }
        Console.WriteLine($"You listed {_count} items!");
        this.DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {
        Random randomPrompt = new Random();
        int index = randomPrompt.Next(0,_prompts.Count);
        string prompt = _prompts[index];
        Console.WriteLine($"--- {prompt} ---");
    }

    public void GetListFromUser()
    {
        Console.Write(">");
        Console.ReadLine();

    }
}