using System;

//New c# file Journal.cs
Journal journal = new Journal();

//opening dialog
Console.WriteLine("Welcome to your personal journal!");

//run following menu in a loop
bool running = true;
while (running)

{
    Console.WriteLine("Please select one of the following options:");
    //Menu Choices
    Console.WriteLine("1. Write");
    Console.WriteLine("2. Display");
    Console.WriteLine("3. Load");
    Console.WriteLine("4. Save");
    Console.WriteLine("5. Quit");
    //User Prompt
    Console.Write("Please select the number for what you like to do: ");
    int userInput = int.Parse(Console.ReadLine());
    Console.WriteLine();//adds a space like print()

    switch (userInput)//used the switch 
    {
        //option 1. Write
        case 1:
            journal.NewEntry();
            Console.WriteLine();
            break;

        //option 2. Display
        case 2:
            journal.DisplayEntry();//under Journal.cs
            Console.WriteLine();
            break;

        //option 3. Load
        case 3:
            Console.Write("Enter the file name you wish to load: ");
            string loadFileName = Console.ReadLine();
            journal.LoadEntry(loadFileName);
            Console.WriteLine();
            break;

        //option 4. Save
        case 4: //make sure to save under csv file
        //program will save under a csv file even if you don't add '.csv'
            Console.Write("Please name your save file: ");
            string fileName = Console.ReadLine();
            Console.WriteLine("Saving...");
            try //used try and catch because I was having errors by saving the file
            {
                journal.SaveEntry(fileName);
                Console.WriteLine("File Saved. \n");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

            break;

        //option 5. Quit
        case 5:
            running = false; //this will stop the loop
            Console.WriteLine("Thank you for using your personal journal!");
            Console.WriteLine("Goodbye! \n");
            break;

        //Default used as else
        default:
            Console.WriteLine("Invalid input! Please enter your choices between the numbers 1 and 5! \n");
            break;
    }



}
