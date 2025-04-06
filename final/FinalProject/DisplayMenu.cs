using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;

class DisplayMenu
{
    private FoodMenu _menuItems;
    private Budget _budget;//
    private GuestCount _guestCount;//
    public DisplayMenu(FoodMenu menuItems, double budget, int guestCount)
    {
        _menuItems = menuItems;
        _budget = new Budget(budget);
        _guestCount = new GuestCount(guestCount);//
    }
    public virtual void ShowMenu()
    {
        foreach (var item in _menuItems.GetMenuItems())//should return a list of menu items
        {
            //Console.WriteLine($"{item.GetMenuItems()} | {item.GetWeightLbs()} | {item.GetPackQuantity()} | {item.GetItemPrice()} | {item.GetServingSize()}");
            PrintMenuItem(item); //This method should print the menu item in a formatted way
        }

    }

    public static void ShowMenuAndAddToCart(List<FoodMenu> menuItems, List<FoodMenu> shoppingCart, string menuType)
    {
        //Console.Clear();
        Console.WriteLine($"===================================={menuType}=====================================");
        Console.WriteLine($"Menu Item           Weight(lbs)       Quantity      Price Per Pound    Serving Size");
        Console.WriteLine($"-----------------------------------------------------------------------------------");

        for (int i = 0; i < menuItems.Count; i++)
        {
            var item = menuItems[i];
            Console.WriteLine($"{i + 1}. {item.GetMenuItemsName(),-20} | {item.GetWeightLbs(),-10} | {item.GetPackQuantity(),-10} | {item.GetItemPrice(),-10} | {item.GetServingSize(),-10}");
        }

        while (true)
        {
            Console.WriteLine("Please select an item to add to your shopping cart (enter the number & '0' to end list): ");
            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                if (choice == 0)
                {
                    Console.WriteLine("Exiting menu selection.");
                    Thread.Sleep(1000);
                    return;
                }
                else if (choice > 0 && choice <= menuItems.Count)
                {
                    var selectedItem = menuItems[choice - 1];
                    shoppingCart.Add(selectedItem);
                    Console.WriteLine($"Added {selectedItem.GetMenuItemsName()} to your shopping cart.");
                    continue;
                }
                else
                {
                    Console.WriteLine("Invalid selection. Please try again.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.WriteLine("Returning to main menu...");
            Console.Clear();
        }
    }
    public static void DisplayShoppingCart(List<FoodMenu> shoppingCart, GuestCount guestCount, double budget, string menuType)
    {
        if (shoppingCart.Count == 0)
        {
            Console.WriteLine("Your shopping cart is empty.");
            return;
        }

        Console.WriteLine("================================= Shopping Cart =============================================");
        Console.WriteLine($"----------------------------Menu Type: {menuType}-------------------------------------------");
        Console.WriteLine($"         Guest Count: {guestCount.GetGuestCount()}     |       Budget: {budget:C2}");
        Console.WriteLine("Menu Item           Weight(lbs)   Quantity   Price Per Pound   Serving Size       Total Price");
        Console.WriteLine("---------------------------------------------------------------------------------------------");

        double overallTotalPrice = 0;
        foreach (var item in shoppingCart)
        {
            double servingsNeeded = Math.Ceiling((double)guestCount.GetGuestCount() / item.GetServingSize());
            double itemTotalPrice = servingsNeeded * item.GetWeightLbs() * item.GetItemPrice();
            overallTotalPrice += itemTotalPrice;

            Console.WriteLine($"{item.GetMenuItemsName(),-20} | {item.GetWeightLbs(),-10} | {item.GetPackQuantity(),-10} | {item.GetItemPrice(),-15} | {item.GetServingSize(),-10} | {itemTotalPrice:C2}");
            //C2 is for currency format
        }
        //double overallTotalPrice = FoodMenu.CalculateFoodPrice(shoppingCart, guestCount);
        Console.WriteLine("---------------------------------------------------------------------------------------------");
        Console.WriteLine($"Total Price for {guestCount.GetGuestCount()} guests: {overallTotalPrice:C2}");
        Console.WriteLine("=============================================================================================");

        if (overallTotalPrice > budget)
        {
            Console.WriteLine($"Warning: Your total price of {overallTotalPrice:C2} exceeds your budget of {budget:C2}.");
        }
        else
        {
            Console.WriteLine($"Your total price of {overallTotalPrice:C2} is within your budget of {budget:C2}.");
        }
    }

    private void PrintMenuItem(FoodMenu item)
    {
        Console.WriteLine($"{item.GetMenuItemsName(),-20} | {item.GetWeightLbs(),-10} | {item.GetPackQuantity(),-10} | {item.GetItemPrice(),-10} | {item.GetServingSize(),-10}");
    }
}


