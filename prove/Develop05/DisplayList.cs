using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Threading;

public class DisplayList
{
    public void ShowGoals(List<Goals> goals)
    {
        Console.Clear();
        Console.WriteLine("==============================================================");
        Console.WriteLine("                      GOALS LIST                        ");
        Console.WriteLine("==============================================================");
        Console.WriteLine("#    Type          Name                Points   Progress");
        Console.WriteLine("--------------------------------------------------------------");

        if (goals.Count == 0)
        {
            Console.WriteLine("No Goals have been created yet. Please make some! =)");
            return;
        }

        int totalPoints = 0;//declare points before the loop

        for (int i = 0; i < goals.Count; i++)// this helps count the number of goals in a list
        {
            Goals goal = goals[i];
            string goalType = goal.GetType().Name; //Displays type of Goal--simple, eternal, checklist
            string goalName = goal.GetNameGoal();
            int points = goal.GetPoints();
            string progress = GetGoalProgress(goal, ref totalPoints);

            //This will display each goal in a format
            Console.WriteLine($"{i + 1,-3} {goalType,-12} {goalName,-22} {points,-8} {progress}");
        }

        Console.WriteLine(new string('-', 62));//like python print('-'*62)
        Console.WriteLine($"Total Points: {totalPoints}");
        Console.WriteLine(new string('-', 62));

    }
    private string GetGoalProgress(Goals goal, ref int totalPoints)
    {
        if (goal is SimpleGoal simpleGoal)
        {
            if (simpleGoal.GetIsCompleted())
            {
                totalPoints += simpleGoal.GetPoints();//add points if goal is completed
                return "Completed";
            }
            else
            {
                return "Not Completed";
            }

        }
        else if (goal is EternalGoal eternalGoal)
        {
            if (eternalGoal.GetHasCompletedOnce())
            {
                totalPoints += eternalGoal.GetPoints();//add only if completed once
            }
            return "Eternally Active";

        }
        else if (goal is ChecklistGoal checklistGoal)
        {
            int completedTimes = checklistGoal.GetTimesCurrentlyCompleted();
            int numberOfTimes = checklistGoal.GetNumberOfTimesToComplete();
            int bonusPoints = checklistGoal.GetBonusPoints();

            totalPoints += completedTimes * checklistGoal.GetPoints();
            if (completedTimes >= numberOfTimes)
            {
                totalPoints += bonusPoints;//add points if completed
            }
            return $"{completedTimes}/{numberOfTimes} (Bonus: {bonusPoints})";


        }
        else
        {
            return "Unknown";
        }
    }

}









