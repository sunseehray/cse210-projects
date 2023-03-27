using System;

public class Swimming : Exercise
{
    private int _laps;

    public Swimming(string date, int minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
    }

    public override double CalculateDistance()
    {
        return base.CalculateDistance();
    }
    public override double CalculateSpeed()
    {
        return base.CalculateSpeed();
    }
    public override double CalculatePace()
    {
        return base.CalculatePace();
    }
    public override string GetSummary()
    {
        return base.GetSummary();
    }
}