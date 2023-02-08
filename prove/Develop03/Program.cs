using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture(2);
        string input = "";

        int hiddenWordCount = 0;
        int wordCount = scripture.GetWordListLength();
      
        while (input != "quit")
        {
            Console.Clear();
            scripture.HideWords(hiddenWordCount);
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Press enter or type quit: ");
            input = Console.ReadLine();
            hiddenWordCount++; 
        }

        Console.WriteLine("Goodbye!");
        Environment.Exit(0);
            
    }
}

