using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your first name? ");
        string name = Console.ReadLine();

        Console.WriteLine("What is your last name? ");
        string last_name = Console.ReadLine();

        Console.WriteLine($"Your name is {last_name}, {name} {last_name}. ");

        Console.WriteLine("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        float number = int.Parse(userInput);

        string letter = "";

        if (number >= 90)
        {
            letter = "A";
        }
        else if (number >= 80)
        {
            letter = "B";
        }
        else if (number >= 70)
        {
            letter = "C";
        }
        else if (number >= 60)
        {
            letter = "D";
        }
        else if (number < 60)
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");

        // message
        if (number >= 70)
        {
            Console.WriteLine("Congratulations! You passed. ");
        }
        else
        {
            Console.WriteLine("Nice try! good luck the next time. ");
        }
    }
}