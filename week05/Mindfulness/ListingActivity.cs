using System;

public class ListingActivity: Activity
{
    private int _count;
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private Random random = new Random();

    public ListingActivity(): base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("List as many responses you can to the following prompt");

        GetRandomPrompt();

        Console.Write("You may begin in: ");
        ShowCountDown(5);

        List<string> listUser = GetListFromUser();
        _count = listUser.Count;

        Console.WriteLine($"You listed {_count} items");

        DisplayEndingMessage();

    }

    public void GetRandomPrompt()
    {
        int indexPrompt = random.Next(_prompts.Count);
        string prompt = _prompts[indexPrompt];
        Console.WriteLine($"---{prompt}---");
    }

    public List<string> GetListFromUser()
    {
        List<string> listFromUser = new List<string>();
        string inputUser = "";

        DateTime endtime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endtime)
        {
            Console.Write("> ");
            inputUser = Console.ReadLine();

            listFromUser.Add(inputUser);
        }

        return listFromUser;
    }
}