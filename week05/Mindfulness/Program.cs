using System;

class Program
{
    //Creativity: I add an extra option for anxiety attacks, where the person must identify real-life objects to come back to their senses.
    static void Main(string[] args)
    {
        int userElection = 0;

        Console.WriteLine("\nWelcome to Mindfulness Program\n");


        while (userElection != 5)
        {
            Console.WriteLine("1. Start breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start ListingActivity");
            Console.WriteLine("4. Stop anxiety crisis");
            Console.WriteLine("5. Quit\n");
            userElection = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            if (userElection == 1)
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Run();
            }

            else if (userElection == 2)
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.Run();
            }

            else if (userElection == 3)
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.Run();
            }

            else if (userElection == 4)
            {
                StopAnxiety stopAnxiety = new StopAnxiety();
                stopAnxiety.Run();
            }

            else if (userElection == 5)
            {
                Console.WriteLine("Thanks for playing! See you soon :D");
            }

            else
            {
                Console.WriteLine("Choose a valid option");
            }

        }
    }
}