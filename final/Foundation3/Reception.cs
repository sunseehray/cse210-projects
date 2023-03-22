using System;

public class Reception : Event
{
    private string _email;
    public Reception(string title, string description, string date, string time, Address address, string email) : base(title, description, date, time, address)
    {
        _email = email;
    }

    public string GetEmail()
    {
        return _email;
    }

    public string ReturnEventType()
    {
        return "Reception";
    }

    public void GenerateDetailedReception()
    {
        GenerateDetailed();
        Console.WriteLine($"RSVP: {_email}");
    }
    public void GenerateShortReception()
    {
        string eventType = ReturnEventType();
        Console.WriteLine($"Event Type: {eventType}");
        GenerateShort();
    }
}