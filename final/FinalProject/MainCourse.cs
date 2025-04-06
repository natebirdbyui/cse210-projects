using System;

class MainCourse : FoodMenu
{
    public static List<FoodMenu> _mainCourseMenuItems = new List<FoodMenu>();

    public MainCourse(string menuItems, double weight, int packQuantity, double itemPrice, double servingSize) :
    base(menuItems, weight, packQuantity, itemPrice, servingSize)
    {
        _mainCourseMenuItems.Add(this);
    }
    public override List<FoodMenu> GetMenuItems()
    {
        return _mainCourseMenuItems;
    }
    public static List<FoodMenu> GetMainCourseMenuItems()
    {
        return _mainCourseMenuItems;
    }

    static MainCourse()
    //name, weight, pack quantity, price/lb, serving size
    {
        new MainCourse("Ham", 9, 1, 2.48, 22.4);
        new MainCourse("Steak-Petite", 0.6, 1, 3.99, 1);
        new MainCourse("Hamburger Patty", 0.25, 18, 5.33, 18);
        new MainCourse("Hot Dog", 0.25, 12, 3.99, 12);
        new MainCourse("Chicken Breast", 1, 1, 2.59, 3);
        new MainCourse("Chicken Wings", 0.1875, 80, 1.99, 13);
        new MainCourse("Chicken Thighs", 0.1875, 30, 1.99, 30);
        new MainCourse("Roast Beef Top Round", 3, 1, 5.99, 12);
    }
}