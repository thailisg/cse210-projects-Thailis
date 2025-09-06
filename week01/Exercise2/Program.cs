using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int number = int.Parse(userInput);

        int lastDigit = number % 10;
        string sign = "";

        string letter = "";

        //determine the letter

        if (number >= 90)
        {
            letter = "A";
        }
        else if (number >= 80)
        {
            letter = "B";
        }
        else if (number >= 70)
        {
            letter = "C";
        }
        else if (number >= 60)
        {
            letter = "D";
        }
        else if (number < 60)
        {
            letter = "F";
        }

        //statement + or -

        if (lastDigit >= 7)
        {
            sign = "+";
            if (letter == "A")
            {
                Console.WriteLine($"Your grade is: {letter}");
            }
            else if (letter == "F")
            {
                Console.WriteLine($"Your grade is: {letter}");
            }

            else
            {
                Console.WriteLine($"Your grade is: {letter}{sign}");
            }
        }

        else if (lastDigit < 3)
        {
            sign = "-";

            if (letter == "F")
            {
                Console.WriteLine($"Your grade is: {letter}");
            }
            else
            {
                Console.WriteLine($"Your grade is: {letter}{sign}");
            }
            
        }

        else
        {
            Console.WriteLine($"Your grade is: {letter}");
        }
        

        // message
        if (number >= 70)
        {
            Console.WriteLine("Congratulations! You passed. ");
        }
        else
        {
            Console.WriteLine("Nice try! good luck the next time. ");
        }


    }
}
    