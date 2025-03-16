using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Threading;

class EternalGoal : Goals
{
    private bool _hasCompletedOnce;

    public EternalGoal(string nameOfGoal, int points) : base(nameOfGoal, points)
    {
        _hasCompletedOnce = false;

    }

    public override int GetPoints()
    {
        return _hasCompletedOnce ? _points : 0; //only counts for points after the goal is completed for first time
    }

    public override void MarkCompleted()
    {
        _isCompleted = true;
        _hasCompletedOnce = true;

    }
    public override string GetStringRepresentation()
    {
        return $"Eternal Goal|{_nameOfGoal}|{_points}|{_hasCompletedOnce}";
    }

    public bool GetHasCompletedOnce()
    {
        return _hasCompletedOnce;
    }
    public void SetHasCompletedOnce(bool hasCompletedOnce)
    {
        _hasCompletedOnce = hasCompletedOnce;
    }

    public override void LoadFromString(string data)
    {
        string[] parts = data.Split('|');
        _nameOfGoal = parts[1];
        _points = int.Parse(parts[2]);
        _isCompleted = false;//eternal goals are never completed
        _hasCompletedOnce = bool.Parse(parts[4]);

    }

}