using System;

public class EternalGoal : Goal
{
    private int _bonusPoints;
    private int _bonusSteps;
    private int _bonusStepsCompleted;

    public EternalGoal()
    {
        _name = "This is an eternal goal";
        _description = "This is the description of an eternal goal";
        _goalPoints = 50;
    }
    public EternalGoal(string name, string description, string goalPoints, int bonusPoints, int bonusSteps)
    {
        
    }
    public override void CreateGoal()
    {
        InitCreateGoal();
        
        Console.Write("How many steps to earn bonus points? ");
        string bonusSteps = Console.ReadLine();
        _bonusSteps = Convert.ToInt32(bonusSteps);

        Console.Write("How many bonus points awarded if bonus steps are met? ");
        string bonusPoints = Console.ReadLine();
        _bonusPoints = Convert.ToInt32(bonusPoints);

        _bonusStepsCompleted = 0;
    }

}