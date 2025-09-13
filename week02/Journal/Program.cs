using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        Console.WriteLine("Welcome to the Journal! :D");
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.WriteLine("What would you like to do today? :D");
        string choiceOfMenu = Console.ReadLine();

        if (choiceOfMenu == "1" || choiceOfMenu.ToLower() == "write")
        {
            PromptGenerator generator = new PromptGenerator();
            string prompt = generator.GetRandomPrompt("prompts.csv");
            Console.WriteLine($"{prompt}");
            string response = Console.ReadLine();
        }

        else if (choiceOfMenu == "2" || choiceOfMenu == "Display")
        {
            journal.DisplayAll();
        }


    }
}