using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
        
        Console.WriteLine();
        
        Job job1 = new Job();
        job1._company = "Reekoh";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2023;
        job1._endYear = 2030;
        job1.DisplayJob();
        
        Console.WriteLine();

        Job job2 = new Job();
        job2._company = "UPLB";
        job2._jobTitle = "Instructor";
        job2._startYear = 2008;
        job2._endYear = 2015;
        job2.DisplayJob();

        Console.WriteLine();

        Resume resume1 = new Resume();
        resume1._jobList.Add(job1);
        resume1._jobList.Add(job2);
        resume1._name = "Neil Armstrong";
        // Console.WriteLine($"{resume1._jobList[0]._jobTitle}");
        resume1.DisplayResume();

    }
}