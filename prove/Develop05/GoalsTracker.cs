using System;

public class GoalsTracker
// This class helps keep track of all the goals recorded, calculates the total points from all of these goals
// It also displays a list of the goals and their details.
{
    private List<Goal> _goals = new List<Goal>();

    private int _totalAGP;

    public void ListGoals()
    // Display the list of goals in a particular format
    {
        foreach (Goal goal in _goals) {
            // use Goal's overridden ListGoal method to display each goal in a separate line according to type
            goal.ListGoal();
        }
    }

    public int CalculateTotalAGP()
    // returns the sum of the accumulated points for each goal.
    {

        return 0;
    }
}