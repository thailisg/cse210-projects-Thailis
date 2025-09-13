using System;
using Microsoft.VisualBasic.FileIO;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        string choiceOfMenu = "";
        
        Console.WriteLine("Welcome to the Journal! :D");

        while (choiceOfMenu != "5" && choiceOfMenu.ToLower() != "quit")
        {

            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do today? :D");
            choiceOfMenu = Console.ReadLine();

            if (choiceOfMenu == "1" || choiceOfMenu.ToLower() == "write")
            {
                PromptGenerator generator = new PromptGenerator();
                string prompt = generator.GetRandomPrompt();
                Console.WriteLine($"{prompt}");
                string response = Console.ReadLine();

                Entry newEntry = new Entry();
                newEntry._date = DateTime.Now.ToString();
                newEntry._prompt = prompt;
                newEntry._input = response;

                journal.addEntry(newEntry);

                Console.WriteLine("Good Answer! Saved. c;");
            }

            else if (choiceOfMenu == "2" || choiceOfMenu.ToLower() == "display")
            {
                journal.DisplayAll();
            }

            else if (choiceOfMenu == "3" || choiceOfMenu.ToLower() == "load")
            {
                Console.WriteLine("What is the filename: ");
                string userFilename = Console.ReadLine();

                journal.LoadFromFile(userFilename);

                foreach (Entry entry in journal._entries)
                {
                    Console.WriteLine($"Date: {entry._date} - Prompt: {entry._prompt}");
                    Console.WriteLine($"Answer: {entry._input}");
                }

            }

            else if (choiceOfMenu == "4" || choiceOfMenu.ToLower() == "save")
            {
                Console.WriteLine("What is the filename?");
                string userFilename2 = Console.ReadLine();
                journal.SaveToFile(userFilename2);
            }

            else if (choiceOfMenu == "5" || choiceOfMenu.ToLower() == "quit")
            {
                Console.WriteLine("Byeee! Have a good day! Sincerely your Journal!");
            }

            else
            {
                Console.WriteLine("Choose a valid option! >:c");
            }
        }


    }
}