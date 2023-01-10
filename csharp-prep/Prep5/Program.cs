using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        
        string userName = PromptUserName();
        int userNum = PromptUserNumber();

        double squareNumber = SquareNumber(userNum);
        
        DisplayResult(userName, squareNumber);



    }

    static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program");
        }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static double SquareNumber(int number)
    {
        double squareNumber = Math.Pow(number,2);
        return squareNumber;
    }

    static void DisplayResult(string userName, double result)
    {
        Console.WriteLine($"{userName}, the square of your number is {result}.");
    }
}