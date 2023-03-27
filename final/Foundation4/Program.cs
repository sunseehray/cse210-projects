using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation4 World!");

        // how to invoke dates
        // https://learn.microsoft.com/en-us/dotnet/api/system.datetime?view=net-8.0#initialization-02
        DateTime date = new DateTime(2008,3,1,13,0,0); // 24h
        Console.WriteLine(date.ToString());

        // "mm/dd/yyyy h:mm:ss am or pm
        string dateString = "12/15/2008 8:30:00 PM";
        DateTime date1 = DateTime.Parse(dateString, System.Globalization.CultureInfo.InvariantCulture);

        Console.WriteLine($"{date1}");

        
    }
}