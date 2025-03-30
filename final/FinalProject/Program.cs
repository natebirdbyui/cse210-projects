using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"{GetGreeting()} Welcome to the Ward Activities Meal Planner!");
        Thread.Sleep(1000);
        Console.WriteLine("How may I help you today?");
        Thread.Sleep(1000);
        Console.WriteLine("Please select an option on what you would like to do.");
        Thread.Sleep(1000);
        Console.WriteLine("\n");

        bool running = true;
        while (running)
        {
            Console.WriteLine("===============================================================");
            Console.WriteLine("          Ward Activities Meal Planner Main Menu               ");
            Console.WriteLine("===============================================================");
            Console.WriteLine("\n1. Main Course Menu");
            Thread.Sleep(500);
            Console.WriteLine("2. Side Course Menu");
            Thread.Sleep(500);
            Console.WriteLine("3. Beverage Menu");
            Thread.Sleep(500);
            Console.WriteLine("4. Condiment Menu");
            Thread.Sleep(500);
            Console.WriteLine("5. Guest Count");
            Thread.Sleep(500);
            Console.WriteLine("6. Budget");
            Thread.Sleep(500);
            Console.WriteLine("7. Activity Date");
            Thread.Sleep(500);
            Console.WriteLine("8. Save Project");
            Thread.Sleep(500);
            Console.WriteLine("9. Load Project");
            Thread.Sleep(500);
            Console.WriteLine("10. Display Menu");
            Thread.Sleep(500);
            Console.WriteLine("11. Exit");
            Thread.Sleep(500);        
            Console.WriteLine("===============================================================");
            
            Console.Write("Please enter the number of the option you would like to select: ");
            if (!int.TryParse(Console.ReadLine(), out int userInput))
            {
                Console.WriteLine("Please select a number from 1-11.");
                continue;//restarts the loop if the user inputs a non-integer
            }

            //LoadingSymbol.DisplayLoadingSymbol();//not sure if I will have one or not...
            Console.WriteLine();

            switch(userInput)
            {
                case 1: //Main Course Menu
                    break;

                case 2: //Side Course Menu
                    break;

                case 3: //Beverage Menu
                    break;

                case 4: //Condiment Menu
                    break;

                case 5: //Guest Count
                    break;

                case 6: //Budget
                    break;

                case 7: //Activity Date
                    break;

                case 8: //Save Project
                    break;

                case 9: //Load Project
                    break;

                case 10: //Display Menu
                    break;

                case 11: //Exit
                    running = false;
                    break;
                    
            }
        }
        

    }

    static string GetGreeting()
    {
        int hour = DateTime.Now.Hour;
        if (hour < 12)
        {
            return "Good Morning!";
        }
        else if (hour < 18)
        {
            return "Good Afternoon!";
        }
        else
        {
            return "Good Evening!";
        }
    }
}