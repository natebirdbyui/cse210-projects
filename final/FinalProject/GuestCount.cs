using System;
using System.Collections.Generic;
using System.Threading;

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
}