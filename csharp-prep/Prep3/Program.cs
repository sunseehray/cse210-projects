using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        string play = "yes";

        // Console.Write("What is the mmagic number? ");
        // string magicNumberInput = Console.ReadLine();
        // int magicNumber = int.Parse(magicNumberInput);
        while (play == "yes")
        {
            // initiate values
            string match = "no";
            int guessCount = 0;
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1,100);

            while (match == "no")
            {
        
                Console.Write("What is your guess? ");
                string guessInput = Console.ReadLine();
                int guess = int.Parse(guessInput);
                guessCount += 1;
                if (guess > number)
                {
                    Console.WriteLine("lower");
                }
                else if (guess < number)
                {
                    Console.WriteLine("higher");
                }
                else if (guess == number)
                {
                    Console.WriteLine($"You guessed it! It took you {guessCount} guess/es.");
                    match = "yes";
                    Console.WriteLine("Would you like to play again? yes/no");
                    string playResponse = Console.ReadLine();
                    play = playResponse;
                    
                }
            
            }

        }
    }
}