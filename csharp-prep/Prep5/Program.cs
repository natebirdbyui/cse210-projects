using System;

class Program
{
    static void Main(string[] args)
    {
        {
            //Call all functions to display for user
            DisplayWelcome();
            string userName = PromptUserName();
            int userNumber = PromptUserNumber();

            int squaredNumber = SquareNumber(userNumber);

            DisplayResult(userName, squaredNumber);
        }
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
            
        }
        static string PromptUserName()
        {
            Console.Write("What is your name? ");
            string userName = Console.ReadLine();
            return userName;
        }
        static int PromptUserNumber()
        {
            Console.Write("What is your favorite number? ");
            string userInput = Console.ReadLine();
            int userNumber = int.Parse(userInput);
            return userNumber;
        }
        static int SquareNumber(int userNumber)
        {
            int userSquareNumber = (int)Math.Pow(userNumber, 2);
            return userSquareNumber;
        }
        static void DisplayResult(string userName, int userSquareNumber)
        {
            Console.Write($"{userName}, your favorite number squared is: {userSquareNumber}");
        
        }

    }
}