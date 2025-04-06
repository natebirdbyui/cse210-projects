/* The above class is a C# program for a Ward Activities Meal Planner that allows users to plan meals,
manage guest count, budget, and save/load project data. */
using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"{GetGreeting()} Welcome to the Ward Activities Meal Planner!");
        Thread.Sleep(1000);
        Console.Write("Before we dive into the meal planning," +
        " let's get some information about your event.\n");
        Thread.Sleep(1000);
        Console.WriteLine("===================================================================");

        DatePlanner datePlanner = new DatePlanner();
        datePlanner.SetActivityDate();

        GuestCount WhatIsYourGuestCount = new GuestCount(0);//sets the guest count to 0
        WhatIsYourGuestCount.WhatIsYourGuestCount();

        Budget WhatIsYourBudget = new Budget(0);//sets the budget to 0
        WhatIsYourBudget.WhatIsYourBudget();

        Console.WriteLine("Please select an option on what you would like to do.");
        Thread.Sleep(1000);
        Console.WriteLine("\n");

        bool running = true;

        List<FoodMenu> mainCourseMenu = new List<FoodMenu>();//initialize the main course menu
        List<FoodMenu> sideCourseMenu = new List<FoodMenu>();//initialize the side course menu
        List<FoodMenu> beveragesMenu = new List<FoodMenu>();//initialize the beverage menu
        List<FoodMenu> condimentsMenu = new List<FoodMenu>();//initialize the condiment menu
        List<FoodMenu> shoppingCart = new List<FoodMenu>();//initialize the shopping cart

        // Declare variables for Save and Load functionality
        //string fileSaved = fileSaved.Save();  // You can change this to your desired file name
        string fileSaved = "";//what the user will save the file as
        string activityDate = datePlanner.GetDate();  // Fetch the activity date
        int guestCount = WhatIsYourGuestCount.GetGuestCount(); // Fetch the guest count
        double budget = WhatIsYourBudget.GetBudget();  // Fetch the budget       

        while (running)
        {
            Console.WriteLine("===============================================================");
            Console.WriteLine("          Ward Activities Meal Planner Main Menu               ");
            Console.WriteLine("===============================================================");
            Console.WriteLine("\n1. Main Course Menu");
            Thread.Sleep(100);
            Console.WriteLine("2. Side Course Menu");
            Thread.Sleep(100);
            Console.WriteLine("3. Beverage Menu");
            Thread.Sleep(100);
            Console.WriteLine("4. Condiment Menu");
            Thread.Sleep(100);
            Console.WriteLine("5. Guest Count");
            Thread.Sleep(100);
            Console.WriteLine("6. Budget");
            Thread.Sleep(100);
            Console.WriteLine("7. Activity Date");
            Thread.Sleep(100);
            Console.WriteLine("8. Save Project");
            Thread.Sleep(100);
            Console.WriteLine("9. Load Project");
            Thread.Sleep(100);
            Console.WriteLine("10. Shopping Cart List");
            Thread.Sleep(100);
            Console.WriteLine("11. Exit");
            Thread.Sleep(100);
            Console.WriteLine("===============================================================");

            Console.Write("Please enter the number of the option you would like to select: ");
            if (!int.TryParse(Console.ReadLine(), out int userInput))
            {
                Console.WriteLine("Please select a number from 1-12.");
                continue;//restarts the loop if the user inputs a non-integer
            }

            //LoadingSymbol.DisplayLoadingSymbol();//not sure if I will have one or not...
            Console.WriteLine();

            switch (userInput)
            {
                case 1: //Main Course Menu
                    DisplayMenu.ShowMenuAndAddToCart(MainCourse.GetMainCourseMenuItems(), shoppingCart, "Main Course Menu");
                    break;

                case 2: //Side Course Menu  
                    DisplayMenu.ShowMenuAndAddToCart(SideCourse.GetSideCourseMenuItems(), shoppingCart, "Side Course Menu");
                    break;

                case 3: //Beverage Menu
                    DisplayMenu.ShowMenuAndAddToCart(Beverages.GetBeveragesMenuItems(), shoppingCart, "Beverage Menu");
                    break;

                case 4: //Condiment Menu 
                    DisplayMenu.ShowMenuAndAddToCart(Condiments.GetCondimentsMenuItems(), shoppingCart, "Condiment Menu");
                    break;

                case 5: //Guest Count
                    Console.WriteLine($"{WhatIsYourGuestCount.GetGuestCount()} is your current guest count.");
                    WhatIsYourGuestCount.WhatIsYourGuestCount();
                    break;

                case 6: //Budget
                    Console.WriteLine($"${WhatIsYourBudget.GetBudget()} is your current budget.");
                    WhatIsYourBudget.WhatIsYourBudget();
                    break;

                case 7: //Activity Date                    
                    Console.WriteLine($"Your event is scheduled for: {datePlanner.GetDate()}");
                    break;

                case 8: //Save Project
                    if (string.IsNullOrEmpty(fileSaved))
                    {
                        Console.WriteLine("Please enter the file name to save the project--no extensions: ");
                        fileSaved = Console.ReadLine() + ".csv";  // Get the file name from the user and add.csv extension
                    }
                    SaveAndLoad.Save(fileSaved, activityDate, guestCount, budget, shoppingCart);
                    break;

                case 9: //Load Project
                    Console.WriteLine("Please enter the file name to load the project--no extensions: ");
                    string fileLoad = Console.ReadLine() + ".csv";  // Get the file name from the user and add.csv extension
                    if (File.Exists(fileLoad))
                    {
                        SaveAndLoad.Load(fileLoad, ref activityDate, ref guestCount, ref budget, ref shoppingCart);
                    }

                    SaveAndLoad.Load(fileSaved, ref activityDate, ref guestCount, ref budget, ref shoppingCart);
                    break;

                case 10: //Shopping Cart Menu           
                    DisplayMenu.DisplayShoppingCart(shoppingCart, WhatIsYourGuestCount, WhatIsYourBudget.GetBudget(), "Shopping Cart Menu");
                    break;

                case 11: //Exit
                    running = false;
                    Console.WriteLine("Thank you for using the Ward Activities Meal Planner! Have a great day!");
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