using System;

public class Entry
{
    public string _prompt = "";
    public string _response = "";
    public string _currentDate = "";
    public void DisplayEntry()
    {   
        Console.WriteLine($"Date: {_currentDate} - Prompt: {_prompt}");
        Console.WriteLine($"{_response}");
        Console.WriteLine();
    }

}