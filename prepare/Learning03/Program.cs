using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");

        Fraction fraction1 = new Fraction();
        fraction1.Display();

        Fraction fraction2 = new Fraction(5);
        fraction2.Display();

        Fraction fraction3 = new Fraction(3,4);
        fraction3.Display();


        Fraction fraction4 = new Fraction();
        fraction4.SetTop(1);
        fraction4.SetBottom(3);
        fraction4.Display();
        
        int top = fraction4.GetTop();
        Console.WriteLine(top);
        int bottom = fraction4.GetBottom();
        Console.WriteLine(bottom);



    }
}