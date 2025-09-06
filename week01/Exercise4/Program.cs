using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int number = -1;
        float sum = 0;

        while (number != 0)
        {

            Console.WriteLine("Enter a number: ");
            string userInput2 = Console.ReadLine();
            number = int.Parse(userInput2);

            if (number != 0)
            {
                numbers.Add(number);
            }

        }

        foreach (int i in numbers)
        {
            sum += i;
        }

        int max = numbers[0];
        int min = numbers[0];

        foreach (int maxNumber in numbers)
        {
            if (maxNumber > max)
            {
                max = maxNumber;
            }
        }

        foreach (int minNumber in numbers)
        {
            if (minNumber < min && minNumber > 0)
            {
                min = minNumber;
            }
        }

        numbers.Sort();

        float count = numbers.Count;

        float average = sum / count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
        Console.WriteLine($"The largest number is: {min}");
        Console.WriteLine($"The sorted list is:");

        foreach (int listOrganized in numbers)
        {
            Console.WriteLine(listOrganized);
        }

        Console.WriteLine("Thank you for use the program. :D");
        
    }
}