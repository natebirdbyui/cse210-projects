using System;
using System.Collections.Generic;
using System.Threading;

public abstract class Shape // since there is an abstract below we have to make sure that the class is also abstract
{
    private string _color;

    public string GetColor()
    {
        return _color;
    }
    public Shape(string color)
    {
        _color = color;
    }

    public abstract double GetArea();
}

