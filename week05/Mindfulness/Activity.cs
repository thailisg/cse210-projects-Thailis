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
        Console.WriteLine($"\nWell Done! <3");
        ShowSpinner(3);
        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_name}\n");
        ShowSpinner(3);

    }

    public void ShowSpinner(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int dots = 1;
        int maxDots = 3;

        while (DateTime.Now < endTime)
        {
            Console.Write("\r" + new string(' ', maxDots) + "\r");
            Console.Write(new string('.', dots));
            Thread.Sleep(500);

            dots++;

            if (dots > maxDots)
            {
                dots = 1;
            }
        }

        Console.Write("\r" + new string(' ', maxDots) + "\r");
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public int GetDuration()
    {
        return _duration;
    }
}