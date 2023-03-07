using System;
using System.IO;

public class GoalsTracker
// This class helps keep track of all the goals recorded, calculates the total points from all of these goals
// It also displays a list of the goals and their details.
{
    private List<Goal> _goals = new List<Goal>();

    // total accumulated goal points
    private int _accumulatedPoints;

   public void SaveGoals()
    {
        string fileName = "";
        Console.Write("What is the filename? ");
        fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            // save first line with totalAGP
            outputFile.WriteLine(_accumulatedPoints.ToString());
            
            // save subsequent lines with goals
            foreach(Goal goal in _goals)
            {
                outputFile.WriteLine(goal.SaveGoal());
            }
        }
    }

    // taken from the Journal assignment, still needs modification for Goal Tracker
    public void LoadGGoals()
    {
        _goals.Clear(); 

        string fileName = "";
        Console.Write("What is the filename? ");
        fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);

        _accumulatedPoints = Convert.ToInt32(lines[0]);

        for (int i = 1; i < lines.Count(); i++ )
        {
            string[] parts = lines[i].Split("|");

            if (parts[0] == "SimpleGoal") {
                SimpleGoal simpleGoal = new SimpleGoal(parts[1], parts[2], Convert.ToInt32(parts[3]), Convert.ToBoolean(parts[4]));
                _goals.Add(simpleGoal);
                   
            }
        }

        

    }

    public void ListGoals()
    // Display the list of goals in a particular format
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count(); i++) {
            // use Goal's overridden ListGoal method to display each goal in a separate line according to type
            Console.Write($"{i + 1}. ");
            _goals[i].ListGoal();
            Console.Write("\n");
        }
        Console.WriteLine();
    }

    public void addGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public int CalculateTotalAGP()
    // returns the sum of the accumulated points for all goals in the current list.
    {
        int totalAGP = 0;
        foreach(Goal goal in _goals) {
            totalAGP += goal.CalculateAGP();
        }

        // save to internal attribute
        _accumulatedPoints = totalAGP;

        return totalAGP;
    }

    public void RecordEvent()
    {
        Console.WriteLine();
    }
}