using System;
using System.Collections.Generic;
using System.Threading;
class SideCourse : FoodMenu
{
    public static List<FoodMenu> _sideCourseMenuItems = new List<FoodMenu>();

    public SideCourse(string menuItems, double weightLbs, int packQuantity, double itemPrice, double servingSize)
    : base(menuItems, weightLbs, packQuantity, itemPrice, servingSize)
    {
        _sideCourseMenuItems.Add(this);
    }

    public override List<FoodMenu> GetMenuItems()
    {
        return _sideCourseMenuItems;
    }
    public static List<FoodMenu> GetSideCourseMenuItems()
    {
        return _sideCourseMenuItems;
    }

    static SideCourse() //name, weight, pack quantity, price/lb, serving size
    {
        new SideCourse("Baked Potato", 0.375, 1, 0.35, 1);
        new SideCourse("Mashed Potato", 0.375, 1, 0.07, 1);
        new SideCourse("Salad Mix", 5, 1, 1.09, 30);
        new SideCourse("Green Beans", 6, 1, 2.23, 20);
        new SideCourse("Rolls", 1, 16, 2.59, 16);
        new SideCourse("Jello", 1.5, 12, 0.135, 40);
        new SideCourse("Potato Salad", 5, 1, 2.34, 40);
        new SideCourse("Macaroni Salad", 5, 1, 2.34, 40);
        new SideCourse("Corn on the Cob", 0.5, 1, 0.12, 1);
        new SideCourse("Mixed Fruit", 6.5, 1, 2.52, 20);
    }
}