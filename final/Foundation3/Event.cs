using System;

public class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    // change these back to string then use that string for display!
    public void GenerateStandard()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"{_date} | {_time}");
        string address = _address.GenerateCompleteAddress();
        Console.WriteLine($"{address}");
    }
    public void GenerateDetailed()
    {   
        GenerateStandard();
    }
    public void GenerateShort()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"{_date}");
    }
}