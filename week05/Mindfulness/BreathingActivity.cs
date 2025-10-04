using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {

    }

    public void Run()
    {

        DisplayStartingMessage();

        int totalDuration = GetDuration();

        int initialTime = 0;

        while (initialTime < totalDuration)
        {

            Console.WriteLine("Breathe in...\n");
            ShowCountDown(4);
            initialTime += 4;

            Console.WriteLine("Hold the air\n");
            ShowCountDown(4);
            initialTime += 4;

            Console.WriteLine("Now breathe out...\n");
            ShowCountDown(4);
            initialTime += 4;

        }

        DisplayEndingMessage();
    }
}