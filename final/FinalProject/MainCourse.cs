using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
class MainCourse : FoodMenu
{
    private List<MainCourse> mainCourse;


    public MainCourse(string menuItems, double weight, int packQuantity, double itemPrice, double servingSize) : base(menuItems, weight, packQuantity, itemPrice, servingSize)
    {
        SetMenuItems(new List<FoodMenu>
        {
            new MainCourse("Ham", 9, 1, 2.48, 22.4),
            new MainCourse("Steak-Petite", 0.6, 1, 3.99, 1),
            new MainCourse("Hamburger Patty", 0.25, 18, 23.99, 18),
            new MainCourse("Hot Dog", 0.25, 14, 11.99, 14),
            new MainCourse("Chicken Breast", 1, 1, 2.59, 3),
            new MainCourse("Chicken Wings", 0.1875,24,1.89,6),
            new MainCourse("Chicken Thighs", 0.1875,18,2.29,18),
            new MainCourse("Roast Beef Top Round", 3, 1, 5.99, 12),
        });
    }



    // List<MainCourse> mainCourse = new List<MainCourse>()
    // //name, weight, pack quantity, price, serving size
    // {
    //     new MainCourse("Ham", 9, 1, 2.48, 22.4),
    //     new MainCourse("Steak-Petite", 0.6, 1, 3.99, 1),
    //     new MainCourse("Hamburger Patty", 0.25, 18, 23.99, 18),
    //     new MainCourse("Hot Dog", 0.25, 14, 11.99, 14),
    //     new MainCourse("Chicken Breast", 1, 1, 2.59, 3),
    //     new MainCourse("Chicken Wings", 0.1875,24,1.89,6),
    //     new MainCourse("Chicken Thighs", 0.1875,18,2.29,18),
    //     new MainCourse("Roast Beef Top Round", 3, 1, 5.99, 12),
    // };



}