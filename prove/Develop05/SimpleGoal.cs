using System;

public class SimpleGoal : Goal
{
    private int _simplePoints;

    public override void CreateGoal()
    {
        StartCreateGoal();
        Console.Write("What is the amount of points associated with this goal? ");
        string simplePointsString = Console.ReadLine();
        SetSimplePoints(Convert.ToInt32(simplePointsString));
    }

    public void SetSimplePoints(int simplePoints)
    {
        _simplePoints = simplePoints;
    }
}