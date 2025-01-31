using System;
using System.Collections.Generic;

public class Entry
{
    public string _date;
    
    public string _prompt;
    public string _response;

    public void GenerateDate()
    {
        DateTime theCurrentTime = DateTime.Now;
        
        string dateText = theCurrentTime.ToString();
        _date = dateText;
    }

    public void GeneratePrompt()
    {
        List<string> prompts = new List<string>()
        {//each prompt is separated by ','s(commas) and " " (double quotes)
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "If I could be an animal for a day, what would I be and why?",
        "What is my favorite thing about myself?",
        "What can I do to make tomorrow better than today?",
        "What is my favorite thing about my best friend?",
        "What is my favorite thing about my family?",
        "What is my favorite thing about my job?",
        "What is my favorite thing about my home?",
        "What is my favorite thing about my favorite food?",
        };
        //Random prompts
        Random rand = new Random();
        int randomIndex = rand.Next(prompts.Count);
        _prompt = prompts[randomIndex];
        Console.WriteLine(_prompt);
    }

    public void GetResponse()
    {
        Console.Write("> ");//Makes it look like a data entry
        _response = Console.ReadLine();
    }
}