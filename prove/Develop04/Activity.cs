using System;

public class Activity
{
    private int _duration;
    public void ShowDetails(string name, string description)
    {
        Console.WriteLine($"Welcome to the {name}.");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine(description);
    }
    public int AskDuration()
    {
        Console.Write("How long, in seconds, would you like for your session? ");
        string duration = Console.ReadLine();
        int numberDuration = Convert.ToInt32(duration);
        return numberDuration;
    }
    
    public void SetDuration(int duration)
    {
        _duration = duration;
    }
    public void RunActivity(string option)
    {
        // initiate local variables
        string name = "Name";
        string description = "Description";

        Console.Clear();
        int duration = AskDuration();
        SetDuration(duration);
        // start the activity based on chosen option
        if (option == "1")
        {
            BreathingActivity activity = new BreathingActivity();
            name = activity.GetName();
            description = activity.GetDescription();
            ShowDetails(name, description);
        }
        else
        {
            Console.WriteLine("OKAY");
        }

        // end the activity
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine($"Well done!!");
        Console.WriteLine($"You have completed another {_duration} seconds of the {name}.");
        Console.Write("Press enter to continue");
        Console.ReadLine();
    }
}