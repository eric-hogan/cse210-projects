using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Fraction f = new Fraction();
        f.SetTopNumber(4);

        Console.WriteLine(f.GetTopNumber());
    }
}