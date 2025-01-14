using System;
using System.Security.Cryptography;

class Program

{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Guess the MAGIC NUMBER!!!");
        string response = "";
        do
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            int guess = -1;
            int guessCount = 0;
            
            while (guess != magicNumber)
            {
                Console.Write("Please guess a number: ");
                guess = int.Parse(Console.ReadLine());
                guessCount ++; //That is how it increases in C# **as a counter**
                if (magicNumber > guess)
                {
                    Console.WriteLine("Higher!!");
                }
                else if (magicNumber < guess)
                {
                    Console.WriteLine("Lower!");
                }
                else
                {
                    Console.WriteLine("You got it! Great job!");
                    Console.WriteLine($"Your total guesses were {guessCount}! You should try again to beat your score.");
                }

            
            }
            Console.Write("Wanna go for anther round of guessing the number???(yes/no) ");
            response = Console.ReadLine().ToLower();
        }while (response == "yes");

        Console.WriteLine("Thanks for playing the game! =)");
    }
}