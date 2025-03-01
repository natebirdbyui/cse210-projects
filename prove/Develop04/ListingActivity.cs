using System;
using System.Threading;
using System.Collections.Generic;

namespace cse210_projects.prove.Develop04
{
    public class ListingActivity : Activity
    {
        private string _listPonder;

        private Random rand2 = new Random();
        public ListingActivity(int sessionTimeSeconds) : base("ListingActivity", "In this activity, we will help you focus on listing things that you are grateful for.")
        {
            _sessionTimeSeconds = sessionTimeSeconds;
        }

        List<string> listPonder = new List<string>()
        {
            // enter commas here to break each prompt...
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
        public void StartListing()
        {
            WelcomeMessage();
            Console.WriteLine("Think of three things that you are grateful for.");
            
            Console.WriteLine($"DEBUG: _sessionTimeSeconds = {_sessionTimeSeconds}");//Debugging
            
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(_sessionTimeSeconds);

            List<string> availableListPonder = new List<string>(listPonder);
            List<string> userResponse = new List<string>();

            while (DateTime.Now < endTime && availableListPonder.Count > 0)
            {
                int listIndex2 = rand2.Next(availableListPonder.Count);
                string _listPonder = availableListPonder[listIndex2];
                availableListPonder.RemoveAt(listIndex2);//this will remove the prompt from the list so it doesn't repeat

                Console.WriteLine("\n" + _listPonder);
                CountDownTimer(5);
                Console.Write(">> ");//easy prompt for user to know where to type

                string listingInput = Console.ReadLine();
                userResponse.Add(listingInput);//stores the user's response in a separate list

                if (DateTime.Now >= endTime)
                {
                    break;
                }
            }

            Console.WriteLine();
            Console.WriteLine($"You have listed {userResponse.Count} things. Great job!");


            Console.WriteLine("Congratulations! You have completed the Listing Activity.");
        }
        public string GetListPonder()
        {
            return _listPonder;
        }
        public void SetListPonder(string listPonder)
        {
            _listPonder = listPonder;
        }
    }
}
