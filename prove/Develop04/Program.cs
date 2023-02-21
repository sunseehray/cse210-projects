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
            Console.Write("Select a choice from the menu: ");

            input = Console.ReadLine();
            
            //Breathing
            if (input == "1")
            {
                BreathingActivity activity = new BreathingActivity();
                activity.RunActivity();
                activity.PromptBreathing();
                activity.EndActivity();

                
            } 
            // Reflecting
            else if (input == "2")
            {
                ReflectingActivity activity = new ReflectingActivity();
                activity.RunActivity();
                activity.PromptReflecting();
                activity.EndActivity();

            } 
            // Listing
            else if (input == "3")
            {
                ListingActivity activity = new ListingActivity();
                activity.RunActivity();
                activity.PromptListing();
                activity.EndActivity();
            } 
            // Quitting
            else if (input == "4")
            {
                Environment.Exit(0);
            } 
            // if error input?
            else
            {
                Console.WriteLine("Please enter the number of the menu option. ");
            }
        }

        Environment.Exit(0);

    }
}