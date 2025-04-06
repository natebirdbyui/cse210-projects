using System;

class GuestCount
{
    private int _guestCount;

    public GuestCount(int guestCount)
    {
        _guestCount = guestCount;
    }
    public int GetGuestCount()
    {
        return _guestCount;
    }
    public void SetGuestCount(int guestCount)
    {
        _guestCount = guestCount;
    }

    public void WhatIsYourGuestCount()
    {
        Console.Write("Please enter the number of guests: ");

        if (int.TryParse(Console.ReadLine(), out int guestCount))
        {
            _guestCount = guestCount;
            Seating seating = new Seating(guestCount);
            Console.WriteLine($"Minimal tables needed: {seating.MinimalTables()}");
            Console.WriteLine($"Average seating tables needed: {seating.AverageSeatingTables()}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            WhatIsYourGuestCount();
        }

    }
}