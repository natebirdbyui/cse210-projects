using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");

        Console.Write("What is your first name? ");
        string first_name = Console.ReadLine();

        Console.Write("What is you last name? ");
        string last_name = Console.ReadLine();

        Console.WriteLine($"My name is {last_name}, {first_name} {last_name}.");
    }
}