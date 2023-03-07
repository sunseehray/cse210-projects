using System;

public class SimpleGoal : Goal
{
    // constructor for testing
    public SimpleGoal()
    {
        _name = "Name of Simple Goal";
        _description = "Description of Simple Goal";
        _goalPoints = 50;
        _status = false;
    }

    // constructor for specifiying attributes
    public SimpleGoal(string name, string description, int goalPoints, bool status)
    {
        _name = name;
        _description = description;
        _goalPoints = goalPoints;
        _status = status;
    }

    // method to call when creating a goal of this type
    public override void CreateChildGoal()
    {
        CreateBaseGoal();
    }

    // method to call when recording an event of this type
    public override void RecordEvent()
    {
        _status = true;
    }

    public override bool IsComplete()
    {
        if (_status == true) {
            return true;
        } else {
            return false;
        }
    }

    // method to call when listing a goal of this type
    public override void ListGoal()
    {
        string statusSymbol = "";
        bool status = IsComplete();
        if (status == true) {
            statusSymbol = "X";
        } else {
            statusSymbol = " ";
        }
        Console.Write($"[{statusSymbol}] {_name} ({_description})");
    }
    
    // calculate the accumulated goal points
    public override int CalculateAGP()
    {
        bool status = IsComplete();
        int aGP = 0;
        if (status == true) {
            aGP = _goalPoints;
        } else {
            aGP = 0;
        }
        return aGP;
    }

    public override string SaveGoal()
    {
        string line = "";
        line = $"SimpleGoal|{_name}|{_description}|{_goalPoints}|{IsComplete().ToString()}";
        return line;
    }
}