using System;

public class SimpleGoal : Goal
{
    // constructor for testing
    public SimpleGoal()
    {
        _name = "Name of Simple Goal";
        _description = "Description of Simple Goal";
        _goalPoints = 50;
        _accumulatedPoints = 0;
        _statusSymbol = " ";
    }

    // constructor for specifiying attributes
    public SimpleGoal(string name, string description, int goalPoints)
    {
        _accumulatedPoints = 0;
        _statusSymbol = " ";
    }

    // method to call when creating a goal of this type
    public override void CreateChildGoal()
    {
        CreateBaseGoal();
    }

    // method to call when recording an event of this type
    public override void RecordEvent()
    {
        _statusSymbol = "X";
        _accumulatedPoints += _goalPoints;
    }

    // method to call when listing a goal of this type
    public override void ListGoal()
    {
        Console.Write($"[{_statusSymbol}] {_name} ({_description})");
    }
    
    // calculate the accumulated goal points
    public override int CalculateAGP()
    {
        int accumulatedGP = _accumulatedPoints;
        return accumulatedGP;
    }
}