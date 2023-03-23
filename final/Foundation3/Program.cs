using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation3 World!");

        // event 1
        // generate address
        Address address = new Address("12th Street", "Bonifacio Global City", "Metro Manila", "Philippines");

        // create lecture
        Lecture lecture = new Lecture("The Pursuit of Happiness", "A lecture on man's quest for happiness", "March 25, 2023", "3 PM", address, "John Addams", 200);
        
        Console.WriteLine();
        Console.WriteLine("EVENT 1");

        // display standard, detailed, and short
        Console.WriteLine();
        Console.WriteLine(lecture.GenerateStandard());
        
        Console.WriteLine();
        Console.WriteLine(lecture.GenerateDetailedLecture());

        Console.WriteLine();
        Console.WriteLine(lecture.GenerateShortLecture());

        // event 2
        
        // address for Reception
        Address addressR = new Address("Samsung Hall", "BGC", "Metro Manila", "Philippines");
        // create Reception
        Reception reception = new Reception("John & Jane", "Wedding Reception for John & Jane Smith", "April 1, 2023", "5 PM", addressR, "johnandjanesmith@www.com");
        
        Console.WriteLine();
        Console.WriteLine("EVENT 2");
        

        // display standard, detaild, and short
        Console.WriteLine();
        Console.WriteLine(reception.GenerateStandard());
        
        Console.WriteLine();
        Console.WriteLine(reception.GenerateDetailedReception());

        Console.WriteLine();
        Console.WriteLine(reception.GenerateShortReception());

        // event 3

        // address for OG
        Address addressOG = new Address("Sunset Boulevard", "Los Angeles", "California", "USA");

        // create Outdoor Gathering
        OutdoorGathering outdoorGathering = new OutdoorGathering("Beatles Live", "Beatles World Tour Concert", "22 May 2023", "8 PM", addressOG, "sunny");
        
        Console.WriteLine();
        Console.WriteLine("EVENT 3");
        

        // display standard, detailed, and short
        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GenerateStandard());

        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GenerateDetailedOutdoorGathering());

        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GenerateShortOutdoorGathering());

    }
}