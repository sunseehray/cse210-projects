using System;
using System.Diagnostics;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;
    public void ShowDetails()
    {
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine(_description);
    }
    public void AskDuration()
    {
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        string durationString = Console.ReadLine();
        SetDuration(Convert.ToInt32(durationString));
    }
    public void SetDuration(int duration)
    {
        _duration = duration;
    }
    public void RunActivity(string option)
    {
        Console.Clear();
        
        // start the activity based on chosen option
        if (option == "1")
        {
            BreathingActivity activity = new BreathingActivity();
            _name = activity.GetName();
            _description = activity.GetDescription();
            ShowDetails();
            AskDuration();
            GetReady();
            activity.PromptBreathing();
            EndActivity();
        }
        else
        {
            Console.WriteLine("Will it ever get here? ");
        }
    }

    public void EndActivity()
    {
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine($"Well done!!");
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        Console.Write("Press enter to continue. ");
        Console.ReadLine();
    }

    public void GenerateSpinner(int totalSeconds)
    {
        Stopwatch timer = new Stopwatch();
        timer.Start();
        
        int spinnerPosition = 25;
        int spinWait = 500;

        spinnerPosition = Console.CursorLeft;

        while(timer.Elapsed.TotalSeconds <= totalSeconds)
        {
            char[] spinChars = new char[]{'|','/','-','\\'};
            foreach (char spinChar in spinChars)
            {
                Console.CursorLeft = spinnerPosition;
                Console.Write(spinChar);
                System.Threading.Thread.Sleep(spinWait);
            }
        }
        Console.CursorLeft = spinnerPosition;
        Console.Write(" ");
        timer.Stop();
    }

    public void GenerateCountdownTimer(int totalSeconds)
    {
        Stopwatch timer = new Stopwatch();
        timer.Start();

        int timerPosition = 25;
        int timerWait = 1000;

        timerPosition = Console.CursorLeft;

        while(timer.Elapsed.TotalSeconds <= totalSeconds)
        {
            for (int i = 0; i <= totalSeconds; i++)
            {
                Console.CursorLeft = timerPosition;
                Console.Write(totalSeconds - i);
                System.Threading.Thread.Sleep(timerWait);
            }
        }
        Console.CursorLeft = timerPosition;
        Console.Write(" ");
        timer.Stop();
    }

    public void GetReady()
    {
        Console.Clear();
        Console.WriteLine("Get Ready");
        GenerateSpinner(5);
    }
    
}