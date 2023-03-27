using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation4 World!");

        // how to invoke dates
        // https://learn.microsoft.com/en-us/dotnet/api/system.datetime?view=net-8.0#initialization-02
        // DateTime date = new DateTime(2008,3,1,13,0,0); // 24h
        // Console.WriteLine(date.ToString());

        // "mm/dd/yyyy h:mm:ss am or pm
        // string dateString = "12/15/2008 8:30:00 PM";
        // DateTime date1 = DateTime.Parse(dateString, System.Globalization.CultureInfo.InvariantCulture);

        // Console.WriteLine($"{date1}");

        // RUNNING
        Console.WriteLine("RUNNING");
        
        Running running = new Running("27 Mar 2023", 30, 5);
        
        Console.WriteLine(running.GetSummary());
        Console.WriteLine();

        // STATIONARY BICYCLES
        Console.WriteLine("STATIONARY BICYCLES");

        StationaryBicycles stationaryBicycles = new StationaryBicycles("12 April 2023", 45, 10);

        Console.WriteLine(stationaryBicycles.GetSummary());
        Console.WriteLine();

        // SWIMMING
        Console.WriteLine("SWIMMING");

        Swimming swimming = new Swimming("1 April 2023", 20, 20);

        Console.WriteLine(swimming.GetSummary());
        Console.WriteLine();

    }
}