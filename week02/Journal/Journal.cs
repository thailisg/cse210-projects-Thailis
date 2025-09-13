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
            save.WriteLine("Date, Prompt, Response");
        
            foreach (Entry entry in _entries)
            {
                save.WriteLine($"{entry._date},{entry._prompt}, {entry._input}");
            }
        }
        Console.WriteLine("Saved Correctly! :D");
    }


    public void LoadFromFile(string file)
    {
        if (File.Exists(file))
        {
            _entries.Clear();

            string[] lines = File.ReadAllLines(file);

            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];
                string[] parts = line.Split(",");

                Entry entry = new Entry
                {
                    _date = parts[0],
                    _prompt = parts[1],
                    _input = parts[2]
                };

                _entries.Add(entry);

            }

            Console.WriteLine("Loaded! Enjoy your answers ;D");
        }

        else
        {
            Console.WriteLine("The file was not found. D:");
        }
    }
}