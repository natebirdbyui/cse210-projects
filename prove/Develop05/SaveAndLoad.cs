using System;
using System.Collections.Generic;
using System.Threading;
using System.IO;

public class SaveAndLoad
{
    public static void SaveGoals(List<Goals> goals)//saving Goals to a file
    {
        Console.Write("Enter the name of the file you would like to save to: ");
        string fileName = Console.ReadLine();

        using (StreamWriter file = new StreamWriter(fileName))
        {
            foreach (Goals g in goals)
            {
                file.WriteLine(g.GetStringRepresentation());
            }
        }
        LoadingSymbol.DisplayLoadingSymbol();
        Console.WriteLine($"File saved successfully! \n Filename: {fileName}");
    }

    public static List<Goals> LoadGoals()//Loading files
    {
        List<Goals> goals = new List<Goals>();

        Console.Write("Enter the name of the file you would like to load: ");
        string fileName = Console.ReadLine();

        if (!File.Exists(fileName))
        {
            Console.WriteLine("File does not exist.");
            return goals;
        }

        try
        {
            string[] lines = File.ReadAllLines(fileName);
            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                {
                    continue;//skips the line if it is empty
                }
                try
                {
                    Goals goal = Goals.FromString(line);
                    if (goal != null)//if the goal is not null
                    {
                        goals.Add(goal);//adding the goal to the list
                    }
                    else
                    {
                        Console.WriteLine("Error loading goal: " + line);
                    }
                }
                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine("Error loading file: " + e.Message);
                }
            }

            LoadingSymbol.DisplayLoadingSymbol();
            Console.WriteLine($"File loaded successfully! \n Filename: {fileName}");
        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine("Error loading file: " + e.Message);
        }

        return goals;
    }
}