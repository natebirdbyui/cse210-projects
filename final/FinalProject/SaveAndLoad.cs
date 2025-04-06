using System;
using System.Collections.Generic;
using System.IO;

public class SaveAndLoad
{
    public static void Save(string fileSaved, string activityDate, int guestCount, double budget, List<FoodMenu> shoppingCart)
    {
        if (string.IsNullOrEmpty(fileSaved))
        {
            Console.WriteLine("File name cannot be empty.");
            return;
        }
        try
        {
            using (StreamWriter file = new StreamWriter(fileSaved))
            {
                file.WriteLine("#ActivityDate");//# helps to identify section header
                file.WriteLine(activityDate);

                file.WriteLine("#GuestCount");
                file.WriteLine(guestCount);

                file.WriteLine("#Budget");
                file.WriteLine(budget);

                file.WriteLine("#ShoppingCart");
                file.WriteLine("MenuType, ItemName, ServingSize, PricePerPound");

                foreach (FoodMenu item in shoppingCart)
                {
                    file.WriteLine($"{item.GetMenuItemsName()},{item.GetWeightLbs()},{item.GetPackQuantity()},{item.GetItemPrice()},{item.GetServingSize()}");
                }
            }
            Console.WriteLine($"File saved successfully as: {fileSaved}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while saving the file: {ex.Message}");
        }
    }

    public static void Load(string fileSaved, ref string activityDate, ref int guestCount, ref double budget, ref List<FoodMenu> shoppingCart)
    {
        if (!File.Exists(fileSaved))
        {
            Console.WriteLine($"File not found: {fileSaved}");
            return;
        }

        try
        {
            string[] lines = File.ReadAllLines(fileSaved);
            string currentSection = "";
            bool skipHeader = false;

            foreach (string line in lines)
            {
                if (line.StartsWith("#"))
                {
                    currentSection = line;
                    skipHeader = true;
                    continue;
                }

                if (skipHeader)
                {
                    skipHeader = false;
                    if (currentSection == "#ShoppingCart")
                        continue;
                }

                switch (currentSection)
                {
                    case "#ActivityDate":
                        activityDate = line;
                        break;
                    case "#GuestCount":
                        int.TryParse(line.Trim(), out guestCount);
                        break;

                    case "#Budget":
                        double.TryParse(line.Trim(), out budget);
                        break;

                    case "#ShoppingCart":
                        string[] parts = line.Split(',');
                        if (parts.Length == 4)
                        {
                            FoodMenu item = null;//cant do this in the constructor because it is abstract class, so breaking it down in its child classes.
                            if (parts[0] == "MainCourse")
                            {
                                item = new MainCourse(parts[1], double.Parse(parts[2]), int.Parse(parts[3]), double.Parse(parts[4]), double.Parse(parts[5]));
                            }
                            if (parts[0] == "SideCourse")
                            {
                                item = new SideCourse(parts[1], double.Parse(parts[2]), int.Parse(parts[3]), double.Parse(parts[4]), double.Parse(parts[5]));
                            }
                            if (parts[0] == "Beverages")
                            {
                                item = new Beverages(parts[1], double.Parse(parts[2]), int.Parse(parts[3]), double.Parse(parts[4]), double.Parse(parts[5]));
                            }
                            if (parts[0] == "Condiments")
                            {
                                item = new Condiments(parts[1], double.Parse(parts[2]), int.Parse(parts[3]), double.Parse(parts[4]), double.Parse(parts[5]));
                            }

                            shoppingCart.Add(item);
                        }
                        break;
                }
            }
            Console.WriteLine($"File loaded successfully: {fileSaved}");
        }

        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while loading the file: {ex.Message}");
        }
    }
}

