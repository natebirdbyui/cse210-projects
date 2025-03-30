using System;
using System.Collections.Generic;
using System.Threading;
class Beverages : FoodMenu
{
    private List<Beverages> _beverages;
    public Beverages(string menuItems, double weight, int packQuantity, double itemPrice, double servingSize) : base(menuItems, weight, packQuantity, itemPrice, servingSize)
    {
        SetMenuItems(new List<FoodMenu>
        {
            new Beverages("Lemonade", 0, 1, 3.39, 48),
            new Beverages("Strawberry Lemonade", 0, 1, 3.39, 48),
            new Beverages("Fruit Punch", 0, 1, 3.39, 48),
            new Beverages("Tap Water", 0, 1, 0, 1),
        });
    }



}