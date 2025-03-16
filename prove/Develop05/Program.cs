using System;
using System.Threading;
using System.Collections.Generic;
using System.IO;


class Program
{
    static void Main(string[] args)
    {
        List<Goals> goals = new List<Goals>();

        //Welcome Message
        Console.WriteLine("Hello!");
        Thread.Sleep(1000);  // Pause for 1 second
        Console.WriteLine("Welcome to your Eternal Quest!");
        Thread.Sleep(2000);  // Pause for 2 seconds
        Console.WriteLine("Please...");
        Thread.Sleep(1000);  // Pause for 1 seconds
        Console.WriteLine("Please select a number that corresponds to the following options:");
        Thread.Sleep(2000);  // Pause for 3 seconds

        bool running = true;
        while (running)//run menu
        {
            Console.WriteLine("==============================");
            Console.WriteLine("       Eternal Quest Menu     ");
            Console.WriteLine("==============================");
            Thread.Sleep(500);
            Console.WriteLine("\n1. Create New Goal");
            Thread.Sleep(500);
            Console.WriteLine("2. List Goals");
            Thread.Sleep(500);
            Console.WriteLine("3. Save Goal");
            Thread.Sleep(500);
            Console.WriteLine("4. Load Goals");
            Thread.Sleep(500);
            Console.WriteLine("5. Record Event");
            Thread.Sleep(500);
            Console.WriteLine("6. Quit");
            Thread.Sleep(500);
            Console.Write("Please select the number for what you like to do: ");
            if (!int.TryParse(Console.ReadLine(), out int userInput))
            {
                Console.WriteLine("Please select a number from 1-6.");
                continue;//restarts the loop if the user inputs a non-integer
            }

            LoadingSymbol.DisplayLoadingSymbol();
            Console.WriteLine();

            switch (userInput)
            {

                case 1://Create New Goal
                    Console.WriteLine("Which type of goal would you like to create?");
                    Thread.Sleep(1000);  // Pause for 1 second
                    Console.WriteLine("1. Simple Goal");
                    Thread.Sleep(500);
                    Console.WriteLine("2. Eternal Goal");
                    Thread.Sleep(500);
                    Console.WriteLine("3. Checklist Goal");
                    Console.Write("> ");
                    if (!int.TryParse(Console.ReadLine(), out int case1Input) || case1Input < 1 || case1Input > 3)
                    {
                        Console.WriteLine("Please select a number from 1-3.");
                        continue;//restarts the loop if the user inputs a non-integer
                    }
                    LoadingSymbol.DisplayLoadingSymbol();
                    Console.WriteLine();

                    Console.Write("Enter the name of the goal: ");
                    string nameOfGoal = Console.ReadLine();
                    Console.Write("Enter the points for the goal: ");
                    if (!int.TryParse(Console.ReadLine(), out int points))
                    {
                        Console.WriteLine("Please enter a valid number.");
                        continue;//restarts the loop if the user inputs a non-integer
                    }
                    switch (case1Input)
                    {
                        case 1://Simple Goal
                            goals.Add(new SimpleGoal(nameOfGoal, points));
                            Console.WriteLine("Simple Goal created successfully!");
                            break;
                        case 2://Eternal Goal
                            goals.Add(new EternalGoal(nameOfGoal, points));
                            Console.WriteLine("Eternal Goal created successfully!");
                            break;
                        case 3://Checklist Goal
                            Console.Write("Enter the number of times to complete the goal: ");
                            if (!int.TryParse(Console.ReadLine(), out int numberOfTimesToComplete))
                            {
                                Console.WriteLine("Please enter a valid number.");
                                continue;//restarts the loop if the user inputs a non-integer
                            }
                            Console.Write("Enter the bonus points for completing the goal: ");
                            if (!int.TryParse(Console.ReadLine(), out int bonusPoints))
                            {
                                Console.WriteLine("Please enter a valid number.");
                                continue;//restarts the loop if the user inputs a non-integer
                            }
                            goals.Add(new ChecklistGoal(nameOfGoal, points, numberOfTimesToComplete, bonusPoints));
                            Console.WriteLine("Checklist Goal created successfully!");
                            break;
                        default:
                            Console.WriteLine("Invalid input!");
                            continue;
                    }
                    break;

                case 2://List Goals
                    DisplayList display = new DisplayList();
                    display.ShowGoals(goals);
                    break;

                case 3://Save Goal
                    SaveAndLoad.SaveGoals(goals);
                    break;

                case 4://Load Goals
                    goals = SaveAndLoad.LoadGoals();
                    break;

                case 5://Record Event
                    if (goals.Count == 0)//checks for no goals for message before moving on...
                    {
                        Console.WriteLine("There are no goals that have been set. Please create a goal first.");
                        return;
                    }
                    Console.WriteLine("Which goal would you like to record an event for?");
                    DisplayList displayList = new DisplayList();
                    displayList.ShowGoals(goals);

                    Console.Write("Enter the number of the goal you would like to record an event for: ");
                    if (!int.TryParse(Console.ReadLine(), out int goalNumber) || goalNumber <= 0 || goalNumber > goals.Count)//checks for valid input
                    {
                        Console.WriteLine("Error. Please enter a valid number from list.");
                        break;
                    }

                    Goals selectedGoal = goals[goalNumber - 1];

                    if (selectedGoal is SimpleGoal simpleGoal)
                    {
                        simpleGoal.MarkCompleted();
                        Console.WriteLine($"Progress updating...");
                        LoadingSymbol.DisplayLoadingSymbol();
                        Thread.Sleep(500);
                        Console.WriteLine($"Goal: '{simpleGoal.GetNameGoal()}' has been completed!");
                        Console.WriteLine($"You have earned {simpleGoal.GetPoints()} points!");
                    }
                    else if (selectedGoal is EternalGoal eternalGoal)
                    {
                        eternalGoal.MarkCompleted();
                        Console.WriteLine($"Progress updating...");
                        LoadingSymbol.DisplayLoadingSymbol();
                        Thread.Sleep(500);
                        Console.WriteLine($" Eternal Goal '{eternalGoal.GetNameGoal()}' has been recorded!");
                        Console.WriteLine($"You have earned {eternalGoal.GetPoints()} points!");
                    }
                    else if (selectedGoal is ChecklistGoal checklist)
                    {
                        checklist.SetTimesCurrentlyCompleted(checklist.GetTimesCurrentlyCompleted() + 1);
                        Console.WriteLine($"Progress updating...");
                        LoadingSymbol.DisplayLoadingSymbol();
                        Thread.Sleep(500);
                        Console.WriteLine("Event recorded successfully!");
                        Console.WriteLine($"You have earned {checklist.GetPoints()} points!");
                    }
                    break;


                case 6://Quit
                    running = false;
                    Console.WriteLine("Thank you for using the Eternal Quest Program.");
                    Thread.Sleep(1000);  // Pause for 1 second
                    Console.WriteLine("Have a great day!");
                    break;



                default:
                    Console.WriteLine("Don't break your goal, please select a number from 1-6.");
                    break;
            }
        }
    }
}