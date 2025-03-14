using System;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries to display");
            return;
        }
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter writer = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine($"Date: {entry._date} - Mood: {entry._entryMood} - Location: {entry._entryLocation} - Prompt: {entry._promptText} - Response: {entry._entryText}");
            }
        }
        Console.WriteLine("Journal save to file.");
    }

    public void LoadFromFile(string file)
    {
        if (File.Exists(file))
        {
            using (StreamReader reader = new StreamReader(file))
            {
                _entries.Clear();
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split("- ");
                    string date = parts[0].Replace("Date: ", "").Trim();
                    string entryMood = parts[1].Replace("Mood: ", "").Trim();
                    string entryLocation = parts[2].Replace("Location: ", "").Trim();
                    string promptText = parts[3].Replace("Prompt: ", "").Trim(); 
                    string entryText = parts[4].Replace("Response: ", "").Trim();
                    _entries.Add(new Entry(promptText, entryText, entryMood, entryLocation) { _date = date});
                }
            }
            Console.WriteLine("Journal loaded from file.");
        }
        else{
            Console.WriteLine("file not found.");
        }
    }
}