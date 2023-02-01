using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");

        Fraction fraction1 = new Fraction();

        fraction1.InitializeWithNoParameters();
        fraction1.Display();

        fraction1.InitializeWithNumerator(5);
        fraction1.Display();

        fraction1.InitializeWithAllParameters(3,4);
        fraction1.Display();

        int top = fraction1.GetTop();
        Console.WriteLine(top);
        int bottom = fraction1.GetBottom();
        Console.WriteLine(bottom);

        fraction1.SetTop(1);
        fraction1.SetBottom(3);
        fraction1.Display();
    }
}