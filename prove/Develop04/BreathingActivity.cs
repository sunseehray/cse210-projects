using System;

public class BreathingActivity : Activity
{
    public void PromptBreathing()
    {
        int breathingDuration = GetDuration();
        DateTime startTime = new DateTime();
        startTime = DateTime.Now;
        DateTime futureTime = new DateTime();
        futureTime = startTime.AddSeconds(breathingDuration);

        DateTime currentTime = new DateTime();
        currentTime = DateTime.Now;

        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Breathe in...");
        GenerateCountdownTimer(2);
        Console.WriteLine();
        Console.Write("Breathe out...");
        GenerateCountdownTimer(3);

        while (currentTime <= futureTime)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Breathe in...");
            GenerateCountdownTimer(4);
            Console.WriteLine();
            Console.Write("Breathe out...");
            GenerateCountdownTimer(6);
            currentTime = DateTime.Now;
        }
        
        
    }
}