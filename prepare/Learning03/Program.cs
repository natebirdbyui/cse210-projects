using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Welcome to Fraction Maker!");
    

        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue()+"\n");
        

        Fraction f2 = new Fraction(6);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue()+"\n");

        Fraction f3 = new Fraction(6,7);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue()+"\n");

        Fraction f4 = new Fraction(5);
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue()+"\n");

        Fraction f5 = new Fraction(3,4);
        Console.WriteLine(f5.GetFractionString());
        Console.WriteLine(f5.GetDecimalValue()+"\n");

        Fraction f6 = new Fraction(1,3);
        Console.WriteLine(f6.GetFractionString());
        Console.WriteLine(f6.GetDecimalValue()+"\n");
    }
}
