using System;
using System.Collections.Generic;
using System.Threading;
class Condiments : FoodMenu
{
    public static List<FoodMenu> _condimentsMenuItems = new List<FoodMenu>();
    public Condiments(string menuItems, double weightLbs, int packQuantity, double itemPrice, double servingSize)
    : base(menuItems, weightLbs, packQuantity, itemPrice, servingSize)
    {
        _condimentsMenuItems.Add(this);
    }

    public override List<FoodMenu> GetMenuItems()
    {
        return _condimentsMenuItems;
    }
    public static List<FoodMenu> GetCondimentsMenuItems()
    {
        return _condimentsMenuItems;
    }

    static Condiments() //name, weight, pack quantity, price, serving size
    {
        new Condiments("Mustard (packets)", 0.0154324, 500, 17.39, 250);
        new Condiments("Mayonnaise (packets)", 0.0264555, 200, 17.49, 200);
        new Condiments("Ketchup (packets)", 0.0198416, 1000, 23.99, 500);
        new Condiments("Salt (packets)", 0.00110231, 1000, 3.49, 500);
        new Condiments("Pepper (packets)", 0.000220462, 1000, 5.89, 1000);
        new Condiments("Whipped Margarine (packets)", 0.0110231, 600, 35.59, 300);
        new Condiments("Cheese", 5, 1, 3.07, 80);
        new Condiments("Sour Cream", 5, 1, 9.89, 80);
    }

}