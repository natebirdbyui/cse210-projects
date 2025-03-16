using System;
using System.Collections.Generic;
using System.Threading;

class ChecklistGoal : Goals
{
    private int _bonusPoints;
    private int _numberOfTimesToComplete;
    private int _timesCurrentlyCompleted;

    public ChecklistGoal(string nameOfGoal, int points, int numberOfTimesToComplete, int bonusPoints) : base(nameOfGoal, points)
    {
        _timesCurrentlyCompleted = 0;
        _numberOfTimesToComplete = numberOfTimesToComplete;
        _bonusPoints = bonusPoints;
    }

    public int GetBonusPoints()
    {
        return _bonusPoints;
    }
    public void SetBonusPoints(int bonusPoints)
    {
        _bonusPoints = bonusPoints;
    }
    public int GetNumberOfTimesToComplete()
    {
        return _numberOfTimesToComplete;
    }
    public void SetNumberOfTimesToComplete(int numberOfTimesToComplete)
    {
        _numberOfTimesToComplete = numberOfTimesToComplete;
    }
    public int GetTimesCurrentlyCompleted()
    {
        return _timesCurrentlyCompleted;
    }
    public void SetTimesCurrentlyCompleted(int timesCurrentlyCompleted)
    {
        _timesCurrentlyCompleted = timesCurrentlyCompleted;
    }

    public override string GetStringRepresentation()
    {
        return $"Checklist Goal|{_nameOfGoal}|{_points}|{_timesCurrentlyCompleted}|{_numberOfTimesToComplete}|{_bonusPoints}";
    }

    public override void LoadFromString(string data)
    {
        string[] parts = data.Split('|');
        if (parts.Length == 7)
        {
            _nameOfGoal = parts[1];
            _points = int.Parse(parts[2]);
            _timesCurrentlyCompleted = int.Parse(parts[3]);
            _numberOfTimesToComplete = int.Parse(parts[4]);
            _bonusPoints = int.Parse(parts[5]);
            _isCompleted = bool.Parse(parts[6]);
        }
    }
    
}