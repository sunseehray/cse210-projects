using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int numerator)
    {
        _top = numerator;
        _bottom = 1;
    }

    public Fraction(int numerator, int denominator)
    {
        _top = numerator;
        _bottom = denominator;
    }

    public void Display()
    {
        Console.WriteLine(this.GetFractionString());
        Console.WriteLine(this.GetDecimalValue());
    }

    public int GetTop()
    {
        int numerator = _top;
        return numerator;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public int GetBottom()
    {
        int denominator = _bottom;
        return denominator;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        string fractionString = _top.ToString() + '/' + _bottom.ToString();
        return fractionString;
    }

    public double GetDecimalValue()
    {
        double decimalValue = (double)_top / (double)_bottom;
        return decimalValue;
    }
}