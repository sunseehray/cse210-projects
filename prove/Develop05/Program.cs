using System;

class Program
// The program helps users track their goals. It has the option to create, list, save, and load goals. It also records events when a goal is met.
// For creating goals, the Goal class will be used. It's child classes will help in modifying behaviors for the different goal types.
// For making a list of the goals, it will make use of the GoalsTracker class.
// Saving and loading goals will be used with the help of the FileProcessor class.
// For recording events, the Goal class will also be used.
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");
        // initiate variables

        //this variable will hold the user's input for the menu option. For now, I will leave it blank.
        string menuSelected = "";

        // Here's initiating the list of goals for the program to work on.
        GoalsTracker goals = new GoalsTracker();

        // Until user sets his menu option to 6, the program will continue to display the menu options.
        while (menuSelected != "6") {
            //update TotalAGP if ever user saves or loads
            int points = goals.CalculateTotalAGP();
            // Display the total points so far of the goals. If this is the initial load, then it should be 0.
            Console.WriteLine($"You have {points} points.");
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
                    SimpleGoal newSimpleGoal = new SimpleGoal();
                    newSimpleGoal.CreateChildGoal();
                    goals.addGoal(newSimpleGoal);
                    
                } else if (goalType == "2") {
                    EternalGoal newEternalGoal = new EternalGoal();
                    newEternalGoal.CreateChildGoal();
                    goals.addGoal(newEternalGoal);

                } else if (goalType == "3") {
                    ChecklistGoal newChecklistGoal = new ChecklistGoal();
                    newChecklistGoal.CreateChildGoal();
                    goals.addGoal(newChecklistGoal);
                }

            } else if (menuSelected == "2") {
                // list goals
                goals.ListGoals();

            } else if (menuSelected == "3") {
                // save goals
                goals.SaveGoals();
            } else if (menuSelected == "4") {
                // load goals
                goals.LoadGoals();
            } else if (menuSelected == "5") {
                // record event
                goals.RecordEventInTracker();
            } else if (menuSelected == "6") {
                // exit
                Environment.Exit(0);
            } else {
                Console.WriteLine("!!!Please select a number from the menu options!!!");
            }
        }
    }
}