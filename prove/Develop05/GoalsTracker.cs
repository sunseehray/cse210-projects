using System;

public class GoalsTracker
// This class helps keep track of all the goals recorded, calculates the total points from all of these goals
// It also displays a list of the goals and their details.
{
    private List<Goal> _goals = new List<Goal>();

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
        return totalAGP;
    }
}