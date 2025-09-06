using System;

class Program
{
    static void Main(string[] args)
    {
        string keepPlaying = "yes";

        while (keepPlaying == "yes" || keepPlaying == "Yes")
        {

            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            //Console.WriteLine($"{magicNumber}"); //in case of test

            int guessNumber = 0;
            int attempsCounter = 0;

            while (guessNumber != magicNumber)
            {
                Console.Write("What is your guess? ");
                string userInput2 = Console.ReadLine();
                guessNumber = int.Parse(userInput2);

                attempsCounter++;

                if (guessNumber > magicNumber)
                {
                    Console.WriteLine("Lower");
                }

                else if (guessNumber < magicNumber)
                {
                    Console.WriteLine("Higher");
                }

                else if (guessNumber == magicNumber)
                {
                    Console.WriteLine($"You guessed it! you tried {attempsCounter} times.");
                }

            }

            Console.WriteLine($"Do you want to keep playing? (yes/no)");
            keepPlaying = Console.ReadLine();

        }

    }
}