using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Journal 1.0");
        Console.WriteLine();
        Journal journal = new Journal();
        string menuOption = "";
        
        while (menuOption != "5") {
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            menuOption = Console.ReadLine();

            if (menuOption == "1") {
                journal.Write();
            } else if (menuOption == "2") {
                journal.DisplayJournal();
            } else if (menuOption == "3") {
                journal.LoadJournal();
            } else if (menuOption == "4") {
                journal.SaveJournal();
            } else if (menuOption == "5") {
                Console.WriteLine("Goodbye!");
                Environment.Exit(0);
            } else {
                Console.WriteLine("Please enter the number.");
            }
        }
        
    }
}