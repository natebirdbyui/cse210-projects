using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using cse210_projects.prove.Develop04;

class Program
{//I went above and beyond by having random choices and having the each prompt be different and not reused until all prompts have been used
    static void Main(string[] args)
    {

        Console.WriteLine("Welcome to your Mindfulness Program. ");
        Thread.Sleep(1750);//number is in milliseconds
        Console.WriteLine("Please Select from the Following Options:");
        Thread.Sleep(1250);

        bool running = true;
        while (running)
        {//run menu
            Console.WriteLine("1. Start Breathing Activity");
            Thread.Sleep(500);
            Console.WriteLine("2. Start Reflection Activity");
            Thread.Sleep(500);
            Console.WriteLine("3. Start Listing Activity");
            Thread.Sleep(500);
            Console.WriteLine("4. Quit");
            Thread.Sleep(500);

            Console.Write("Please select an option: ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int userInput))
            {
                Console.WriteLine("Please select a number from 1-4.");
                continue; //this will help to keep the loop going and not break for invalid inputs
            }
            switch (userInput)
            {
                //Breathing Activity
                case 1:
                    Console.Write("How long would you like for your session?(Seconds): ");
                    int sessionDuration1 = int.Parse(Console.ReadLine());
                    BreathingActivity breathing = new BreathingActivity(sessionDuration1);                    
                    breathing.StartBreathingExercise();
                    break;

                //Reflection Activity
                case 2:
                    Console.Write("How long would you like for your session?(Seconds): ");
                    int sessionDuration2 = int.Parse(Console.ReadLine());
                    ReflectionActivity reflection = new ReflectionActivity(sessionDuration2);
                    reflection.StartReflection();
                    break;

                //Listing Activity
                case 3:
                    Console.Write("How long would you like for your session?(Seconds): ");
                    int sessionDuration3 = int.Parse(Console.ReadLine());
                    ListingActivity listing = new ListingActivity(sessionDuration3);
                    listing.StartListing();
                    break;

                //Quit
                case 4:
                    running = false; //breaks loop
                    Console.WriteLine("Thank you for using the Mindfulness Program.");
                    Console.WriteLine("Have a great day!");
                    break;

                default:
                    Console.WriteLine("Ease your stress, and please select 1-4.");
                    break;
            }
        }

    }
}