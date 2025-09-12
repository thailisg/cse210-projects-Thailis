using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");
        PromptGenerator generator = new PromptGenerator();
        string prompt = generator.GetRandomPrompt("prompts.csv");
        Console.WriteLine($"{prompt}");
    }
}