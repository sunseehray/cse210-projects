using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
                
        Console.Write("Grade percentage: ");
        string gradeInput = Console.ReadLine();
        float gradeNumerical = float.Parse(gradeInput);

        var gradeLetter = "";

        if (gradeNumerical >= 90)
        {
            gradeLetter = "A";
        }
        else if (gradeNumerical >= 80)
        {
            gradeLetter = "B";
        }
        else if (gradeNumerical >= 70)
        {
            gradeLetter = "C";
        }
        else if (gradeNumerical >= 60)
        {
            gradeLetter = "D";
        }
        else {
            gradeLetter = "F";
        }

        // Grade Sign

        var remainder = gradeNumerical % 10;
        var sign = "";

        if (remainder >=7 && gradeLetter != "A" && gradeLetter != "F")
        {
            sign = "+";
        }
        else if (remainder <= 3 && gradeLetter != "F")
        {
            sign = "-";
        }

        Console.WriteLine($"{gradeLetter}{sign}");

        if (gradeNumerical >=70)
        {
            Console.WriteLine("You passed.");
        }
        else {
            Console.WriteLine("You failed. Try again.");
        }
    }
}