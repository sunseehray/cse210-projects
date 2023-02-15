using System;

public class BreathingActivity : Activity
{
    private string _name;
    private string _description;

    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking through your breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void PromptBreathing()
    {
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Breathe in...");
        GenerateCountdownTimer(2);
        Console.WriteLine();
        Console.Write("Breathe out...");
        GenerateCountdownTimer(3);
        Console.WriteLine();
        Console.Write("Breathe in...");
        GenerateCountdownTimer(4);
        Console.WriteLine();
        Console.Write("Breathe out...");
        GenerateCountdownTimer(6);
    }
}