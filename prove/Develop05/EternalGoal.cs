using System;

public class EternalGoal : Goal
{
    private int _stepCounter;

    public EternalGoal()
    {
        _name = "";
        _description = "";
        _goalPoints = 50;
        _stepCounter = 0;
    }
    public EternalGoal(string name, string description, int goalPoints)
    {
        _name = name;
        _description = description;
        _goalPoints = goalPoints;
        _stepCounter = 0;
    }
    public override void CreateChildGoal()
    {
        // call the base method for creating a goal
        CreateBaseGoal();
        
        // STRETCH
        //  get number of bonus steps to earn bonus points
        // Console.Write("How many steps to earn bonus points? ");
        // string bonusSteps = Console.ReadLine();
        // _bonusSteps = Convert.ToInt32(bonusSteps);

        // get points earned for achieving bonus steps
        // Console.Write("How many bonus points awarded if bonus steps are met? ");
        // string bonusPoints = Console.ReadLine();
        // _bonusPoints = Convert.ToInt32(bonusPoints);

        // initiate bonusStepsCompleted to 0
        // _bonusStepsCompleted = 0;
    }

    public override void ListGoal()
    {
        Console.Write($"[ ] {_name} ({_description})");
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string SaveGoal()
    {
        string line = "";
        line = $"EternalGoal|" + _name + "|" + _description + "|" + _goalPoints.ToString();
        return line;
    }

    public override void RecordEvent()
    {
        // maybe for stretch?
        _stepCounter ++;
    }
    public override int CalculateAGP()
    {
        // what if they update multiple times in one session?
        int points = _goalPoints;
        return points;
    }
}