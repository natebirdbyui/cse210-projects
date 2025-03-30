using System;
using System.Collections.Generic; 
using System.Threading;

class Seating : GuestCount
{
    private int _seating;

    public Seating(int guestCount, int seating) : base(guestCount)
    {
        _seating = seating;
    }

    public void SetSeating(int seating)
    {
        _seating = seating;
    }

    public int MinimalTables()
    {
        return GetGuestCount() / 8; //round tables hold 8 chairs
    }

    public int AverageSeatingTables()
    {
        return GetGuestCount() / 6; //round table average seating is 6
    }
    
    
}