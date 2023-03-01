using System;

public class Rectangle : Shape
{
    private double _length;
    private double _width;
    public Rectangle()
    {
        _length = 4;
        _width = 2;
        SetColor("Green");
    }

    public override double GetArea()
    {
        return _length * _width;
    }
}