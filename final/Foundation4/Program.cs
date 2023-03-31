using System;

class Program
{
    static void Main(string[] args)
    {
        List<Exercise> exerciseList = new List<Exercise>();
        
        Running running = new Running("27 Mar 2023", 30, 5);
        exerciseList.Add(running);

        StationaryBicycles stationaryBicycles = new StationaryBicycles("12 April 2023", 45, 10);
        exerciseList.Add(stationaryBicycles);

        Swimming swimming = new Swimming("1 April 2023", 20, 20);
        exerciseList.Add(swimming);

        Console.WriteLine("POLYMORPHISM");
        Console.WriteLine();
        Console.WriteLine("EXERCISES:");
        foreach (Exercise exercise in exerciseList) {
            Console.WriteLine(exercise.GetSummary());
        }
    }
}