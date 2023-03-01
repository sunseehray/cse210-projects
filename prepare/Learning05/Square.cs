using System;

public class Square : Shape
{
    private double _side;
    public Square()
    {
        _side = 4;
        SetColor("Red");
    }

    public override double GetArea()
    {
        double area = _side * _side;
        return area;
    }
}