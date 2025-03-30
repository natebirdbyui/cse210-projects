using System;

abstract class FoodMenu
{
    //protected string _menuItems;
    private List<FoodMenu> _menuItems;
    protected double _weightLbs;
    protected int _packQuantity;
    protected double _itemPrice;
    protected double _servingSize;
    


    public FoodMenu(string menuItems, double weight, int packQuantity, double itemPrice, double servingSize)
    {
        _menuItems = new List<FoodMenu>();
        _weightLbs = weight;
        _packQuantity = packQuantity;
        _itemPrice = itemPrice;
        _servingSize = servingSize;
    }
    public virtual List<FoodMenu> GetMenuItems()//return a list of menu items
    {
        return _menuItems;
    }
    public void SetMenuItems(List<FoodMenu> menuItems)
    {
        _menuItems = menuItems;
    }
    public virtual double GetWeightLbs()
    {
        return _weightLbs;
    }
    public void SetWeightLbs(double weight)
    {
        _weightLbs = weight;
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










}