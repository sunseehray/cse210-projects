using System;

public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string description, string date, string time, Address address, string speaker, int capacity) : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public string GetSpeaker()
    {
        return _speaker;
    }
    public int GetCapacity()
    {
        return _capacity;
    }
    public string ReturnEventType()
    {
        return "Lecture";
    }

    public void GenerateDetailedLecture()
    {
        GenerateDetailed();
        Console.WriteLine($"Speaker: {_speaker}");
        Console.WriteLine($"Capacity: {_capacity} pax");
    }

    public void GenerateShortLecture()
    {
        string eventType = ReturnEventType();
        Console.WriteLine($"Event Type: {eventType}");
        GenerateShort();
    }
    
}