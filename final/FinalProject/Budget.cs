using System;
using System.Collections.Generic;
using System.Threading;
using System.IO;
using System.Diagnostics.Contracts;
using System.Data;

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
    public void SetFinalBudget(double finalBudget)
    {
        _finalBudget = finalBudget;
        double difference = CalculateDifference();
        Console.WriteLine($"Your budget was ${_budget} and you spent ${_finalBudget}. You were ${_difference} under budget.");
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




    
}