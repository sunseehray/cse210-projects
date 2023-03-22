using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation3 World!");

        // event 1
        // generate address
        Address address1 = new Address("12th Street", "Bonifacio Global City", "Metro Manila", "Philippines");

        // create lecture
        Lecture lecture = new Lecture("The Pursuit of Happiness", "A lecture on man's quest for happiness", "March 25, 2023", "3 PM", address1, "John Addams", 200);
        
        // display standard, detailed, and short
        Console.WriteLine();
        lecture.GenerateStandard();
        
        Console.WriteLine();
        lecture.GenerateDetailedLecture();

        Console.WriteLine();
        lecture.GenerateShortLecture();
    }
}