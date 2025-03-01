using System;
using System.Threading;
using System.Collections.Generic;

namespace cse210_projects.prove.Develop04
{
    public class ReflectionActivity : Activity
    {
        private string _listPrompt;
        private string _followUpPrompt;        
        private Random rand = new Random();

        List<string> listPrompt = new List<string>()
        {
            //enter your prompts here separated by commas
            "Think of a time when you overcame a challenge.",
            "Think of a time when you stood up for someone else.",
            "Think of a time when you made someone smile.",
            "Think of a time when you made a mistake.",
            "Think of a time when you learned something new.",
            "Think of a time when you felt proud of yourself.",
            "Think of a time you did something selfless."
        };

        List<string> followUpPrompts = new List<string>()
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
        public ReflectionActivity(int sessionTimeSeconds) : base("ReflectionActivity", "In this activity, we will help you reflect on your day.")
        {
            _sessionTimeSeconds = sessionTimeSeconds;
        }
        public void SetTimeSeconds(int sessionTimeSeconds)
        {
            _sessionTimeSeconds = sessionTimeSeconds;
        }
        public void StartReflection()
        {
            WelcomeMessage();

            if (_sessionTimeSeconds <= 0)//prevents invalid input
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                return;
            }

            Console.WriteLine($"DEBUG: _sessionTimeSeconds = {_sessionTimeSeconds}");//debugging

            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(_sessionTimeSeconds);

            List<string> availableListPrompts = new List<string>(listPrompt);
            List<string> availableFollowUpPrompts = new List<string>(followUpPrompts);

            while (DateTime.Now < endTime && availableListPrompts.Count > 0)
            {
                //start with list prompts
                int listIndex = rand.Next(availableListPrompts.Count);
                string _listPrompt = availableListPrompts[listIndex];
                availableListPrompts.RemoveAt(listIndex);//this will remove a prompt that has been used

                Console.WriteLine("\n" + _listPrompt);

                Console.WriteLine("Press ENTER to continue...");
                Console.ReadLine();
                LoadingSymbol();

                if (availableFollowUpPrompts.Count == 0) //this will reset the list when exhausted.
                {
                    availableFollowUpPrompts = new List<string>(followUpPrompts);
                }

                
                //follow up prompts
                int followUpIndex = rand.Next(availableFollowUpPrompts.Count);
                _followUpPrompt = availableFollowUpPrompts[followUpIndex];
                availableFollowUpPrompts.RemoveAt(followUpIndex);//this will remove a prompt that has been used

                Console.WriteLine(_followUpPrompt);

                if (DateTime.Now >= endTime)//checks if it still has time remaining
                {
                    break;
                }
            }
            Console.WriteLine("Congratulations! You have completed the Reflection Activity.");
        }
        public string GetListResponse()
        {
            return _listPrompt;
        }
        public void SetListResponse(string listPrompt)
        {
            _listPrompt = listPrompt;
        }
        public string GetFollowUpPrompts()
        {
            return _followUpPrompt;
        }
        public void SetFollowUpPrompts(string followUpPrompt)
        {
            _followUpPrompt = followUpPrompt;
        }
    }
}