using System;
using System.Threading;
using System.Collections.Generic;

public class Activity
{
    protected string _welcomePrompt;
    protected string _activityPrep;
    protected string _activityName;
    protected string _sessionDuration;
    protected int _sessionTimeSeconds;
    protected int _countDownTimer;
    protected string _congratulationMessage;
    protected string _youMayBegin;


    public Activity(string activityName, string activityPrep)
    {
        _activityName = activityName;
        _activityPrep = activityPrep;
    }

    public void WelcomeMessage()
    {
        LoadingSymbol();
        Console.WriteLine();
        Thread.Sleep(500);

        Console.WriteLine($"Welcome to {_activityName}.\n");
        Thread.Sleep(500);

        Console.WriteLine(_activityPrep);
        Thread.Sleep(500);

        //Console.Write(_sessionDuration);
        Console.WriteLine("Get ready");
        DotLoadingSymbol();//loading animation-should be with "Get Ready..."
        Console.WriteLine("Begin! \n");

    }

    public string GetActivityPrep()
    {
        return "In this activity will help you ";
    }
    public void SetActivityPrep(string activityPrep)
    {
        _activityPrep = activityPrep;
    }
    public string GetSessionDuration()
    {
        return _sessionDuration;
    }
    public void SetSessionDuration(string sessionDuration)
    {
        _sessionDuration = sessionDuration;
    }
    public int GetSessionTimeSeconds()
    {
        while (true)
        {
            Console.Write(_sessionDuration);
            string inputTime = Console.ReadLine();

            if (int.TryParse(inputTime, out _sessionTimeSeconds) && _sessionTimeSeconds > 0)//make sure that the user types in a number
            {
                return _sessionTimeSeconds;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number greater than 0.");
            }
        }

    }
    public void SessionTimeSeconds(int sessionTimeSeconds)
    {
        _sessionTimeSeconds = sessionTimeSeconds;
    }


    public string GetCongratulationMessage()
    {
        return _congratulationMessage;
    }
    public void SetCongratulationMessage(string congratulationMessage)
    {
        _congratulationMessage = congratulationMessage;
    }


    public void LoadingSymbol()
    {
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");


        int i = 0;

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(5);

        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(250);
            Console.Write("\b \b");

            i++;
            if (i >= animationStrings.Count)
            {
                i = 0; //resets the list
            }


        }
    }
    public void DotLoadingSymbol()
    {
        for (int cycle = 0; cycle < 3; cycle++)//this will repeat the dot animation 3x
        {
            for (int i = 1; i <= 3; i++)//this will print 3 dots
            {
                Console.Write("\r" + new string('.', i));//this will erase previous dots and prints new dots
                Thread.Sleep(500);
            }
            Thread.Sleep(250);
            Console.Write("\r ");//this will clear the dots
        }
        Console.WriteLine();
    }
    public void CountDownTimer(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"\r{i}");
            Thread.Sleep(1000);
        }
        Console.WriteLine("\r        \r");
    }
}