using System;

public class OutdoorGathering : Event
{
    private string _weather;
    public OutdoorGathering(string title, string description, string date, string time, Address address, string weather) : base(title, description, date, time, address)
    {
        _weather = weather;
    }

    public string GetWeather()
    {
        return _weather;
    }

    public string GenerateWeatherStatement()
    {
        return "The weather will be " + _weather + ".";
    }

    public string ReturnEventType()
    {
        return "OutdoorGathering";
    }
    public void GenerateDetailedOutdoorGathering()
    {
        GenerateDetailed();
        Console.WriteLine($"Statement of the Weather: {GenerateWeatherStatement()}");
        Console.WriteLine();
    }
    public void GenerateShortOutdoorGathering()
    {
        Console.Write("Event Type: ");
        ReturnEventType();
        GenerateShort();
    }
}