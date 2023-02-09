using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture(); // omit '2' if you want only one verse
        string input = "";
        int hiddenWordCount = 0;

        int wordCount = scripture.GetWordListLength();
      
        while (input != "quit")
        {
            Console.Clear();
            // use the hiddenWordCount to determine how many words to hide
            scripture.HideWords(hiddenWordCount);
            Console.WriteLine();
            Console.Write("Press enter or type quit: ");
            input = Console.ReadLine();
            // increase the number of hidden words by 1 per iteration
            hiddenWordCount++; 
        }
        // exit if user inputs 'quit'
        Console.WriteLine("Goodbye!");
        Environment.Exit(0);
            
    }
}

