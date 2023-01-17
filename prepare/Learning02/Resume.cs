using System;

class Resume
{
    public string _name = "";
    public List<Job> _jobList = new List<Job>();

    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        foreach (Job n in _jobList)
        {
            n.DisplayJob();
        }
    }
}