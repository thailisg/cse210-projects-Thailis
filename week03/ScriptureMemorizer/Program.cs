using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Scripture Memorizer Program. :p");

        string filepath = "scriptures.txt";

        if (!File.Exists(filepath))
        {
            using (StreamWriter streamWriter = new StreamWriter(filepath))
            {
                streamWriter.WriteLine("Proverbs|3|5|6|Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");

                streamWriter.WriteLine("John|3|16|0|For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");

                streamWriter.WriteLine("Habakkuk|3|19|0|The Lord God is my strength, and he will make my feet like hinds' feet, and he will make me to walk upon mine high places.");

                streamWriter.WriteLine("Zephaniah|3|17|0|The Lord thy God in the midst of thee is mighty; he will save, he will rejoice over thee with joy; he will rest in his love, he will joy over thee with singing.");

                streamWriter.WriteLine("Nahum|1|7|0|The Lord is good, a strong hold in the day of trouble; and he knoweth them that trust in him.");

                streamWriter.WriteLine("Micah|7|8|0|When I sit in darkness, the Lord shall be a light unto me.");

                streamWriter.WriteLine("Isaiah|41|10|0|Fear thou not; for I am with thee: be not dismayed; for I am thy God: I will strengthen thee; yea, I will help thee; yea, I will uphold thee with the right hand of my righteousness.");

                streamWriter.WriteLine("Romans|15|13|0|Now the God of hope fill you with all joy and peace in believing, that ye may abound in hope, through the power of the Holy Ghost.");

            }

        }

        ScriptureLibrery librery = new ScriptureLibrery(filepath);

        Scripture scripture = librery.GetRandomScripture();

        Console.WriteLine(scripture.GetDisplayText());
        Console.ReadLine();

        string input = "";

        while (input != "quit" && !scripture.IsCompletelyHidden())
        {

            scripture.HideRandomWords(3);
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress enter to continue or type quit to finish the program. :D");
            input = Console.ReadLine();

        }

        Console.WriteLine("Thank you for playing C:");

    }
}