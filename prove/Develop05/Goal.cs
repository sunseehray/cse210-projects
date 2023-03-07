using System;

public class Goal
{
    protected string _name;
    protected string _description;
    protected int _goalPoints;
    protected int _accumulatedPoints;
    protected string _statusSymbol;

    public Goal() {
        _name = "Test Name";
        _description = "Test Description";
        _goalPoints = 50;
        _accumulatedPoints = 0;
        _statusSymbol = " ";
    }

    public Goal(string name, string description, int goalPoints)
    {
        _name = name;
        _description = description;
        _goalPoints = goalPoints;
    }

    protected void CreateBaseGoal() 
    {   
        Console.Write("What is the name of your goal? ");
        _name = Console.ReadLine();
        
        Console.Write("what is a short description of it? ");
        _description = Console.ReadLine();
        
        Console.Write("What is the amount of points associated with this goal? ");
        string stringGoalPoints = (Console.ReadLine());
        _goalPoints = Convert.ToInt32(stringGoalPoints);
    }

    public virtual void CreateChildGoal()
    {

    }

    public virtual void RecordEvent() 
    {

    }

    public virtual bool IsComplete() 
    {
        return false;
    }

    public virtual void ListGoal() 
    {

    }

    public virtual int CalculateAGP()
    {
        return 0;
    }
}