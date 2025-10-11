using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager()
    {
        _score = 0;
    }

    public void Start()
    {
        Console.WriteLine("Welcome to Eternal Quest Program! :D\n");

        int userElection = 0;
        while (userElection != 6)
        {
            DisplayPlayerInfo();

            Console.WriteLine("Menu Options:\n");

            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");

            Console.Write("\nSelect a choice from menu: ");
            userElection = int.Parse(Console.ReadLine());

            if (userElection == 1)
            {
                CreateGoal();
            }

            else if (userElection == 2)
            {
                ListGoalDetails();
            }

            else if (userElection == 3)
            {
                SaveGoals();
            }

            else if (userElection == 4)
            {
                LoadGoals();
            }

            else if (userElection == 5)
            {
                RecordEvent();
            }

            else if (userElection == 6)
            {
                Console.WriteLine("Thanks for playing! :D Never forget to be consistent to succeed ;)");
            }

            else
            {
                Console.WriteLine("Choose a valid option >:( \n");
            }
    }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points. \n");
    }

    public void ListGoalNames()
    {
        int count = 1;

        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{count}. {goal.GetNames()}");
            count++;
        }

        Console.WriteLine();
    }

    public void ListGoalDetails()
    {
        int count = 1;

        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{count}. {goal.GetStringRepresentation()}");
            count++;
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("\nThe types of Goals are:\n");

        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        Console.Write("Which type of goal would you like to create? ");

        int typeOfGoal = int.Parse(Console.ReadLine());
        

        Console.Write("What is the name of your goal? ");

        string nameOfGoal = Console.ReadLine();

        Console.Write("What is a short description of it? ");

        string descriptionOfGoal = Console.ReadLine();

        Console.WriteLine("What is the amount of points associated with this goal? ");

        int score = int.Parse(Console.ReadLine());

        Goal goal;

        if (typeOfGoal == 1)
        {
            goal = new SimpleGoal(nameOfGoal, descriptionOfGoal, score);
        }

        else if (typeOfGoal == 2)
        {
            goal = new EternalGoal(nameOfGoal, descriptionOfGoal, score);
        }

        else if (typeOfGoal == 3)
        {
            Console.Write("What is the target number of completions? ");
            int target = int.Parse(Console.ReadLine());

            Console.WriteLine("What is the bonus for completing it? ");
            int bonus = int.Parse(Console.ReadLine());

            goal = new ChecklistGoal(nameOfGoal, descriptionOfGoal, score, target, bonus);
        }

        else
        {
            Console.WriteLine("Choose a valid option >:(");
            return;
        }

        _goals.Add(goal);
        Console.WriteLine("Your goal has been created! :D");
    }

    public void RecordEvent()
    {
        Console.WriteLine("The goals are:\n");

        ListGoalNames();

        Console.Write("Which Goal did you accomplish? ");

        int goalCompleted = int.Parse(Console.ReadLine());

        Goal goal = _goals[goalCompleted - 1];

        goal.RecordEvent();

        int pointsEarned = goal.GetPoints();

        if (goal is ChecklistGoal checklist && checklist.IsComplete())
        {
            pointsEarned += checklist.GetBonus();
        }

        _score += pointsEarned;

        Console.WriteLine($"\nCongratulations! You have earned {pointsEarned} points! WOHOO!");

        Console.WriteLine($"You now have {_score}.");
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputfile = new StreamWriter(filename))
        {
            outputfile.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                outputfile.WriteLine(goal.GetStringRepresentation());
            }
        }

    }
    
    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        string[] lines = File.ReadAllLines(filename);

        _score = int.Parse(lines[0]);

        foreach (string line in lines.Skip(1))
        {
            Console.WriteLine(line);
        }
    }
}