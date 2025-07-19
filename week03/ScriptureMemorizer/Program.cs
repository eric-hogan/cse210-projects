using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {

        Reference r1 = new Reference("John", 3, 16);
        Reference r2 = new Reference("Alma", 7, 16, 17);

        Console.WriteLine(r1.GetDisplayText());
        Console.WriteLine(r2.GetDisplayText());

        // Word w1 = new Word("hello there");

        Scripture s1 = new Scripture(r1, "this is the scripture");
        Console.WriteLine(s1.GetDisplayText());

    }
}