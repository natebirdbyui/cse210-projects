using System;
using System.Collections.Generic;
using System.Threading;
class Beverages : FoodMenu
{
    private static List<FoodMenu> _beveragesMenuItems = new List<FoodMenu>();
    public Beverages(string menuItems, double weightLbs, int packQuantity, double itemPrice, double servingSize) :
    base(menuItems, weightLbs, packQuantity, itemPrice, servingSize)
    {
        _beveragesMenuItems.Add(this);
    }

    public override List<FoodMenu> GetMenuItems()
    {
        return _beveragesMenuItems;
    }
    public static List<FoodMenu> GetBeveragesMenuItems()
    {
        return _beveragesMenuItems;
    }
    static Beverages() //name, weight, pack quantity, price, serving size
    {
        _beveragesMenuItems = new List<FoodMenu>();

        new Beverages("Lemonade", 1, 1, 3.39, 48);
        new Beverages("Strawberry Lemonade", 1, 1, 3.39, 48);
        new Beverages("Fruit Punch", 1, 1, 3.39, 48);
        new Beverages("Tap Water", 1, 1, 0, 1);
    }
}