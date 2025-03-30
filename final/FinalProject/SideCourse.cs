using System;
using System.Collections.Generic;
using System.Threading;
class SideCourse : FoodMenu
{
    public SideCourse(string menuItems, double weight, int packQuantity, double itemPrice, double servingSize) : base(menuItems, weight, packQuantity, itemPrice, servingSize)
    {
        SetMenuItems(new List<FoodMenu>
        {
            new SideCourse("Baked Potato",0.375,1,0.07,1),
            new SideCourse("Mashed Potato", 0.375, 1, 0.07, 1),
            new SideCourse("Salad Mix", 5, 1, 5.49, 30),
            new SideCourse("Green Beans", 6, 1, 8.39, 20),
            new SideCourse("Rolls", 1.125, 12, 2.59, 12),
            new SideCourse("Jello", 2,12,1.50,20),
            new SideCourse("Potato Salad", 5,1,11.69,80),
            new SideCourse("Macaroni Salad", 5,1,11.69,80),
            new SideCourse("Corn on the Cob", 0.5, 1, 0.25, 1),
            new SideCourse("Mixed Fruit", 6.5, 1, 16.39, 20),
        });
    }


}