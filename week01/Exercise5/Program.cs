using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string name = PromptUserName();
        int favoriteNumber = PromptUserNumber();

        int squareNumber = SquareNumber(favoriteNumber);

        DisplayResult(name, squareNumber);
        }

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();

            return userName;
        }
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string numberConsole = Console.ReadLine();
            int numberUser = int.Parse(numberConsole);

            return numberUser;
        }
        static int SquareNumber(int number)
        {
            int square = number * number;

            return square;
        }
        static void DisplayResult(string name, int square)
        {
            Console.Write($"{name}, the square of your number is: {square}");
        }
        
    
}