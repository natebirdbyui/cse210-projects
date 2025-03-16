using System;
using System.Collections.Generic;
using System.Threading;


public abstract class Goals
{
    protected string _nameOfGoal;
    protected int _points;
    protected string _goal;
    protected string _goalsCompleted;
    protected bool _isCompleted;

    //abstract methods to be implemented in the child classes
    public abstract string GetStringRepresentation();
    public abstract void LoadFromString(string data);

    public Goals(string nameOfGoal, int points)
    {
        _nameOfGoal = nameOfGoal;
        _points = points;
        _isCompleted = false;
    }

    //getters and setters for each of the fields
    public virtual bool GetIsCompleted()
    {
        return _isCompleted;
    }
    public void SetIsCompleted(bool isCompleted)
    {
        _isCompleted = isCompleted;
    }

    
    public string GetNameGoal()
    {
        return _nameOfGoal;
    }
    public void SetNameGoal(string nameOfGoal)
    {
        _nameOfGoal = nameOfGoal;
    }
    public virtual int GetPoints()//helps for simple goals and eternal goals to override
    {
        return _points;
    }
    public virtual void SetPoints(int points)
    {
        _points = points;
    }
    public string GetGoal()
    {
        return _goal;
    }
    public void SetGoal(string goal)
    {
        _goal = goal;
    }
    public string GetGoalsCompleted()
    {
        return _goalsCompleted;
    }
    public void SetGoalsCompleted(string goalsCompleted)
    {
        _goalsCompleted = goalsCompleted;
    }

    public virtual void MarkCompleted()//helps for simple goals and eternal goals
    {
        _isCompleted = true;
    }

    public void goalsCompleted(List<Goals> goals, int goalIndex)
    {
        if (goalIndex >= 0 && goalIndex < goals.Count)
        {
            if (goals[goalIndex] is SimpleGoal simpleGoal)
            {
                simpleGoal.MarkCompleted();
                Console.WriteLine($"Your Goal '{simpleGoal.GetNameGoal()}' has been completed! Great job! :) ");
            }
        }
    }

    public static Goals FromString(string data)
    {
        string[] parts = data.Split('|');
        string goalType = parts[0];

        Goals goals = goalType switch //break down the which goals after selecting case1 on program.cs
        {
            "Simple Goal" => new SimpleGoal(parts[1], int.Parse(parts[2])),//nameOfGoal, points
            "Checklist Goal" => new ChecklistGoal(parts[1], int.Parse(parts[2]), int.Parse(parts[3]), int.Parse(parts[4])),//nameOfGoal, points, numberOfTimesToComplete, bonusPoints
            "Eternal Goal" => new EternalGoal(parts[1], int.Parse(parts[2])),//nameOfGoal, points
            _ => null
        };

        if (goals != null)
        {
            goals.LoadFromString(data);
        }
        return goals;
    }

}
