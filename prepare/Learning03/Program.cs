using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        Fraction p1 = new Fraction();
        Console.WriteLine(p1.Getfraction());
        Console.WriteLine(p1.GetfractionDeciamls());

        Fraction p2  = new Fraction (5);
        Console.WriteLine(p2.Getfraction());
        Console.WriteLine(p2.GetfractionDeciamls());

        Fraction p3  = new Fraction (3, 4);
        Console.WriteLine(p3.Getfraction());
        Console.WriteLine(p3.GetfractionDeciamls());

        Fraction p4 = new Fraction(1,3);
        Console.WriteLine(p4.Getfraction());
        Console.Write(p4.GetfractionDeciamls());








         
        
    }
}