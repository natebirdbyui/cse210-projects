using System;
using System.Collections.Generic;
using System.Threading;
using System.IO;
using System.Diagnostics.Contracts;
using System.Data;
using System.Linq.Expressions;

class Budget
{
    private double _budget;
    private double _finalBudget;
    private double _difference;

    public Budget(double budget)
    {
        _budget = budget;
    }
    public double GetBudget()
    {
        return _budget;
    }
    public void SetBudget(double budget)
    {
        _budget = budget;
    }
    public double GetFinalBudget()
    {
        return _finalBudget;
    }
    public void SetFinalBudget(double overallTotalPrice)
    {
        _finalBudget = overallTotalPrice;
    }
    public double GetDifference()
    {
        return _difference;
    }
    public double CalculateDifference()
    {
        _difference = _budget - _finalBudget;
        return _difference;
    }

    public void WhatIsYourBudget()
    {
        Console.Write("Please enter your budget: $");

        if (double.TryParse(Console.ReadLine(), out double input))
        {
            _budget = input;
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            WhatIsYourBudget();
        }
    }

    public void DisplayBudget(double overallTotalPrice)
    {
        Console.WriteLine($"Your budget for your ward activity is: {_budget:C2}");
        Console.WriteLine($"You have spent, {overallTotalPrice:C2} on your menu items.");
        Console.WriteLine($"You have ${CalculateDifference():C2} remaining in your budget.");
        if (_difference < 0)
        {
            Console.WriteLine($"You have exceeded your budget by ${Math.Abs(_difference):C2}.");
        }
        else
        {
            Console.WriteLine($"You are within your budget by ${_difference:C2}.");
        }
    }
}