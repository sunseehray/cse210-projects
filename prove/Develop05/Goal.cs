using System;

public class Goal
{
    private string _name;
    private string _dsecription;
    private int _basePoints;
    private string _statusSymbol;

    public Goal(string name, string description) {
        _name = name;
        _dsecription = description;
    }
    public virtual void RecordEvent() {

    }

    public virtual bool IsComplete() {
        return false;
    }

    public virtual int CalculatePoints() {
        return 0;
    }

    public virtual string DisplaySummary() {
        return "";
    }
    public void SetBasePoints() {
        
    }
}