using System;

public class SimpleGoal : Goal
{
    private int _accumulatedPoints;
    public SimpleGoal()
    {
        _accumulatedPoints = 0;
    }
    public override void CreateGoal()
    {
        StartCreateGoal();
    }

    public override void RecordEvent()
    {
        SetStatusSymbol("X");
        _accumulatedPoints += GetBasePoints();
    }

    public override bool IsComplete() 
    {
        int simplePoints = GetBasePoints();
        if (_accumulatedPoints >= simplePoints) {
            return true;
        } else {
            return false;
        }
    }
    public override void DisplayGoal()
    {
        Console.WriteLine($"[{GetStatusSymbol()}] {GetName()} ({GetDescription()}) | {_accumulatedPoints} points");
    }
}