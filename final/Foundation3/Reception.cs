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
        Console.WriteLine();
        Console.WriteLine($"RSVP: {_email}");
        Console.WriteLine();
    }
    public void GenerateShortReception()
    {
        Console.Write("Event Type: ");
        ReturnEventType();
        GenerateShort();
        Console.WriteLine();
    }
}