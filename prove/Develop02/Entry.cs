using System;

public class Entry
{
    public string _prompt = "";
    public string _response = "";
    public string _currentDate = "";
    public string _mood = "";
    public void DisplayEntry()
    {   
        Console.WriteLine($"Date: {_currentDate}, Mood: {_mood} - Prompt: {_prompt}");
        Console.WriteLine($"{_response}");
        Console.WriteLine();
    }

}