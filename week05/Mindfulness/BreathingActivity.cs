using System;

public class BreathingActivity
{
    private string description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    public BreathingActivity()
    {

    }

    public void Run()
    {
        Activity activity = new Activity("Breathing Activity", description);

        activity.DisplayStartingMessage();

        int totalDuration = activity.GetDuration();

        int initialTime = 0;

        while (initialTime < totalDuration)
        {

            Console.WriteLine("Breathe in...");
            activity.ShowCountDown(4);
            initialTime += 4;

            Console.WriteLine("Hold the air");
            activity.ShowCountDown(4);
            initialTime += 4;

            Console.WriteLine("Now breathe out...");
            activity.ShowCountDown(4);
            initialTime += 4;

        }

        activity.DisplayEndingMessage();
    }
}