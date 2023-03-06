using System;

public class Goal
{
    private string _name;
    private string _description;
    private int _basePoints;
    private string _statusSymbol;

    public Goal() {
        _name = "Test Name";
        _description = "Test Description";
        _basePoints = 0;
        _statusSymbol = " ";
    }

    public virtual void CreateGoal() {

    }

    public void StartCreateGoal() {
        Console.Write("What is the name of your goal? ");
        SetName(Console.ReadLine());
        Console.Write("what is a short description of it? ");
        SetDescription(Console.ReadLine());
    }

    public void SetName(string name) {
        _name = name;
    }
    public string GetName() {
        return _name;
    }
    public void SetDescription(string description) {
        _description = description;
    }
    public string GetDescription() {
        return _description;
    }
    public void SetBasePoints(int basePoints) {
        _basePoints = basePoints;
    }
    public int GetBasePoints() {
        return _basePoints;
    }
    public void SetStatusSymbol(string statusSymbol) {
        _statusSymbol = statusSymbol;
    }
    public string GetStatusSymbol() {
        return _statusSymbol;
    }

    public virtual void RecordEvent() {

    }

    public virtual bool IsComplete() {
        return false;
    }

    public virtual void DisplayGoal() {
        Console.WriteLine($"[{_statusSymbol}] {_name}|{_description}|{_basePoints}");
    }
}