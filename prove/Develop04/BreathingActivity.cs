using System;
using System.Threading;

namespace cse210_projects.prove.Develop04
{
    public class BreathingActivity : Activity //call base(parent) class Activity
    {
        private string _breatheIn = "Breathe In...";
        private string _breathOut = "Breathe Out...";

        

        
        public BreathingActivity(int sessionTimeSeconds) : base("BreathingActivity", "In this activity, we will help you relax and focus on your breathing.")
        {
            _sessionTimeSeconds = sessionTimeSeconds;
        }



        public void StartBreathingExercise()
        {
            WelcomeMessage();//use method from Activity class

            Console.WriteLine($"DEBUG: _sessionTimeSeconds = {_sessionTimeSeconds}");//debugging

            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(_sessionTimeSeconds);

            while (DateTime.Now < endTime)
            {

                Console.WriteLine(_breatheIn);
                CountDownTimer(4);//use method from Activity class and set the timer to 4 seconds
                Thread.Sleep(200);

                Console.WriteLine(_breathOut);
                CountDownTimer(4);//use method from Activity class and set the timer to 4 seconds
                Thread.Sleep(200);

                if (DateTime.Now >= endTime)//checks if it still has time remaining
                {
                    break;
                }
                
            }

            Console.WriteLine("Congratulations! You have completed the Breathing Activity.\n");

        }
    }
}