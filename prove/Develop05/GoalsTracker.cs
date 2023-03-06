using System;

public class GoalsTracker
{
    private List<Goal> _goals = new List<Goal>();

    public void ListGoals()
    {
        foreach (Goal goal in _goals) {
            goal.DisplayGoal();
        }
    }
}