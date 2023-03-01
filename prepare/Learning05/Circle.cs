using System;

public class Circle : Shape
{
    private double _radius;

    public Circle()
    {
        _radius = 1;
        SetColor("Blue");
    }

    public override double GetArea()
    {
        return Math.PI * _radius * _radius;
    }

}