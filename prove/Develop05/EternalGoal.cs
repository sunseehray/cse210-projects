using System;

public class EternalGoal : Goal
{
    private int _eternalPoints;
    private int _bonusPoints;
    private int _bonusSteps;
    private int _accumulatedPoints;
    private int _bonusStepsCompleted;

    public override void CreateGoal()
    {
        StartCreateGoal();
        Console.Write("What is the amount of points associated with this goal? ");
    }

}