using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {

        

        Reference r1 = new Reference("John", 3, 16);

        // Console.WriteLine(r1.GetDisplayText());
        // Console.WriteLine(r2.GetDisplayText());

        // Word w1 = new Word("hello there");

        Scripture s1 = new Scripture(r1, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        s1.GetDisplayText();

    }
}