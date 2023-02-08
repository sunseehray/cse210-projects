using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture();
        string input = "";

        int hiddenWordCount = 0;
        int wordCount = scripture.GetWordListLength();
      
        while (hiddenWordCount < wordCount)
        {
            scripture.HideWords(1);
            Console.Clear();
            scripture.Display();
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Press enter or type quit: ");
            input = Console.ReadLine();

            if (input == "quit")
            {
                break;
            }
            else
            {
                hiddenWordCount++;
            }
        }
            
    }
}

