using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");

        Assignment assignment = new Assignment();
        Console.WriteLine(assignment.GetSummary());
        
        Console.WriteLine();

        MathAssignment math1 = new MathAssignment("Roberto Rodriguez", "Fractions", "Section 7.3", "Problems 8-19");
        Console.WriteLine(math1.GetSummary());
        Console.WriteLine(math1.GetHomeWorkList());

        Console.WriteLine();

        WritingAssignment writing1 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(writing1.GetSummary());
        Console.WriteLine(writing1.GetWritingInformation());
    }
}