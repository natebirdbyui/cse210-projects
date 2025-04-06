using System;
using System.Security.Cryptography.X509Certificates;

public abstract class FoodMenu
{
    //protected string _menuItems;
    protected string _menuItems;
    protected double _weightLbs;
    protected int _packQuantity;
    protected double _itemPrice;
    protected double _servingSize;



    public FoodMenu(string menuItems, double weightLbs, int packQuantity, double itemPrice, double servingSize)
    {
        _menuItems = menuItems;
        _weightLbs = weightLbs;
        _packQuantity = packQuantity;
        _itemPrice = itemPrice;
        _servingSize = servingSize;
    }

    public static double CalculateFoodPrice(List<FoodMenu> shoppingCart, int guestCount)
    {
        double totalPrice = 0;

        foreach (var item in shoppingCart)
        {
            double servingsNeeded = Math.Ceiling((double)guestCount / item.GetServingSize()); //round up to the nearest whole number
            double totalQuantity = Math.Ceiling(servingsNeeded);
            double itemTotalPrice = (item.GetItemPrice() > 0) ? servingsNeeded * item.GetWeightLbs() * item.GetItemPrice() : 0; //calculate the total price for each item
            //this will help with tap water that the price is 0.00.
            totalPrice += itemTotalPrice; //add the total price for each item to the total price
        }

        return totalPrice;
    }

    public virtual List<FoodMenu> GetMenuItems()
    {
        return new List<FoodMenu>();
    }
    public string GetMenuItemsName()
    {
        return _menuItems;
    }
    public void SetMenuItems(string menuItems)
    {
        _menuItems = menuItems;
    }
    public virtual double GetWeightLbs()
    {
        return _weightLbs;
    }
    public void SetWeightLbs(double weightLbs)
    {
        _weightLbs = weightLbs;
    }
    public virtual int GetPackQuantity()
    {
        return _packQuantity;
    }
    public void SetPackQuantity(int packQuantity)
    {
        _packQuantity = packQuantity;
    }
    public virtual double GetItemPrice()
    {
        return _itemPrice;
    }
    public void SetItemPrice(double itemPrice)
    {
        _itemPrice = itemPrice;
    }
    public virtual double GetServingSize()
    {
        return _servingSize;
    }
    public void SetServingSize(double servingSize)
    {
        _servingSize = servingSize;
    }
    public override string ToString()
    {
        return $"{_menuItems,-20} {_weightLbs,-15:F2} {_packQuantity,-13} {_itemPrice,-18:C2} {_servingSize}";
        //F2 formats the weight to 2 decimal places, C2 formats the price to 2 decimal places with a dollar sign
    }


}












