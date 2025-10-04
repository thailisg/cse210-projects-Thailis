using System;
using System.Collections.Generic;
using System.IO;

public class ReflectingActivity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    private string description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

    private Random random = new Random();
    public ReflectingActivity()
    {

    }

    public void Run()
    {
        Activity activity = new Activity("Reflecting Activity", description);

        activity.DisplayStartingMessage();

        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine("");

        DisplayPrompt();

        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.Write($"Now ponder on each of the following questions as they related to this experience. You may begin in: ");
        activity.ShowCountDown(5);

        int totalDuration = activity.GetDuration();

        int initialTime = 0;

        while (initialTime < totalDuration)
        {
            Console.WriteLine("");
            DisplayQuestion();
            activity.ShowSpinner(10);
            initialTime += 10;
        }

        activity.DisplayEndingMessage();

    }

    public string GetRandomPrompt()
    {
        int indexPrompt = random.Next(_prompts.Count);
        return _prompts[indexPrompt];
    }

    public string GetRandomQuestion()
    {
        int indexQuestion = random.Next(_questions.Count);
        return _questions[indexQuestion];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine($"---{GetRandomPrompt()}---");
    }

    public void DisplayQuestion()
    {
        Console.WriteLine($"> {GetRandomQuestion()}");
    }
}