public class BreathingActivity : Activity
{
    public BreathingActivity() : base()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }
   
    public void Run()
    {
        this.DisplayStartingMessage();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;
        while (currentTime < endTime)
        {
            Console.WriteLine();
            Console.Write("Breathe in...");
            this.ShowCountDown(6);
            Console.WriteLine();
            Console.Write("Breathe out...");
            this.ShowCountDown(4);
            currentTime = DateTime.Now;
        }
        
        this.DisplayEndingMessage(); 
    }
}