using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbers = new List<int>();

        int number = -1;

        while (number != 0)
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
                       
            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        // calculate sum
        int sum = 0;

        foreach (int i in numbers)
        {
            sum += i;
        }

        Console.WriteLine($"The sum is: {sum}");

        // calculate average

        float average = ((float)sum) / numbers.Count;

        Console.WriteLine($"The average is: {average}");

        // get largest number

        int largest = numbers[0];
        foreach (int i in numbers)
        {
            if (i > largest)
            {
                largest = i;
            }
        }

        Console.WriteLine($"The largest number is: {largest}");

        // smallest number
        int smallest = 1000;

        foreach(int i in numbers)
        {
            if (i < smallest && i > 0)
            {
                smallest = i;
            }
        }

        Console.WriteLine($"The smallest positive number is: {smallest}");

        // Sort the list in descending order
        var sortedNumbers =
            from n in numbers
            orderby n ascending
            select n;

        // Print the sorted list
        Console.WriteLine("The sorted list is:");
        foreach (var n in sortedNumbers)
        {
            Console.WriteLine(n);
        }
    }
}