public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    public string _entryTime;

    public void Display()
    {
        Console.WriteLine($"Date: {_date} Time: {_entryTime} - Prompt: {_promptText}");
        Console.WriteLine(_entryText);
        Console.WriteLine();
    }
}