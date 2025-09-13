using System;
using System.Collections.Generic;
using System.IO;

public class PromptGenerator
{
    public Random random = new Random();

    public string GetRandomPrompt(string fileCsv)
    {
        try
        {
            List<string> prompts = new List<string>(File.ReadAllLines(fileCsv));

            if (prompts.Count == 0)
                return "No more prompts.";

            int index = random.Next(prompts.Count);

            return prompts[index];
        }
        catch (Exception e)
        {
            Console.WriteLine("The file could not be read:");
            Console.WriteLine(e.Message);
            return null;
        }
    }
}
