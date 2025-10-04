using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");

        Assignment assignment = new Assignment("jose", "fractions");
        Console.WriteLine(assignment.GetSummary());

        MathAssignment mathAssignment = new MathAssignment("Section 7.3", "Problems 8-19", "Jose", "Multiplicacion");
        Console.WriteLine(mathAssignment.GetHomeWorkList());

        WritingAssignment writingAssignment = new WritingAssignment("The Causes of World War II by Mary Waters", "Mary Waters", "History");
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}