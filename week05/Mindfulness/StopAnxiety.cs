using System;

public class StopAnxiety : Activity
{
    private List<string> _fiveSenses = new List<string>
    {
        "Identify one thing you can see",
        "Identify one thing you can touch",
        "Identify one thing you can hear",
        "Identify one thing you can smell",
        "Identify one thing you can taste"
    };

    public StopAnxiety() : base("Stop anxiety crisis", "This activity is for times when you feel overwhelmed by anxiety so you can calm down. You will identify a series of objects for each of your senses.")
    {

    }

    public void Run()
    {
        DisplayStartingMessage2();

        Console.WriteLine("Remember, the objects you can see, look at them. The ones you can touch, touch them. The ones you can hear, listen to them. The ones you can smell, smell them. And the ones you can taste, taste them.");

        DisplayFiveSenses();

        DisplayEndingMessage();
    }

    public void DisplayStartingMessage2()
    {
        Console.WriteLine("Welcome to Stop Anxiety Activity!\n");
        Console.WriteLine("This activity is for when you're feeling overwhelmed. There's no time limit.\n");

        Console.WriteLine("Get Ready...");
        ShowSpinner(3);
    }

    public string GetFiveSenses(string question)
    {
        Console.WriteLine("\n" + question);
        ShowSpinner(3);

        Console.WriteLine("\nTake a moment, then write what comes to mind:");
        Console.Write(">");
        string answerUser = Console.ReadLine();

        return answerUser;
    }

    public void DisplayFiveSenses()
    {
        List<string> answers = new List<string>();

        foreach (string fiveSenses in _fiveSenses)
        {
            string answer = GetFiveSenses(fiveSenses);
            answers.Add(answer);

            ShowSpinner(2);
        }


    }
}