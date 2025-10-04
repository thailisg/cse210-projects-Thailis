using System;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = 0;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}! :D");
        Console.WriteLine("");
        Console.WriteLine(_description);
        Console.WriteLine("");
        Console.WriteLine($"How long, in seconds, would you like for your session?");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine("Get Ready...");
        ShowSpinner(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Well Done! <3");
        ShowSpinner(3);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}");
        ShowSpinner(3);

    }

    public void ShowSpinner(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int dots = 1;

        while (DateTime.Now < endTime)
        {
            Console.Write("\r" + new string('.', dots));
            Thread.Sleep(1000);

            dots++;

            if (dots > 3)
            {
                dots = 1;
            }
        }

        Console.WriteLine("\r   \r");
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

        Console.WriteLine("Good Luck!");
    }

    public int GetDuration()
    {
        return _duration;
    }
}