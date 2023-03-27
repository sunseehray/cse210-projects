using System;

public class Exercise
{
    protected string _date;
    protected int _minutes;

    public Exercise(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public virtual double CalculateDistance()
    {
        return 0;
    }

    public virtual double CalculateSpeed()
    {
        return 0;
    }

    public virtual double CalculatePace()
    {
        return 0;
    }

    public virtual string GetSummary()
    {
        return "";
    }
}