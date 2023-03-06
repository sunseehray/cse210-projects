using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");
        string menuSelected = "";

        while (menuSelected != "6") {
            Console.WriteLine("You have X points.");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.WriteLine("Select a choice from the menu: ");

            // get user menu selected
            menuSelected = Console.ReadLine();

            if (menuSelected == "1") {
                // create a goal
            } else if (menuSelected == "2") {
                // list goals
            } else if (menuSelected == "3") {
                // save goals
            } else if (menuSelected == "4") {
                // load goals
            } else if (menuSelected == "5") {
                // record event
            } else if (menuSelected == "6") {
                // exit
                Environment.Exit(0);
            } else {
                Console.WriteLine("Please select a number from the menu options");
                menuSelected = Console.ReadLine();
            }
        }
    }
}