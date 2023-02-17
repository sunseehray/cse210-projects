using System;

class Program
{
    static void Main(string[] args)
    {
        //display menu
        string input = "";

        while (input != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("What would you like to do? ");

            input = Console.ReadLine();

            if (input == "1")
            {
                BreathingActivity activity = new BreathingActivity();
                activity.RunActivity();
                activity.PromptBreathing();
                activity.EndActivity();

                
            } else if (input == "2")
            {
                ReflectingActivity activity = new ReflectingActivity();
                activity.RunActivity();
                activity.PromptReflecting();
                activity.EndActivity();

            } else if (input == "3")
            {
                Console.WriteLine("You chose 3");
            } else if (input == "4")
            {
                Environment.Exit(0);
            } else
            {
                Console.WriteLine("Please enter the number of the menu option. ");
            }
        }

        Environment.Exit(0);

    }
}