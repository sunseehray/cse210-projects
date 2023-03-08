using System;
using System.IO;

public class GoalsTracker
// This class helps keep track of all the goals recorded, calculates the total points from all of these goals
// It also displays a list of the goals and their details.
{
    private List<Goal> _goals = new List<Goal>();

    // total accumulated goal points
    private int _accumulatedPoints = 0;

   public void SaveGoals()
    {
        string fileName = "";
        Console.Write("What is the filename? ");
        fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            // save first line with totalAGP
            int totalAGP = CalculateTotalAGP();
            outputFile.WriteLine(totalAGP.ToString());
            
            // save subsequent lines with goals
            foreach(Goal goal in _goals)
            {
                outputFile.WriteLine(goal.SaveGoal());
            }
        }
    }

    // taken from the Journal assignment, still needs modification for Goal Tracker
    public void LoadGoals()
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

                // name, description, goalPoints, status
                SimpleGoal simpleGoal = new SimpleGoal(parts[1], parts[2], Convert.ToInt32(parts[3]), Convert.ToBoolean(parts[4]));
                _goals.Add(simpleGoal);             

            } else if (parts[0] == "EternalGoal") {

                // name, description, goalPoints, status, stepCounter
                EternalGoal eternalGoal = new EternalGoal(parts[1], parts[2], Convert.ToInt32(parts[3]));
                _goals.Add(eternalGoal);

            } else if (parts[0] == "ChecklistGoal") {
                
                //  _name + "|" + _description + "|" + _goalPoints.ToString() + "|" + _bonusPoints.ToString() + "|" + _steps.ToString() + "|" + _stepCounter.ToString()
                // string name, string description, int goalPoints, int bonusPoints, int steps, int stepCounter
                ChecklistGoal checklistGoal = new ChecklistGoal(parts[1], parts[2], Convert.ToInt32(parts[3]), Convert.ToInt32(parts[4]), Convert.ToInt32(parts[5]), Convert.ToInt32(parts[6]));
                _goals.Add(checklistGoal);

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
        int totalAGP = _accumulatedPoints;
        foreach(Goal goal in _goals) {
            totalAGP += goal.CalculateAGP();
        }

        // save to internal attribute
        _accumulatedPoints = totalAGP;

        return totalAGP;
    }

    public void RecordEventInTracker()
    // help user choose which goal to update
    {
        string goalIndex = "";
        Console.Write("Which goal did you accomplish? ");
        goalIndex = Console.ReadLine();
        int goalIndexInt = Convert.ToInt32(goalIndex) - 1;

        // record event but check if it has been completed
        if (_goals[goalIndexInt].IsComplete() == false) {

            _goals[goalIndexInt].RecordEvent();

            int pointsEarned = _goals[goalIndexInt].CalculateAGP();

            // update accumulatedPoints
            _accumulatedPoints = CalculateTotalAGP();

            Console.WriteLine($"Congratulations! You have earned {pointsEarned.ToString()} points!");
            Console.WriteLine($"You now have {_accumulatedPoints} points");

        } else {

            Console.WriteLine("You have already completed this goal.");

        }
    }
}