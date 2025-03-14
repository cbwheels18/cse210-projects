using System;

public class Entry
{
   public string _date;
   public string _promptText;
   public string _entryText;

   public string _entryMood;

   public string _entryLocation;

   public Entry(string promptText, string entryText, string entryMood, string entryLocation)
   {
      _date = DateTime.Now.ToString("yyyy-MM-dd");
      _promptText = promptText;
      _entryText = entryText;
      _entryMood = entryMood;
      _entryLocation = entryLocation;
   }

   public void Display()
   {
      Console.WriteLine($"Date: {_date} - Mood: {_entryMood} - Location: {_entryLocation} - Prompt: {_promptText} - Entry: {_entryText}");
      Console.WriteLine();  
   }
}