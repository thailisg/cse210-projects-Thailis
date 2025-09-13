using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public void addEntry(Entry newEntry)
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
        using (StreamWriter save = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                save.WriteLine(entry.CsvAnswers());
            }
        }
        Console.WriteLine("Saved Correctly! :D");
    }
    

    public void LoadFromFile(string file)
    {
        if (File.Exists(file))
        {
            
        }
    }
}