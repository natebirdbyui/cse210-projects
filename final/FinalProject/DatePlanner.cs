using System;
using System.Globalization;

class DatePlanner
{
    private string _date;

    public string GetDate()
    {
        return _date;
    }
    public void SetDate(string date)
    {
        _date = date;
    }

    public void SetActivityDate()
    {
        Console.Write("Please type the date of your event (MM/DD/YYYY): ");
        string dateInput = Console.ReadLine();
        Console.Write("Please type the time of your event (HH:MM)24-Hour Format: ");
        string timeInput = Console.ReadLine();

        string dateTotal = $"{dateInput} {timeInput}";

        if (DateTime.TryParseExact(dateTotal, "MM/dd/yyyy HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime targetDate))//parse date and time
        {
            _date = targetDate.ToString("MM/dd/yyyy HH:mm");

            Console.WriteLine("Your event is scheduled for: " + _date);
            StartCountdown(targetDate);
        }
        else
        {
            Console.WriteLine("Invalid date and time format. Please try again. (MM/DD/YYYY) & (HH:MM 24-hour format)");

        }
    }

    static void StartCountdown(DateTime targetDate)
    {
        while (true)
        {
            TimeSpan countdown = targetDate - DateTime.Now;

            if (countdown.TotalSeconds <= 0)
            {
                Console.WriteLine("The event has come to pass.");
                Thread.Sleep(500);
                Console.WriteLine("Hopefully you made it on time!");
                break;
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