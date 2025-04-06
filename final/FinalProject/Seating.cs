using System;
using System.Collections.Generic;
using System.Threading;

class Seating : GuestCount
{
    private int _seating;

    public Seating(int guestCount) : base(guestCount)
    {
    }

    public void SetSeating(int seating)
    {
        _seating = seating;
    }

    public int MinimalTables()
    {
        return (int)Math.Ceiling((double)GetGuestCount() / 8); //round tables hold 8 chairs
    }

    public int AverageSeatingTables()
    {
        return (int)Math.Ceiling((double)GetGuestCount() / 6); //round table average seating is 6
    }
}