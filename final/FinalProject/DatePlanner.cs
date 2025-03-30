using System;
using System.Collections.Generic;
using System.Threading;
using System.IO;
using System.Globalization;


class DatePlanner
{
    public void DatePlan()
    {
        Console.WriteLine("Please type the date of your event (MM/DD/YYYY): ");
        string dateInput = Console.ReadLine();
        Console.WriteLine("Please type the time of your event (HH:MM AM/PM): ");
        string timeInput = Console.ReadLine();
        Console.WriteLine("Please type the location of your event: ");
        string locationInput = Console.ReadLine();

        string dateTotal = $"{dateInput} {timeInput}"; 
        
        if (DateTime.TryParseExact(dateTotal, "MM/dd/yyyy HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime targetDate))//parse date and time
        {
            Console.WriteLine("Your event is scheduled for: " + targetDate);
            Console.WriteLine("Location: " + locationInput);
            StartCountdown(targetDate);
        }
        else
        {
            Console.WriteLine("Invalid date and time format. Please try again. (MM/DD/YYYY) & (HH:MM 24-hour format)");
        }

        static void StartCountdown(DateTime targetDate)
        {
            while (true)
            {
                TimeSpan countdown = targetDate - DateTime.Now;
                

                if (countdown.TotalSeconds <= 0)
                {
                Console.WriteLine("The event has come to pass.");
                Thread.Sleep(1000);
                Console.WriteLine("Hopefully you made it on time!");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Time Remaining Countdown: Press any key to exit countdown.");
                    Console.WriteLine($"{countdown.Days} days, {countdown.Hours} hours, {countdown.Minutes} minutes, {countdown.Seconds} seconds");
                    Thread.Sleep(1000);

                    if (Console.KeyAvailable)
                    {
                        Console.ReadKey(true);
                        break;
                    }
                }
            }
            
                
        }


    }
}
