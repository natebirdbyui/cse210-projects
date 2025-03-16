using System;
using System.Collections.Generic;
using System.Threading;

public class SimpleGoal : Goals
{

    public SimpleGoal(string nameOfGoal, int points) : base(nameOfGoal, points)
    {
    }

    public override int GetPoints()
    {
        return _points;
    }
    public override void SetPoints(int points)
    {
        _points = points;
    }
    public override void MarkCompleted()
    {
        _isCompleted = true;
    }
    public override bool GetIsCompleted()
    {
        return _isCompleted;
    }


    public override string GetStringRepresentation()
    {
        return $"Simple Goal|{_nameOfGoal}|{_points}|{_isCompleted}";
    }

    public override void LoadFromString(string data)
    {
        string[] parts = data.Split('|');
        if (parts.Length == 4)
        {
            _nameOfGoal = parts[1];
            _points = int.Parse(parts[2]);
            _isCompleted = bool.Parse(parts[3]);
        }
    }


}