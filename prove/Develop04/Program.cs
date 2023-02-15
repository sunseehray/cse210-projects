using System;

class Program
{
    static void Main(string[] args)
    {
        //display menu
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Start breathing activity");
        Console.WriteLine("2. Start reflecting activity");
        Console.WriteLine("3. Start listing activity");
        Console.WriteLine("4. Quit");

        string input = "";

        while (input != "4")
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");

            input = Console.ReadLine();

            if (input == "1")
            {
                Console.WriteLine("You chose 1");
            } else if (input == "2")
            {
                Console.WriteLine("You chose 2");
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