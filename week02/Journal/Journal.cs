using System.IO;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._entryText}|{entry._promptText}|{entry._entryTime}");
            }
        }
    }

    public void LoadFromFile(string file)
    {
        _entries = new List<Entry>();

        string[] lines = System.IO.File.ReadAllLines(file);
        foreach (string line in lines)
        {
            Entry loadEntry = new Entry();
            string[] parts = line.Split("|");

            loadEntry._date = parts[0];
            loadEntry._entryText = parts[1];
            loadEntry._promptText = parts[2];
            loadEntry._entryTime = parts[3];
            
            _entries.Add(loadEntry);
        }
    }
    
}