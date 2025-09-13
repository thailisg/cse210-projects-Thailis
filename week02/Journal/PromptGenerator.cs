using System;
using System.Collections.Generic;
using System.IO;

public class PromptGenerator
{
    public Random random = new Random();

    public string GetRandomPrompt(string fileCsv)
    {
        if (File.Exists(fileCsv))
        {
            string[] lines = File.ReadAllLines(fileCsv);
            int index = random.Next(lines.Length);
            return lines[index];
        }

        else
        {
            Console.WriteLine("The file was not found. D:");
            return null;
        }
    }
}
