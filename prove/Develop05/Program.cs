using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");
        // initiate variables
        string menuSelected = "";
        GoalsTracker goals = new GoalsTracker();

        // int test = 0;
        while (menuSelected != "6") {
            Console.WriteLine($"You have points.");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");

            // get user menu selected
            menuSelected = Console.ReadLine();

            if (menuSelected == "1") {
                // create a goal
                Console.WriteLine("The Types of Goals are: ");
                Console.WriteLine("  1. Simple Goal");
                Console.WriteLine("  2. Eternal Goal");
                Console.WriteLine("  3. Checklist Goal");
                Console.Write("Which type of goal would you like to create? ");
                string goalType = Console.ReadLine();

                if (goalType == "1") {
                    
                } else if (goalType == "2") {

                } else if (goalType == "3") {
 
                }

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
                Console.WriteLine("!!!Please select a number from the menu options!!!");
            }
        }
    }
}