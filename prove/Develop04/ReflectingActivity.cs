using System;

public class ReflectingActivity : Activity
{
    private string _name;
    private string _description;

    public ReflectingActivity()
    {
        _name = "Reflecting Activity";
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
        Console.Write("Breathe in...");
    }
}