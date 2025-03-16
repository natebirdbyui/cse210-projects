using System;
using System.Collections.Generic;
using System.Threading;

public class LoadingSymbol
{
    public static void DisplayLoadingSymbol()
    {
        {
            string[] animation = { "/", "-", "\\", "|" };
            for (int i = 0; i < 10; i++)
            {
                Console.Write(animation[i % animation.Length] + "\r");
                Thread.Sleep(200);
            }
            Console.WriteLine(); // Move to next line after animation
        }
    }

}