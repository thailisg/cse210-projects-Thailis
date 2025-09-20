using System;
using System.Collections.Generic;
using System.IO;

public class ScriptureLibrery
{
    private List<Scripture> _scriptures = new List<Scripture>();
    private Random random = new Random();

    public ScriptureLibrery(string fileTxt)
    {
        string[] readLines = File.ReadAllLines(fileTxt);

        foreach (string readLine in readLines)
        {
            string[] separator = readLine.Split("|");

            string book = separator[0];
            int chapter = int.Parse(separator[1]);
            int verse = int.Parse(separator[2]);
            int endVerse = int.Parse(separator[3]);
            string text = separator[4];

            Reference reference;

            if (endVerse == 0)
            {
                reference = new Reference(book, chapter, verse);
            }

            else
            {
                reference = new Reference(book, chapter, verse, endVerse);
            }

            Scripture scripture = new Scripture(reference, text);
            _scriptures.Add(scripture);
        }

    }

    public Scripture GetRandomScripture()
    {
        int index = random.Next(_scriptures.Count);
        return _scriptures[index];
    }
}