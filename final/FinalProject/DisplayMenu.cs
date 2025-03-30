using System;
using System.Collections.Generic;
using System.Threading;

class DisplayMenu
{
    private FoodMenu _menu;
    private Budget _budget;
    private GuestCount _guestCount;

    public DisplayMenu(FoodMenu menu, double budget, int guestCount)
    {
        _menu = menu;
        _budget = new Budget(budget);
        _guestCount = new GuestCount(guestCount);
    }
    

    public virtual void ShowMenu()
    {
        foreach (var item in _menu.GetMenuItems())//should return a list of menu items
        {
            Console.WriteLine($"{item.GetMenuItems()} | {item.GetWeightLbs()} | {item.GetPackQuantity()} | {item.GetItemPrice()} | {item.GetServingSize()}");
        }
        
    }

}